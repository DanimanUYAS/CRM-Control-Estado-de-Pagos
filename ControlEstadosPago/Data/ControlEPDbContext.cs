using ControlEstadosPago.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEstadosPago.Data
{
    public class ControlEPDbContext : DbContext
    {
        public ControlEPDbContext(DbContextOptions<ControlEPDbContext> options)
            : base(options) { }

        
        public DbSet<Cliente> Clientes => Set<Cliente>();
        public DbSet<EstadosDePago> EstadosDePagos => Set<EstadosDePago>();
        public DbSet<Pago> Pagos => Set<Pago>();
        public DbSet<Producto> Productos => Set<Producto>();
        public DbSet<ProductosTemplate> ProductosTemplates => Set<ProductosTemplate>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Ejemplo de configuración fluida (opcional)
            //modelBuilder.Entity<Producto>()
            //    .Property(p => p.Precio)
            //    .HasPrecision(18, 2);
        }
    }

}

