using ControlEstadosPago.Data;
using ControlEstadosPago.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;

namespace ControlEstadosPago
{

class Program
    {
        private static string rutaSalida = Path.Combine([AppContext.BaseDirectory,"Salida","FacturasNoCoincidentes.csv"]);
        static async Task Main(string[] args)
        {
            Console.WriteLine("Iniciando sistema...");


            var host = Host.CreateDefaultBuilder(args)
                        .ConfigureAppConfiguration(cfg =>
                        {
                            cfg.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                        })
                        .ConfigureServices((context, services) =>
                        {
                            var cs = context.Configuration.GetConnectionString("Default");
                            services.AddDbContext<ControlEPDbContext>(o => o.UseSqlServer(cs));
                        })
                        .Build();

            using var scope = host.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<ControlEPDbContext>();

            Console.WriteLine(" --- Procesando consultas --- ");
            
            var cantidadClientes = await db.Clientes.AsNoTracking().Where(c => c.Estado_Id == 1 && c.Eliminado == false).CountAsync();


            Console.WriteLine($"1) Cantidad de clientes activos: {cantidadClientes}");

            Console.WriteLine($"2) Lista de clientes activos");

            List<ClienteEstado> clientes = await db.Clientes
                .Where(c => c.Estado_Id == 1 && !c.Eliminado)
                .OrderBy(c => c.Id)
                .Select(c => new ClienteEstado
                {
                    Id = c.Id,
                    Nombre = c.Nombre,
                    Apellido = c.Apellido,
                    // Manejo de null por si la relación es opcional
                    Reintentos = c.EstadosDePago != null ? c.EstadosDePago.Reintentos : 0,
                    PagosPendientes = c.EstadosDePago != null ? c.EstadosDePago.PagosPendientes : 0
                })
                .AsNoTracking()
                .ToListAsync();

            var clientesT = await db.Clientes.AsNoTracking().Where(c => c.Estado_Id == 1 && c.Eliminado == false).ToListAsync();

            var q = clientesT.Join(await db.Productos.ToListAsync(), c => c.Producto_Id, p => p.Id, (c, p) => new { c, p })
                .Join(await db.ProductosTemplates.Where(pt=>pt.Id != 148).ToListAsync(), cp => cp.p.ProductoTemplate_Id, pt => pt.Id, (p, pt) => new { p.c, p.p, pt });

            //foreach (var item in q)
            //{
            //    Console.WriteLine(string.Join(" - ",[item.c.Nombre, item.p.Nombre, item.pt.Nombre]));
            //}
            Console.WriteLine($"Cantidad: {q.Count()}");

            ///

            Console.WriteLine("3) Listado de control de pagos pendientes");
            var pagos = await db.Clientes.Include(c => c.EstadosDePago)
                                 .Where(c =>
                                     !c.Eliminado &&
                                     c.Estado_Id == 1
                                 )
                                 .Select(c => new PagoAdeudado
                                 {
                                     Cliente = c,
                                     Pendientes = c.EstadosDePago != null ? c.EstadosDePago.PagosPendientes : 0,
                                     Reintentos = c.EstadosDePago != null ? c.EstadosDePago.Reintentos : 0,
                                     PagosAdeudados = c.Pagos
                                         .Where(p => p.YaCobrado == false)
                                         .ToList()
                                 })
                                 .ToListAsync();

            List<PagoAdeudado> noCoincidentes = new();

            foreach (var p in pagos)
            {

                string comp = (p.Pendientes != p.PagosAdeudados.Count) ? "NO COINCIDEN" : "OK";
                if (comp != "OK")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    noCoincidentes.Add(p);
                }

                Console.WriteLine($"{ p.Cliente.Id }: { p.Cliente.Nombre } { p.Cliente.Apellido } - Reintentos : { p.Reintentos } - Pendientes: { p.Pendientes } - Reales: {p.PagosAdeudados.Count} -> Resultado: {comp}");
                Console.ResetColor();
            }

            foreach (var p in noCoincidentes)
            {
                Console.WriteLine($"{p.Cliente.Id}: {p.Cliente.Nombre} {p.Cliente.Apellido}");
                p.PagosAdeudados.ForEach(n => Console.WriteLine($"{ n.Id }-{ n.Monto }-{ n.MesCargoNumero }-{ n.AñoCargoNumero }"));

            }

            await CrearArchivoSalida(noCoincidentes);

            Console.WriteLine(" === FIN === ");
            Console.ReadLine();
        }

        private static async Task CrearArchivoSalida(List<PagoAdeudado> noCoincidentes)
        {

            if (!File.Exists(rutaSalida))
            {
                File.WriteAllText(rutaSalida, $"IdCliente,Nombre, Apellido,IdFactura,Monto,Fecha,MesCargo,AñoCargo" + Environment.NewLine, new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
            }

            // 2) Armar líneas y anexarlas
            var nuevasLineas = new List<string>();
            
            foreach (var p in noCoincidentes)
            {
                p.PagosAdeudados.ForEach(n =>
                {
                    string linea = string.Join(",", CSV(p.Cliente.Id), CSV(p.Cliente.Nombre), CSV(p.Cliente.Apellido), CSV(n.Id), CSV(n.Monto), CSV(n.Fecha), CSV(n.MesCargoNumero), CSV(n.AñoCargoNumero));

                    nuevasLineas.Add(linea);
                });
            }

            // Escribir en lote (más eficiente que escribir una a una)
            File.AppendAllLines(rutaSalida, nuevasLineas, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
        }

        static string CSV(object? value)
        {
            if (value == null) return "";
            string s = value.ToString() ?? "";
            bool requiereComillas = s.Contains(',') || s.Contains('"') || s.Contains('\n') || s.Contains('\r');
            if (s.Contains('"')) s = s.Replace("\"", "\"\""); // duplicar comillas
            return requiereComillas ? $"\"{s}\"" : s;
        }


    }


    internal class PagoAdeudado
    {
        public Cliente Cliente { get; set; }

        public int Pendientes { get; set; } = 0;
        public int Reintentos { get; set; } = 0;
        public List<Pago> PagosAdeudados { get; set; }
    }

    internal class ClienteEstado
    {
        public int Id { get; set; }
        public string Nombre { get; internal set; }
        public string Apellido { get; internal set; }

        public int Reintentos { get; set; }
        public int PagosPendientes { get; set; }
    }
}

