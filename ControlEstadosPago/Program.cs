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

            if (!await ProbarConexionBaseDatos(db))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No fue posible conectarse a la base de datos. Revise las configuraciones de la aplicación e intente nuevamente.");
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Conexión a la base de datos verificada correctamente.");
            Console.WriteLine(" --- Procesando consultas --- ");

            List<ClienteEstado> clientesConReglaReintentos = await (
                from cliente in db.Clientes
                join producto in db.Productos on cliente.Producto_Id equals producto.Id
                join regla in db.ReglasFacturacionCobranzaProductosTemplate
                    on producto.ProductoTemplate_Id equals regla.ProductoTemplate_Id
                where cliente.Estado_Id == 1
                    && !cliente.Eliminado
                    && regla.Regla_FacturacionCobranza_Id == 1
                select new ClienteEstado
                {
                    Id = cliente.Id,
                    Nombre = cliente.Nombre,
                    Apellido = cliente.Apellido,
                    Reintentos = cliente.EstadosDePago != null ? cliente.EstadosDePago.Reintentos : 0,
                    PagosPendientes = cliente.EstadosDePago != null ? cliente.EstadosDePago.PagosPendientes : 0
                })
                .Distinct()
                .OrderBy(c => c.Id)
                .AsNoTracking()
                .ToListAsync();

            Console.WriteLine("1) Clientes activos con la regla de reintentos");
            foreach (var cliente in clientesConReglaReintentos)
            {
                Console.WriteLine($"{cliente.Id}: {cliente.Nombre} {cliente.Apellido}");
            }
            Console.WriteLine($"Cantidad: {clientesConReglaReintentos.Count}");

            Console.WriteLine("2) Listado de control de pagos pendientes");
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

        private static async Task<bool> ProbarConexionBaseDatos(ControlEPDbContext db)
        {
            try
            {
                return await db.Database.CanConnectAsync();
            }
            catch (Exception)
            {
                return false;
            }
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
