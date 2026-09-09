using System;
using System.Collections.Generic;
using ControlEstadosPago.Models;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Data;

public partial class TempDbContext : DbContext
{
    public TempDbContext()
    {
    }

    public TempDbContext(DbContextOptions<TempDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Archivo> Archivos { get; set; }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<ArticuloGtiaPeriodoPorcentaje> ArticuloGtiaPeriodoPorcentajes { get; set; }

    public virtual DbSet<ArticulosMotociclo> ArticulosMotociclos { get; set; }

    public virtual DbSet<Articulos_SinPrecio> Articulos_SinPrecios { get; set; }

    public virtual DbSet<AsociacionFactura_NC> AsociacionFactura_NCs { get; set; }

    public virtual DbSet<AtributoProducto> AtributoProductos { get; set; }

    public virtual DbSet<AtributoProductoProductoTemplate> AtributoProductoProductoTemplates { get; set; }

    public virtual DbSet<Audio> Audios { get; set; }

    public virtual DbSet<AudiosSinVentum> AudiosSinVenta { get; set; }

    public virtual DbSet<BI_Clientes_1> BI_Clientes_1s { get; set; }

    public virtual DbSet<BI_Clientes_TMK_Seguimiento_Campana> BI_Clientes_TMK_Seguimiento_Campanas { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<BancosProductoTemplate> BancosProductoTemplates { get; set; }

    public virtual DbSet<Bonificacione> Bonificaciones { get; set; }

    public virtual DbSet<CLIENTES_RW> CLIENTES_RWs { get; set; }

    public virtual DbSet<CambioTarjeta> CambioTarjetas { get; set; }

    public virtual DbSet<CambioTarjetas20240605> CambioTarjetas20240605s { get; set; }

    public virtual DbSet<CambioTarjetas_20240902> CambioTarjetas_20240902s { get; set; }

    public virtual DbSet<CambioTarjetas_20240909> CambioTarjetas_20240909s { get; set; }

    public virtual DbSet<CambioTarjetas_20240910> CambioTarjetas_20240910s { get; set; }

    public virtual DbSet<CambioTarjetas_230728> CambioTarjetas_230728s { get; set; }

    public virtual DbSet<CambioTarjetas_bak> CambioTarjetas_baks { get; set; }

    public virtual DbSet<CambioTarjetas_datum> CambioTarjetas_data { get; set; }

    public virtual DbSet<Cambio_TarjetasFactPendiente> Cambio_TarjetasFactPendientes { get; set; }

    public virtual DbSet<CanalVentum> CanalVenta { get; set; }

    public virtual DbSet<CategoriaCausal> CategoriaCausals { get; set; }

    public virtual DbSet<CausalesDeBaja> CausalesDeBajas { get; set; }

    public virtual DbSet<CierrePeriodo> CierrePeriodos { get; set; }

    public virtual DbSet<CiudadLocalidad> CiudadLocalidads { get; set; }

    public virtual DbSet<CiudadesPronto> CiudadesProntos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteHistorial> ClienteHistorials { get; set; }

    public virtual DbSet<ClienteTransaccion> ClienteTransaccions { get; set; }

    public virtual DbSet<ClientesCorporativo> ClientesCorporativos { get; set; }

    public virtual DbSet<ClientesDeAlta_FormaPago> ClientesDeAlta_FormaPagos { get; set; }

    public virtual DbSet<ClientesNuevosZurichSantander> ClientesNuevosZurichSantanders { get; set; }

    public virtual DbSet<ClientesNuevosZurichSantander_MIAuto> ClientesNuevosZurichSantander_MIAutos { get; set; }

    public virtual DbSet<ClientesNuevosZurichSantander_reenvio> ClientesNuevosZurichSantander_reenvios { get; set; }

    public virtual DbSet<ClientesProducto> ClientesProductos { get; set; }

    public virtual DbSet<Clientes_Completum> Clientes_Completa { get; set; }

    public virtual DbSet<CodificacionesCuentum> CodificacionesCuenta { get; set; }

    public virtual DbSet<CodigosActivacion> CodigosActivacions { get; set; }

    public virtual DbSet<Colore> Colores { get; set; }

    public virtual DbSet<Consulta> Consultas { get; set; }

    public virtual DbSet<ConsultasPerfil> ConsultasPerfils { get; set; }

    public virtual DbSet<Cotizacione> Cotizaciones { get; set; }

    public virtual DbSet<CuentasCorriente> CuentasCorrientes { get; set; }

    public virtual DbSet<DatosCRM_L1705> DatosCRM_L1705s { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DepartamentoLocalidad> DepartamentoLocalidads { get; set; }

    public virtual DbSet<Documento> Documentos { get; set; }

    public virtual DbSet<DocumentosFacturacion> DocumentosFacturacions { get; set; }

    public virtual DbSet<Duracione> Duraciones { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<EstadoIncidencia> EstadoIncidencias { get; set; }

    public virtual DbSet<EstadosAuxiliare> EstadosAuxiliares { get; set; }

    public virtual DbSet<EstadosAuxiliaresProductosTemplate> EstadosAuxiliaresProductosTemplates { get; set; }

    public virtual DbSet<EstadosDeCobro> EstadosDeCobros { get; set; }

    public virtual DbSet<EstadosDePago> EstadosDePagos { get; set; }

    public virtual DbSet<EstadosDePagos_back> EstadosDePagos_backs { get; set; }

    public virtual DbSet<FacturasParaNC> FacturasParaNCs { get; set; }

    public virtual DbSet<FamiliaDeArticulo> FamiliaDeArticulos { get; set; }

    public virtual DbSet<FixCliente> FixClientes { get; set; }

    public virtual DbSet<FormasDePago> FormasDePagos { get; set; }

    public virtual DbSet<FormasDePagosProductoTemplate> FormasDePagosProductoTemplates { get; set; }

    public virtual DbSet<FormasDePagos_DebitoCuentum> FormasDePagos_DebitoCuenta { get; set; }

    public virtual DbSet<FormasDePagos_PagoContado> FormasDePagos_PagoContados { get; set; }

    public virtual DbSet<FormasDePagos_PagoTarjetum> FormasDePagos_PagoTarjeta { get; set; }

    public virtual DbSet<GeneracionDeFactura> GeneracionDeFacturas { get; set; }

    public virtual DbSet<GrupoGeneracionCobranza> GrupoGeneracionCobranzas { get; set; }

    public virtual DbSet<GrupoGeneracionCobraza_ProductoTemplate> GrupoGeneracionCobraza_ProductoTemplates { get; set; }

    public virtual DbSet<HistorialCargaWeb> HistorialCargaWebs { get; set; }

    public virtual DbSet<HistorialCliente> HistorialClientes { get; set; }

    public virtual DbSet<IdenTransExt> IdenTransExts { get; set; }

    public virtual DbSet<Incidencia> Incidencias { get; set; }

    public virtual DbSet<IndicadoresFacturacion> IndicadoresFacturacions { get; set; }

    public virtual DbSet<Localidade> Localidades { get; set; }

    public virtual DbSet<Lote1267> Lote1267s { get; set; }

    public virtual DbSet<Lote1705> Lote1705s { get; set; }

    public virtual DbSet<Lote2027> Lote2027s { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<MarcaArticulo> MarcaArticulos { get; set; }

    public virtual DbSet<MarcasTarjetum> MarcasTarjeta { get; set; }

    public virtual DbSet<Marcas_Articulo> Marcas_Articulos { get; set; }

    public virtual DbSet<MetodoServicio> MetodoServicios { get; set; }

    public virtual DbSet<MetodoServicios_Permiso> MetodoServicios_Permisos { get; set; }

    public virtual DbSet<Migracione> Migraciones { get; set; }

    public virtual DbSet<ModalidadDeFacturacionProductoTemplate> ModalidadDeFacturacionProductoTemplates { get; set; }

    public virtual DbSet<ModalidadesDeFacturacion> ModalidadesDeFacturacions { get; set; }

    public virtual DbSet<Modelo> Modelos { get; set; }

    public virtual DbSet<ModeloArticulo> ModeloArticulos { get; set; }

    public virtual DbSet<Moneda> Monedas { get; set; }

    public virtual DbSet<NumerosContrato> NumerosContratos { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Pagos2> Pagos2s { get; set; }

    public virtual DbSet<Paise> Paises { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<Parametros_CRM> Parametros_CRMs { get; set; }

    public virtual DbSet<PerfilDeUsuario> PerfilDeUsuarios { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<PolizasFaltante> PolizasFaltantes { get; set; }

    public virtual DbSet<Precio> Precios { get; set; }

    public virtual DbSet<PreciosCelular> PreciosCelulars { get; set; }

    public virtual DbSet<PreciosGE> PreciosGEs { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductoTemplateCantidadCuota> ProductoTemplateCantidadCuotas { get; set; }

    public virtual DbSet<ProductosTemplate> ProductosTemplates { get; set; }

    public virtual DbSet<ProductosTemplate_SeguroCocheTemplate> ProductosTemplate_SeguroCocheTemplates { get; set; }

    public virtual DbSet<ProductosTemplate_SeguroElectrodomesticoTemplate> ProductosTemplate_SeguroElectrodomesticoTemplates { get; set; }

    public virtual DbSet<ProductosTemplate_SeguroTemplate> ProductosTemplate_SeguroTemplates { get; set; }

    public virtual DbSet<Productos_CicloSeguro> Productos_CicloSeguros { get; set; }

    public virtual DbSet<Productos_Gallito> Productos_Gallitos { get; set; }

    public virtual DbSet<Productos_Seguro> Productos_Seguros { get; set; }

    public virtual DbSet<Productos_SeguroCoche> Productos_SeguroCoches { get; set; }

    public virtual DbSet<Productos_SeguroElectrodomestico> Productos_SeguroElectrodomesticos { get; set; }

    public virtual DbSet<Productos_SeguroReintegro> Productos_SeguroReintegros { get; set; }

    public virtual DbSet<Productos_SeguroVuelo> Productos_SeguroVuelos { get; set; }

    public virtual DbSet<ProveedoresSuscripcione> ProveedoresSuscripciones { get; set; }

    public virtual DbSet<Regla_FacturacionCobranza> Regla_FacturacionCobranzas { get; set; }

    public virtual DbSet<Regla_FacturacionCobranza_ProductoTemplate> Regla_FacturacionCobranza_ProductoTemplates { get; set; }

    public virtual DbSet<ReqAudio> ReqAudios { get; set; }

    public virtual DbSet<Sucursal_ProductoTemplate> Sucursal_ProductoTemplates { get; set; }

    public virtual DbSet<Sucursal_Supervisor> Sucursal_Supervisors { get; set; }

    public virtual DbSet<Sucursal_Vendedor> Sucursal_Vendedors { get; set; }

    public virtual DbSet<Sucursale> Sucursales { get; set; }

    public virtual DbSet<Supervisor_ProductoTemplate> Supervisor_ProductoTemplates { get; set; }

    public virtual DbSet<Suscripcione> Suscripciones { get; set; }

    public virtual DbSet<TablaTemporal> TablaTemporals { get; set; }

    public virtual DbSet<TablasMonitore> TablasMonitores { get; set; }

    public virtual DbSet<TarjetasDeCredito> TarjetasDeCreditos { get; set; }

    public virtual DbSet<TasaIVA> TasaIVAs { get; set; }

    public virtual DbSet<Telefono> Telefonos { get; set; }

    public virtual DbSet<TipoDeCambio> TipoDeCambios { get; set; }

    public virtual DbSet<TipoDeDocumento> TipoDeDocumentos { get; set; }

    public virtual DbSet<TipoTarjeta> TipoTarjetas { get; set; }

    public virtual DbSet<TiposDeBonificacion> TiposDeBonificacions { get; set; }

    public virtual DbSet<TiposDeTelefono> TiposDeTelefonos { get; set; }

    public virtual DbSet<TiposGarantium> TiposGarantia { get; set; }

    public virtual DbSet<TiposIncidencia> TiposIncidencias { get; set; }

    public virtual DbSet<TiposProducto> TiposProductos { get; set; }

    public virtual DbSet<TiposProductoTemplate> TiposProductoTemplates { get; set; }

    public virtual DbSet<TiposTarjetasProductoTemplate> TiposTarjetasProductoTemplates { get; set; }

    public virtual DbSet<Todo_clientes_camposcomp> Todo_clientes_camposcomps { get; set; }

    public virtual DbSet<Transaccione> Transacciones { get; set; }

    public virtual DbSet<Tratativa> Tratativas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vendedor_ProductoTemplate> Vendedor_ProductoTemplates { get; set; }

    public virtual DbSet<Vendedore> Vendedores { get; set; }

    public virtual DbSet<VentasProvisoria> VentasProvisorias { get; set; }

    public virtual DbSet<Vista_1> Vista_1s { get; set; }

    public virtual DbSet<Vista_2> Vista_2s { get; set; }

    public virtual DbSet<bajasANTEL> bajasANTELs { get; set; }

    public virtual DbSet<completaCliente> completaClientes { get; set; }

    public virtual DbSet<tceliminar> tceliminars { get; set; }

    public virtual DbSet<validacion> validacions { get; set; }

    public virtual DbSet<vwEncryptPago> vwEncryptPagos { get; set; }

    public virtual DbSet<vwGrupoGeneracionDeCobro> vwGrupoGeneracionDeCobros { get; set; }

    public virtual DbSet<vwReglas_FacturacionCobranza> vwReglas_FacturacionCobranzas { get; set; }

    public virtual DbSet<vwReintento> vwReintentos { get; set; }

    public virtual DbSet<vwUsuariosPermiso> vwUsuariosPermisos { get; set; }

    public virtual DbSet<vw_encrypt_TarjetasDeCredito> vw_encrypt_TarjetasDeCreditos { get; set; }

    public virtual DbSet<wsCrmCredisurArchivoCobranza> wsCrmCredisurArchivoCobranzas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SUY002001-DEV;Initial Catalog=CRM_20251008_DEV;User ID=adm-switch;Password=Switch.2k23!;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Archivo>(entity =>
        {
            entity.HasMany(d => d.Incidencias).WithMany(p => p.Archivos)
                .UsingEntity<Dictionary<string, object>>(
                    "ArchivoIncidencium",
                    r => r.HasOne<Incidencia>().WithMany()
                        .HasForeignKey("Incidencias_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ArchivoIncidencia_Incidencia"),
                    l => l.HasOne<Archivo>().WithMany()
                        .HasForeignKey("Archivos_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ArchivoIncidencia_Archivo"),
                    j =>
                    {
                        j.HasKey("Archivos_Id", "Incidencias_Id").IsClustered(false);
                        j.ToTable("ArchivoIncidencia");
                        j.HasIndex(new[] { "Incidencias_Id" }, "IX_FK_ArchivoIncidencia_Incidencia");
                    });
        });

        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasOne(d => d.ArticuloSeguroElectrodomesticoTemplate_Articulo).WithMany(p => p.Articulos).HasConstraintName("FK_ArticuloSeguroElectrodomesticoTemplate");

            entity.HasMany(d => d.Marcas).WithMany(p => p.ArticuloMarca_Marcas)
                .UsingEntity<Dictionary<string, object>>(
                    "ArticuloMarca",
                    r => r.HasOne<Marca>().WithMany()
                        .HasForeignKey("Marcas_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ArticuloMarca_Marca"),
                    l => l.HasOne<Articulo>().WithMany()
                        .HasForeignKey("ArticuloMarca_Marca_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ArticuloMarca_Articulo"),
                    j =>
                    {
                        j.HasKey("ArticuloMarca_Marca_Id", "Marcas_Id").IsClustered(false);
                        j.ToTable("ArticuloMarca");
                        j.HasIndex(new[] { "Marcas_Id" }, "IX_FK_ArticuloMarca_Marca");
                    });

            entity.HasMany(d => d.Pais).WithMany(p => p.Articulos)
                .UsingEntity<Dictionary<string, object>>(
                    "ArticuloPai",
                    r => r.HasOne<Paise>().WithMany()
                        .HasForeignKey("Pais_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Pais"),
                    l => l.HasOne<Articulo>().WithMany()
                        .HasForeignKey("Articulo_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Articulo"),
                    j =>
                    {
                        j.HasKey("Articulo_Id", "Pais_Id").IsClustered(false);
                        j.ToTable("ArticuloPais");
                    });

            entity.HasMany(d => d.TipoProductoTemplates).WithMany(p => p.ArticuloTipoProductoTemplate_TipoProductoTemplates)
                .UsingEntity<Dictionary<string, object>>(
                    "ArticuloTipoProductoTemplate",
                    r => r.HasOne<TiposProductoTemplate>().WithMany()
                        .HasForeignKey("TipoProductoTemplate_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ArticuloTipoProductoTemplate_TipoProductoTemplate"),
                    l => l.HasOne<Articulo>().WithMany()
                        .HasForeignKey("ArticuloTipoProductoTemplate_TipoProductoTemplate_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ArticuloTipoProductoTemplate_Articulo"),
                    j =>
                    {
                        j.HasKey("ArticuloTipoProductoTemplate_TipoProductoTemplate_Id", "TipoProductoTemplate_Id").IsClustered(false);
                        j.ToTable("ArticuloTipoProductoTemplate");
                        j.HasIndex(new[] { "TipoProductoTemplate_Id" }, "IX_FK_ArticuloTipoProductoTemplate_TipoProductoTemplate");
                    });
        });

        modelBuilder.Entity<ArticuloGtiaPeriodoPorcentaje>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ArticuloTipoGtiaPeriodoPorcentaje");
        });

        modelBuilder.Entity<Articulos_SinPrecio>(entity =>
        {
            entity.ToView("Articulos_SinPrecio");
        });

        modelBuilder.Entity<AsociacionFactura_NC>(entity =>
        {
            entity.Property(e => e.Fac_id).IsFixedLength();
            entity.Property(e => e.NC_id).IsFixedLength();
        });

        modelBuilder.Entity<AtributoProductoProductoTemplate>(entity =>
        {
            entity.HasKey(e => new { e.AtributosProducto_Id, e.AtributoProductoProductoTemplate_AtributoProducto_Id }).IsClustered(false);

            entity.HasOne(d => d.AtributoProductoProductoTemplate_AtributoProducto).WithMany(p => p.AtributoProductoProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtributoProductoProductoTemplate_ProductoTemplate");

            entity.HasOne(d => d.AtributosProducto).WithMany(p => p.AtributoProductoProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AtributoProductoProductoTemplate_AtributoProducto");
        });

        modelBuilder.Entity<Audio>(entity =>
        {
            entity.HasOne(d => d.Cliente).WithMany(p => p.Audios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Audios_Clientes");
        });

        modelBuilder.Entity<BI_Clientes_1>(entity =>
        {
            entity.ToView("BI_Clientes_1");
        });

        modelBuilder.Entity<BI_Clientes_TMK_Seguimiento_Campana>(entity =>
        {
            entity.ToView("BI_Clientes_TMK_Seguimiento_Campana");
        });

        modelBuilder.Entity<BancosProductoTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Banco_Id, e.ProductoTemplate_Id }).IsClustered(false);

            entity.HasOne(d => d.Banco).WithMany(p => p.BancosProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BancoProductoTemplate_Banco");

            entity.HasOne(d => d.ProductoTemplate).WithMany(p => p.BancosProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BancoProductoTemplate_ProductoTemplate");
        });

        modelBuilder.Entity<Bonificacione>(entity =>
        {
            entity.HasOne(d => d.TipoDeBonificacion).WithMany(p => p.Bonificaciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoDeBonificacionBonificacion");

            entity.HasMany(d => d.BonificacionProducto_Bonificacions).WithMany(p => p.Bonificacions)
                .UsingEntity<Dictionary<string, object>>(
                    "BonificacionProducto",
                    r => r.HasOne<Producto>().WithMany()
                        .HasForeignKey("BonificacionProducto_Bonificacion_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_BonificacionProducto_Producto"),
                    l => l.HasOne<Bonificacione>().WithMany()
                        .HasForeignKey("Bonificacion_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_BonificacionProducto_Bonificacion"),
                    j =>
                    {
                        j.HasKey("Bonificacion_Id", "BonificacionProducto_Bonificacion_Id").IsClustered(false);
                        j.ToTable("BonificacionProducto");
                        j.HasIndex(new[] { "BonificacionProducto_Bonificacion_Id" }, "IX_FK_BonificacionProducto_Producto");
                    });
        });

        modelBuilder.Entity<CausalesDeBaja>(entity =>
        {
            entity.HasOne(d => d.Categoria).WithMany(p => p.CausalesDeBajas).HasConstraintName("FK_CausalesDeBaja_CategoriaCausal");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("ActualizarCAPCambioDeEstadoCliente");
                    tb.HasTrigger("AsignarCAPNuevoCliente");
                    tb.HasTrigger("TR_INSERT_Cliente_UpdateAt");
                    tb.HasTrigger("TR_UPDATE_Cliente_UpdateAt");
                });

            entity.Property(e => e.Sexo).IsFixedLength();
        });

        modelBuilder.Entity<ClienteHistorial>(entity =>
        {
            entity.HasOne(d => d.Departamento).WithMany(p => p.ClienteHistorials).HasConstraintName("FK_ClienteHistorialDepartamento");

            entity.HasOne(d => d.Estado).WithMany(p => p.ClienteHistorials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteHistorialEstado");

            entity.HasOne(d => d.Localidad).WithMany(p => p.ClienteHistorials).HasConstraintName("FK_ClienteHistorialLocalidad");

            entity.HasOne(d => d.Producto).WithMany(p => p.ClienteHistorials)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoClienteHistorial");
        });

        modelBuilder.Entity<ClienteTransaccion>(entity =>
        {
            entity.HasOne(d => d.Cliente).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteTransaccion_Clientes");
        });

        modelBuilder.Entity<ClientesDeAlta_FormaPago>(entity =>
        {
            entity.ToView("ClientesDeAlta_FormaPago");
        });

        modelBuilder.Entity<ClientesNuevosZurichSantander>(entity =>
        {
            entity.ToView("ClientesNuevosZurichSantander");

            entity.Property(e => e.Sexo).IsFixedLength();
        });

        modelBuilder.Entity<ClientesNuevosZurichSantander_MIAuto>(entity =>
        {
            entity.ToView("ClientesNuevosZurichSantander_MIAuto");

            entity.Property(e => e.Sexo).IsFixedLength();
        });

        modelBuilder.Entity<ClientesNuevosZurichSantander_reenvio>(entity =>
        {
            entity.ToView("ClientesNuevosZurichSantander_reenvio");

            entity.Property(e => e.Sexo).IsFixedLength();
        });

        modelBuilder.Entity<ClientesProducto>(entity =>
        {
            entity.ToView("ClientesProductos");
        });

        modelBuilder.Entity<Clientes_Completum>(entity =>
        {
            entity.ToView("Clientes_Completa");
        });

        modelBuilder.Entity<CodificacionesCuentum>(entity =>
        {
            entity.Property(e => e.DeudorSAP).HasDefaultValue("-");
            entity.Property(e => e.Origen).HasDefaultValue("-");
        });

        modelBuilder.Entity<CodigosActivacion>(entity =>
        {
            entity.Property(e => e.Estado).HasDefaultValue("DISPONIBLE");
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaModificacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ConsultasPerfil>(entity =>
        {
            entity.HasOne(d => d.IdConsultaNavigation).WithMany(p => p.ConsultasPerfils)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsultasPerfil_Consultas");

            entity.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.ConsultasPerfils)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsultasPerfil_Perfiles");
        });

        modelBuilder.Entity<CuentasCorriente>(entity =>
        {
            entity.HasOne(d => d.Cliente).WithMany(p => p.CuentasCorrientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteCuentaCorriente");

            entity.HasOne(d => d.Moneda).WithMany(p => p.CuentasCorrientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CuentaCorrienteMoneda");
        });

        modelBuilder.Entity<Documento>(entity =>
        {
            entity.HasOne(d => d.Cliente).WithMany(p => p.Documentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteDocumento");

            entity.HasOne(d => d.TipoDeDocumento).WithMany(p => p.Documentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentoTipoDeDocumento");
        });

        modelBuilder.Entity<EstadoIncidencia>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<EstadosAuxiliare>(entity =>
        {
            entity.HasOne(d => d.EstadoReal).WithMany(p => p.EstadosAuxiliares).HasConstraintName("FK_EstadosAuxiliares_Estados");
        });

        modelBuilder.Entity<EstadosAuxiliaresProductosTemplate>(entity =>
        {
            entity.HasOne(d => d.IdEstadoAuxiliarNavigation).WithMany().HasConstraintName("FK_EstadosAuxiliaresProductosTemplate_EstadosAuxiliares");

            entity.HasOne(d => d.IdProductoTemplateNavigation).WithMany().HasConstraintName("FK_EstadosAuxiliaresProductosTemplate_ProductosTemplate");
        });

        modelBuilder.Entity<EstadosDePago>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_Reintentos"));

            entity.HasOne(d => d.Cliente).WithOne(p => p.EstadosDePago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EstadosDePagosCliente");
        });

        modelBuilder.Entity<EstadosDePagos_back>(entity =>
        {
            entity.Property(e => e.CobrosConsecutivos).HasDefaultValue(0);
            entity.Property(e => e.CobrosFallidos).HasDefaultValue(0);
        });

        modelBuilder.Entity<FormasDePago>(entity =>
        {
            entity.HasOne(d => d.ProductoTemplateFormaDePago_FormaDePago).WithMany(p => p.FormasDePagos).HasConstraintName("FK_ProductoTemplateFormaDePago");
        });

        modelBuilder.Entity<FormasDePagosProductoTemplate>(entity =>
        {
            entity.HasKey(e => new { e.FormasDePagos_Id, e.ProductoTemplate_Id }).IsClustered(false);

            entity.HasOne(d => d.FormasDePagos).WithMany(p => p.FormasDePagosProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormaDePagoProductoTemplate_FormaDePago");

            entity.HasOne(d => d.ProductoTemplate).WithMany(p => p.FormasDePagosProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormaDePagoProductoTemplate_ProductoTemplate");
        });

        modelBuilder.Entity<FormasDePagos_DebitoCuentum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.FormasDePagos_DebitoCuentum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DebitoCuenta_inherits_FormaDePago");
        });

        modelBuilder.Entity<FormasDePagos_PagoContado>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Pago).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.FormasDePagos_PagoContado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PagoContado_inherits_FormaDePago");
        });

        modelBuilder.Entity<FormasDePagos_PagoTarjetum>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.FormasDePagos_PagoTarjetum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PagoTarjeta_inherits_FormaDePago");
        });

        modelBuilder.Entity<GrupoGeneracionCobranza>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<GrupoGeneracionCobraza_ProductoTemplate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<HistorialCliente>(entity =>
        {
            entity.HasOne(d => d.HistorialClienteCuentaCorriente_HistorialCliente).WithMany(p => p.HistorialClientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialClienteCuentaCorriente");

            entity.HasOne(d => d.HistorialClienteEstado_HistorialCliente).WithMany(p => p.HistorialClientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialClienteEstado");

            entity.HasOne(d => d.HistorialClienteProducto_HistorialCliente).WithMany(p => p.HistorialClientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialClienteProducto");

            entity.HasOne(d => d.HistorialClienteUsuario_HistorialCliente).WithMany(p => p.HistorialClientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialClienteUsuario");

            entity.HasOne(d => d.HistorialClienteVendedor_HistorialCliente).WithMany(p => p.HistorialClientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistorialClienteVendedor");

            entity.HasMany(d => d.HistorialClienteDocumento_HistorialClientes).WithMany(p => p.HistorialClienteDocumento_Documentos)
                .UsingEntity<Dictionary<string, object>>(
                    "HistorialClienteDocumento",
                    r => r.HasOne<Documento>().WithMany()
                        .HasForeignKey("HistorialClienteDocumento_HistorialCliente_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_HistorialClienteDocumento_Documento"),
                    l => l.HasOne<HistorialCliente>().WithMany()
                        .HasForeignKey("HistorialClienteDocumento_Documento_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_HistorialClienteDocumento_HistorialCliente"),
                    j =>
                    {
                        j.HasKey("HistorialClienteDocumento_Documento_Id", "HistorialClienteDocumento_HistorialCliente_Id").IsClustered(false);
                        j.ToTable("HistorialClienteDocumento");
                        j.HasIndex(new[] { "HistorialClienteDocumento_HistorialCliente_Id" }, "IX_FK_HistorialClienteDocumento_Documento");
                    });

            entity.HasMany(d => d.HistorialClienteFormaDePago_HistorialClientes).WithMany(p => p.HistorialClienteFormaDePago_FormaDePagos)
                .UsingEntity<Dictionary<string, object>>(
                    "HistorialClienteFormaDePago",
                    r => r.HasOne<FormasDePago>().WithMany()
                        .HasForeignKey("HistorialClienteFormaDePago_HistorialCliente_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_HistorialClienteFormaDePago_FormaDePago"),
                    l => l.HasOne<HistorialCliente>().WithMany()
                        .HasForeignKey("HistorialClienteFormaDePago_FormaDePago_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_HistorialClienteFormaDePago_HistorialCliente"),
                    j =>
                    {
                        j.HasKey("HistorialClienteFormaDePago_FormaDePago_Id", "HistorialClienteFormaDePago_HistorialCliente_Id").IsClustered(false);
                        j.ToTable("HistorialClienteFormaDePago");
                        j.HasIndex(new[] { "HistorialClienteFormaDePago_HistorialCliente_Id" }, "IX_FK_HistorialClienteFormaDePago_FormaDePago");
                    });

            entity.HasMany(d => d.HistorialClienteIncidencia_HistorialClientes).WithMany(p => p.HistorialClienteIncidencia_Incidencia)
                .UsingEntity<Dictionary<string, object>>(
                    "HistorialClienteIncidencium",
                    r => r.HasOne<Incidencia>().WithMany()
                        .HasForeignKey("HistorialClienteIncidencia_HistorialCliente_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_HistorialClienteIncidencia_Incidencia"),
                    l => l.HasOne<HistorialCliente>().WithMany()
                        .HasForeignKey("HistorialClienteIncidencia_Incidencia_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_HistorialClienteIncidencia_HistorialCliente"),
                    j =>
                    {
                        j.HasKey("HistorialClienteIncidencia_Incidencia_Id", "HistorialClienteIncidencia_HistorialCliente_Id").IsClustered(false);
                        j.ToTable("HistorialClienteIncidencia");
                        j.HasIndex(new[] { "HistorialClienteIncidencia_HistorialCliente_Id" }, "IX_FK_HistorialClienteIncidencia_Incidencia");
                    });

            entity.HasMany(d => d.HistorialClienteTelefono_HistorialClientes).WithMany(p => p.HistorialClienteTelefono_Telefonos)
                .UsingEntity<Dictionary<string, object>>(
                    "HistorialClienteTelefono",
                    r => r.HasOne<Telefono>().WithMany()
                        .HasForeignKey("HistorialClienteTelefono_HistorialCliente_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_HistorialClienteTelefono_Telefono"),
                    l => l.HasOne<HistorialCliente>().WithMany()
                        .HasForeignKey("HistorialClienteTelefono_Telefono_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_HistorialClienteTelefono_HistorialCliente"),
                    j =>
                    {
                        j.HasKey("HistorialClienteTelefono_Telefono_Id", "HistorialClienteTelefono_HistorialCliente_Id").IsClustered(false);
                        j.ToTable("HistorialClienteTelefono");
                        j.HasIndex(new[] { "HistorialClienteTelefono_HistorialCliente_Id" }, "IX_FK_HistorialClienteTelefono_Telefono");
                    });
        });

        modelBuilder.Entity<Incidencia>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("ReasignarCAP"));

            entity.HasOne(d => d.Cliente).WithMany(p => p.Incidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteIncidencia");

            entity.HasOne(d => d.EstadoIncidencia).WithMany(p => p.Incidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidenciaEstadoIncidencia");

            entity.HasOne(d => d.ProductoTemplate).WithMany(p => p.Incidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidenciaProductoTemplate");

            entity.HasOne(d => d.TipoIncidencia).WithMany(p => p.Incidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IncidenciaTipoIncidencia");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Incidencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UsuariosIncidencia");
        });

        modelBuilder.Entity<IndicadoresFacturacion>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<MarcasTarjetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MarcaTarjeta");
        });

        modelBuilder.Entity<MetodoServicio>(entity =>
        {
            entity.Property(e => e.ID).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MetodoServicios_Permiso>(entity =>
        {
            entity.HasOne(d => d.IDMetodoServiciosNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MetodoServicios_Permisos_MetodoServicios");

            entity.HasOne(d => d.IDPermisosNavigation).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MetodoServicios_Permisos_Permisos");
        });

        modelBuilder.Entity<Migracione>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("NombrePersonalizado"));

            entity.Property(e => e.Descripcion).HasComment("Usado para almacenar la descripción de la migración ejecutada.");
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasComment("Fecha y hora en que se ejecutó la migración");
            entity.Property(e => e.Nombre).HasComment("Usado para almacenar el nombre único de la migración");
            entity.Property(e => e.Usuario).HasDefaultValueSql("(suser_sname())");
        });

        modelBuilder.Entity<ModalidadDeFacturacionProductoTemplate>(entity =>
        {
            entity.HasKey(e => new { e.ModalidadDeFacturacion_Id, e.ProductoTemplate_Id }).IsClustered(false);

            entity.HasOne(d => d.ModalidadDeFacturacion).WithMany(p => p.ModalidadDeFacturacionProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ModalidadDeFacturacionProductoTemplate_ModalidadDeFacturacion");

            entity.HasOne(d => d.ProductoTemplate).WithMany(p => p.ModalidadDeFacturacionProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ModalidadDeFacturacionProductoTemplate_ProductoTemplate");
        });

        modelBuilder.Entity<Modelo>(entity =>
        {
            entity.HasOne(d => d.Marca).WithMany(p => p.Modelos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MarcaModelo");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.Property(e => e.EstadoFacturacion).HasDefaultValue("PENDIENTE");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Pagos).HasConstraintName("FK_ClientePago");

            entity.HasOne(d => d.FormaDePago).WithMany(p => p.Pagos).HasConstraintName("FK_PagoFormaDePago");

            entity.HasOne(d => d.TarjetaDeCredito).WithMany(p => p.Pagos).HasConstraintName("FK_PagoTarjetaDeCredito");
        });

        modelBuilder.Entity<Pagos2>(entity =>
        {
            entity.HasOne(d => d.Cliente).WithMany(p => p.Pagos2s).HasConstraintName("FK_ClientePago2");

            entity.HasOne(d => d.FormaDePago).WithMany(p => p.Pagos2s).HasConstraintName("FK_PagoFormaDePago2");
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.HasOne(d => d.Consulta).WithMany(p => p.Parametros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ConsultaParametro");
        });

        modelBuilder.Entity<Parametros_CRM>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PerfilDeUsuario>(entity =>
        {
            entity.HasMany(d => d.Permisos).WithMany(p => p.PerfilDeUsuarioPermiso_Permisos)
                .UsingEntity<Dictionary<string, object>>(
                    "PerfilDeUsuarioPermiso",
                    r => r.HasOne<Permiso>().WithMany()
                        .HasForeignKey("Permisos_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PerfilDeUsuarioPermiso_Permiso"),
                    l => l.HasOne<PerfilDeUsuario>().WithMany()
                        .HasForeignKey("PerfilDeUsuarioPermiso_Permiso_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PerfilDeUsuarioPermiso_PerfilDeUsuario"),
                    j =>
                    {
                        j.HasKey("PerfilDeUsuarioPermiso_Permiso_Id", "Permisos_Id").IsClustered(false);
                        j.ToTable("PerfilDeUsuarioPermiso");
                        j.HasIndex(new[] { "Permisos_Id" }, "IX_FK_PerfilDeUsuarioPermiso_Permiso");
                    });

            entity.HasMany(d => d.Usuarios).WithMany(p => p.Perfiles)
                .UsingEntity<Dictionary<string, object>>(
                    "PerfilDeUsuarioUsuario",
                    r => r.HasOne<Usuario>().WithMany()
                        .HasForeignKey("Usuarios_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PerfilDeUsuarioUsuario_Usuario"),
                    l => l.HasOne<PerfilDeUsuario>().WithMany()
                        .HasForeignKey("Perfiles_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_PerfilDeUsuarioUsuario_PerfilDeUsuario"),
                    j =>
                    {
                        j.HasKey("Perfiles_Id", "Usuarios_Id").IsClustered(false);
                        j.ToTable("PerfilDeUsuarioUsuario");
                        j.HasIndex(new[] { "Usuarios_Id" }, "IX_FK_PerfilDeUsuarioUsuario_Usuario");
                    });
        });

        modelBuilder.Entity<Precio>(entity =>
        {
            entity.HasOne(d => d.Moneda).WithMany(p => p.Precios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonedaPrecio");

            entity.HasOne(d => d.ProductoTemplatePrecio_Precio).WithMany(p => p.Precios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoTemplatePrecio");
        });

        modelBuilder.Entity<PreciosCelular>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PeciosCelular");
        });

        modelBuilder.Entity<PreciosGE>(entity =>
        {
            entity.HasOne(d => d.Articulo).WithMany(p => p.PreciosGEs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ArticuloPrecioGE");

            entity.HasOne(d => d.Moneda).WithMany(p => p.PreciosGEs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MonedaPrecioGE");

            entity.HasOne(d => d.ProductoTemplate).WithMany(p => p.PreciosGEs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoTemplatePrecioGE");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("TR_RestriccionAltas"));

            entity.HasOne(d => d.ClienteCorporativo).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoClienteCorporativo1");

            entity.HasOne(d => d.FormaDePago).WithMany(p => p.Productos).HasConstraintName("FK_ProductoFormaDePago");

            entity.HasOne(d => d.ModalidadDeFacturacion).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoModalidadDeFacturacion");

            entity.HasOne(d => d.ProductoTemplate).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoProductoTemplate");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoUsuario");

            entity.HasOne(d => d.Vendedor).WithMany(p => p.Productos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoVendedor");

            entity.HasMany(d => d.AtributosProductos).WithMany(p => p.ProductoAtributoProducto1_AtributoProductos)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoAtributoProducto1",
                    r => r.HasOne<AtributoProducto>().WithMany()
                        .HasForeignKey("AtributosProducto_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoAtributoProducto1_AtributoProducto"),
                    l => l.HasOne<Producto>().WithMany()
                        .HasForeignKey("ProductoAtributoProducto1_AtributoProducto_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoAtributoProducto1_Producto"),
                    j =>
                    {
                        j.HasKey("ProductoAtributoProducto1_AtributoProducto_Id", "AtributosProducto_Id").IsClustered(false);
                        j.ToTable("ProductoAtributoProducto1");
                        j.HasIndex(new[] { "AtributosProducto_Id" }, "IX_FK_ProductoAtributoProducto1_AtributoProducto");
                    });

            entity.HasMany(d => d.Precios).WithMany(p => p.ProductoPrecio_Precios)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoPrecio",
                    r => r.HasOne<Precio>().WithMany()
                        .HasForeignKey("Precio_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoPrecio_Precio"),
                    l => l.HasOne<Producto>().WithMany()
                        .HasForeignKey("ProductoPrecio_Precio_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoPrecio_Producto"),
                    j =>
                    {
                        j.HasKey("ProductoPrecio_Precio_Id", "Precio_Id").IsClustered(false);
                        j.ToTable("ProductoPrecio");
                        j.HasIndex(new[] { "Precio_Id" }, "IX_FK_ProductoPrecio_Precio");
                    });
        });

        modelBuilder.Entity<ProductoTemplateCantidadCuota>(entity =>
        {
            entity.HasKey(e => new { e.ProductoTemplate_Id, e.CantidadCuotas }).IsClustered(false);

            entity.HasOne(d => d.ProductoTemplate).WithMany(p => p.ProductoTemplateCantidadCuota)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoTemplate_Id");
        });

        modelBuilder.Entity<ProductosTemplate>(entity =>
        {
            entity.Property(e => e.TieneCodigosActivacion).HasDefaultValue(false);

            entity.HasOne(d => d.ClienteCorporativo).WithMany(p => p.ProductosTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoTemplateClienteCorporativo");

            entity.HasOne(d => d.ModalidadDeFacturacion).WithMany(p => p.ProductosTemplates).HasConstraintName("FK_ProductoTemplateModalidadDeFacturacion");

            entity.HasOne(d => d.TipoProductoTemplate).WithMany(p => p.ProductosTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductoTemplateTipoProductoTemplate");

            entity.HasMany(d => d.Bonificaciones).WithMany(p => p.ProductoTemplateBonificacion_Bonificacions)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoTemplateBonificacion",
                    r => r.HasOne<Bonificacione>().WithMany()
                        .HasForeignKey("Bonificaciones_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoTemplateBonificacion_Bonificacion"),
                    l => l.HasOne<ProductosTemplate>().WithMany()
                        .HasForeignKey("ProductoTemplateBonificacion_Bonificacion_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoTemplateBonificacion_ProductoTemplate"),
                    j =>
                    {
                        j.HasKey("ProductoTemplateBonificacion_Bonificacion_Id", "Bonificaciones_Id").IsClustered(false);
                        j.ToTable("ProductoTemplateBonificacion");
                        j.HasIndex(new[] { "Bonificaciones_Id" }, "IX_FK_ProductoTemplateBonificacion_Bonificacion");
                    });

            entity.HasMany(d => d.Vendedores).WithMany(p => p.ProductoTemplateVendedor_Vendedors)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoTemplateVendedor",
                    r => r.HasOne<Vendedore>().WithMany()
                        .HasForeignKey("Vendedores_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoTemplateVendedor_Vendedor"),
                    l => l.HasOne<ProductosTemplate>().WithMany()
                        .HasForeignKey("ProductoTemplateVendedor_Vendedor_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoTemplateVendedor_ProductoTemplate"),
                    j =>
                    {
                        j.HasKey("ProductoTemplateVendedor_Vendedor_Id", "Vendedores_Id").IsClustered(false);
                        j.ToTable("ProductoTemplateVendedor");
                        j.HasIndex(new[] { "Vendedores_Id" }, "IX_FK_ProductoTemplateVendedor_Vendedor");
                    });
        });

        modelBuilder.Entity<ProductosTemplate_SeguroCocheTemplate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ProductosTemplate_SeguroCocheTemplate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguroCocheTemplate_inherits_SeguroTemplate");

            entity.HasMany(d => d.Marcas).WithMany(p => p.SeguroCocheTemplateMarca_Marcas)
                .UsingEntity<Dictionary<string, object>>(
                    "SeguroCocheTemplateMarca",
                    r => r.HasOne<Marca>().WithMany()
                        .HasForeignKey("Marcas_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeguroCocheTemplateMarca_Marca"),
                    l => l.HasOne<ProductosTemplate_SeguroCocheTemplate>().WithMany()
                        .HasForeignKey("SeguroCocheTemplateMarca_Marca_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeguroCocheTemplateMarca_SeguroCocheTemplate"),
                    j =>
                    {
                        j.HasKey("SeguroCocheTemplateMarca_Marca_Id", "Marcas_Id").IsClustered(false);
                        j.ToTable("SeguroCocheTemplateMarca");
                        j.HasIndex(new[] { "Marcas_Id" }, "IX_FK_SeguroCocheTemplateMarca_Marca");
                    });

            entity.HasMany(d => d.Modelos).WithMany(p => p.SeguroCocheTemplateModelo_Modelos)
                .UsingEntity<Dictionary<string, object>>(
                    "SeguroCocheTemplateModelo",
                    r => r.HasOne<Modelo>().WithMany()
                        .HasForeignKey("Modelos_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeguroCocheTemplateModelo_Modelo"),
                    l => l.HasOne<ProductosTemplate_SeguroCocheTemplate>().WithMany()
                        .HasForeignKey("SeguroCocheTemplateModelo_Modelo_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeguroCocheTemplateModelo_SeguroCocheTemplate"),
                    j =>
                    {
                        j.HasKey("SeguroCocheTemplateModelo_Modelo_Id", "Modelos_Id").IsClustered(false);
                        j.ToTable("SeguroCocheTemplateModelo");
                        j.HasIndex(new[] { "Modelos_Id" }, "IX_FK_SeguroCocheTemplateModelo_Modelo");
                    });
        });

        modelBuilder.Entity<ProductosTemplate_SeguroElectrodomesticoTemplate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ProductosTemplate_SeguroElectrodomesticoTemplate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguroElectrodomesticoTemplate_inherits_SeguroTemplate");

            entity.HasMany(d => d.Marcas).WithMany(p => p.SeguroElectrodomesticoTemplateMarca_Marcas)
                .UsingEntity<Dictionary<string, object>>(
                    "SeguroElectrodomesticoTemplateMarca",
                    r => r.HasOne<Marca>().WithMany()
                        .HasForeignKey("Marcas_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeguroElectrodomesticoTemplateMarca_Marca"),
                    l => l.HasOne<ProductosTemplate_SeguroElectrodomesticoTemplate>().WithMany()
                        .HasForeignKey("SeguroElectrodomesticoTemplateMarca_Marca_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeguroElectrodomesticoTemplateMarca_SeguroElectrodomesticoTemplate"),
                    j =>
                    {
                        j.HasKey("SeguroElectrodomesticoTemplateMarca_Marca_Id", "Marcas_Id").IsClustered(false);
                        j.ToTable("SeguroElectrodomesticoTemplateMarca");
                        j.HasIndex(new[] { "Marcas_Id" }, "IX_FK_SeguroElectrodomesticoTemplateMarca_Marca");
                    });

            entity.HasMany(d => d.Modelos).WithMany(p => p.SeguroElectrodomesticoTemplateModelo_Modelos)
                .UsingEntity<Dictionary<string, object>>(
                    "SeguroElectrodomesticoTemplateModelo",
                    r => r.HasOne<Modelo>().WithMany()
                        .HasForeignKey("Modelos_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeguroElectrodomesticoTemplateModelo_Modelo"),
                    l => l.HasOne<ProductosTemplate_SeguroElectrodomesticoTemplate>().WithMany()
                        .HasForeignKey("SeguroElectrodomesticoTemplateModelo_Modelo_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_SeguroElectrodomesticoTemplateModelo_SeguroElectrodomesticoTemplate"),
                    j =>
                    {
                        j.HasKey("SeguroElectrodomesticoTemplateModelo_Modelo_Id", "Modelos_Id").IsClustered(false);
                        j.ToTable("SeguroElectrodomesticoTemplateModelo");
                        j.HasIndex(new[] { "Modelos_Id" }, "IX_FK_SeguroElectrodomesticoTemplateModelo_Modelo");
                    });
        });

        modelBuilder.Entity<ProductosTemplate_SeguroTemplate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ProductosTemplate_SeguroTemplate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguroTemplate_inherits_ProductoTemplate");

            entity.HasMany(d => d.ProductoAtributoProducto_Productos).WithMany(p => p.ProductoAtributoProducto_AtributoProductos)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductoAtributoProducto",
                    r => r.HasOne<AtributoProducto>().WithMany()
                        .HasForeignKey("ProductoAtributoProducto_Producto_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoAtributoProducto_AtributoProducto"),
                    l => l.HasOne<ProductosTemplate_SeguroTemplate>().WithMany()
                        .HasForeignKey("ProductoAtributoProducto_AtributoProducto_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ProductoAtributoProducto_Producto"),
                    j =>
                    {
                        j.HasKey("ProductoAtributoProducto_AtributoProducto_Id", "ProductoAtributoProducto_Producto_Id").IsClustered(false);
                        j.ToTable("ProductoAtributoProducto");
                        j.HasIndex(new[] { "ProductoAtributoProducto_Producto_Id" }, "IX_FK_ProductoAtributoProducto_AtributoProducto");
                    });
        });

        modelBuilder.Entity<Productos_CicloSeguro>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Productos_Seguro>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ClienteTitular).WithMany(p => p.Productos_Seguros).HasConstraintName("FK_SeguroCliente");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Productos_Seguro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Seguro_inherits_Producto");
        });

        modelBuilder.Entity<Productos_SeguroCoche>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Productos_SeguroCoche)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguroCoche_inherits_Seguro");

            entity.HasOne(d => d.Marca).WithMany(p => p.Productos_SeguroCoches).HasConstraintName("FK_SeguroCocheMarca");

            entity.HasOne(d => d.Modelo).WithMany(p => p.Productos_SeguroCoches).HasConstraintName("FK_SeguroCocheModelo");
        });

        modelBuilder.Entity<Productos_SeguroElectrodomestico>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Articulo).WithMany(p => p.Productos_SeguroElectrodomesticos).HasConstraintName("FK_ArticuloSeguroElectrodomesticos");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Productos_SeguroElectrodomestico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguroElectrodomesticos_inherits_Seguro");

            entity.HasOne(d => d.Marca).WithMany(p => p.Productos_SeguroElectrodomesticos).HasConstraintName("FK_SeguroElectrodomesticosMarca");

            entity.HasOne(d => d.Modelo).WithMany(p => p.Productos_SeguroElectrodomesticos).HasConstraintName("FK_SeguroElectrodomesticosModelo");
        });

        modelBuilder.Entity<Productos_SeguroReintegro>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Productos_SeguroReintegro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SeguroReintegro_inherits_Seguro");
        });

        modelBuilder.Entity<Productos_SeguroVuelo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Producto_SeguroVuelo");
        });

        modelBuilder.Entity<ProveedoresSuscripcione>(entity =>
        {
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.FechaModificacion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Regla_FacturacionCobranza_ProductoTemplate>(entity =>
        {
            entity.HasOne(d => d.ProductoTemplate).WithMany(p => p.Regla_FacturacionCobranza_ProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Regla_FacturacionCobranza_ProductoTemplate_ProductosTemplate");

            entity.HasOne(d => d.Regla_FacturacionCobranza).WithMany(p => p.Regla_FacturacionCobranza_ProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Regla_FacturacionCobranza_ProductoTemplate_Regla_FacturacionCobranza");
        });

        modelBuilder.Entity<ReqAudio>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.ProductoTemplate).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReqAudios_ProductosTemplate");

            entity.HasOne(d => d.Sucursal).WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReqAudios_Sucursales");
        });

        modelBuilder.Entity<Sucursal_ProductoTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Sucural_Producto_Template");
        });

        modelBuilder.Entity<Suscripcione>(entity =>
        {
            entity.Property(e => e.Estado).HasDefaultValue("PENDIENTE");
            entity.Property(e => e.FechaSuscripcion).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TablasMonitore>(entity =>
        {
            entity.Property(e => e.Activo).HasDefaultValue(true);
        });

        modelBuilder.Entity<TarjetasDeCredito>(entity =>
        {
            entity.HasOne(d => d.TipoTarjeta).WithMany(p => p.TarjetasDeCreditos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TarjetaDeCreditoTipoTarjeta");

            entity.HasMany(d => d.TarjetaDeCreditoCliente_TarjetaDeCreditos).WithMany(p => p.TarjetaDeCreditos)
                .UsingEntity<Dictionary<string, object>>(
                    "TarjetaDeCreditoCliente",
                    r => r.HasOne<Cliente>().WithMany()
                        .HasForeignKey("TarjetaDeCreditoCliente_TarjetaDeCredito_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TarjetaDeCreditoCliente_Cliente"),
                    l => l.HasOne<TarjetasDeCredito>().WithMany()
                        .HasForeignKey("TarjetaDeCreditos_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TarjetaDeCreditoCliente_TarjetaDeCredito"),
                    j =>
                    {
                        j.HasKey("TarjetaDeCreditos_Id", "TarjetaDeCreditoCliente_TarjetaDeCredito_Id").IsClustered(false);
                        j.ToTable("TarjetaDeCreditoCliente");
                        j.HasIndex(new[] { "TarjetaDeCreditoCliente_TarjetaDeCredito_Id" }, "IX_FK_TarjetaDeCreditoCliente_Cliente");
                    });
        });

        modelBuilder.Entity<Telefono>(entity =>
        {
            entity.HasOne(d => d.ClienteTelefono_Telefono).WithMany(p => p.Telefonos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClienteTelefono");

            entity.HasOne(d => d.TipoDeTelefono).WithMany(p => p.Telefonos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TelefonoTipoDeTelefono");
        });

        modelBuilder.Entity<TiposProductoTemplate>(entity =>
        {
            entity.HasMany(d => d.AtributosProductos).WithMany(p => p.TipoProductoTemplateAtributoProducto_AtributoProductos)
                .UsingEntity<Dictionary<string, object>>(
                    "TipoProductoTemplateAtributoProducto",
                    r => r.HasOne<AtributoProducto>().WithMany()
                        .HasForeignKey("AtributosProducto_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TipoProductoTemplateAtributoProducto_AtributoProducto"),
                    l => l.HasOne<TiposProductoTemplate>().WithMany()
                        .HasForeignKey("TipoProductoTemplateAtributoProducto_AtributoProducto_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TipoProductoTemplateAtributoProducto_TipoProductoTemplate"),
                    j =>
                    {
                        j.HasKey("TipoProductoTemplateAtributoProducto_AtributoProducto_Id", "AtributosProducto_Id").IsClustered(false);
                        j.ToTable("TipoProductoTemplateAtributoProducto");
                        j.HasIndex(new[] { "AtributosProducto_Id" }, "IX_FK_TipoProductoTemplateAtributoProducto_AtributoProducto");
                    });

            entity.HasMany(d => d.Marcas).WithMany(p => p.TipoProductoTemplateMarca_Marcas)
                .UsingEntity<Dictionary<string, object>>(
                    "TipoProductoTemplateMarca",
                    r => r.HasOne<Marca>().WithMany()
                        .HasForeignKey("Marcas_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TipoProductoTemplateMarca_Marca"),
                    l => l.HasOne<TiposProductoTemplate>().WithMany()
                        .HasForeignKey("TipoProductoTemplateMarca_Marca_Id")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TipoProductoTemplateMarca_TipoProductoTemplate"),
                    j =>
                    {
                        j.HasKey("TipoProductoTemplateMarca_Marca_Id", "Marcas_Id").IsClustered(false);
                        j.ToTable("TipoProductoTemplateMarca");
                        j.HasIndex(new[] { "Marcas_Id" }, "IX_FK_TipoProductoTemplateMarca_Marca");
                    });
        });

        modelBuilder.Entity<TiposTarjetasProductoTemplate>(entity =>
        {
            entity.HasKey(e => new { e.TiposTarjetas_Id, e.ProductoTemplate_Id, e.FormaDePago_Id }).IsClustered(false);

            entity.HasOne(d => d.FormaDePago).WithMany(p => p.TiposTarjetasProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoTarjetaProductoTemplate_FormaDePago");

            entity.HasOne(d => d.ProductoTemplate).WithMany(p => p.TiposTarjetasProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoTarjetaProductoTemplate_ProductoTemplate");

            entity.HasOne(d => d.TiposTarjetas).WithMany(p => p.TiposTarjetasProductoTemplates)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoTarjetaProductoTemplate_TipoTarjeta");
        });

        modelBuilder.Entity<Todo_clientes_camposcomp>(entity =>
        {
            entity.ToView("Todo_clientes_camposcomp");
        });

        modelBuilder.Entity<Transaccione>(entity =>
        {
            entity.HasOne(d => d.Cliente).WithMany(p => p.Transacciones)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transacciones_Clientes");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasOne(d => d.ClienteCorporativo).WithMany(p => p.Usuarios).HasConstraintName("FK_Usuarios_ClienteCorporativos");
        });

        modelBuilder.Entity<VentasProvisoria>(entity =>
        {
            entity.Property(e => e.IMEI).IsFixedLength();
        });

        modelBuilder.Entity<Vista_1>(entity =>
        {
            entity.ToView("Vista_1");
        });

        modelBuilder.Entity<Vista_2>(entity =>
        {
            entity.ToView("Vista_2");
        });

        modelBuilder.Entity<bajasANTEL>(entity =>
        {
            entity.ToView("bajasANTEL");
        });

        modelBuilder.Entity<completaCliente>(entity =>
        {
            entity.ToView("completaClientes");
        });

        modelBuilder.Entity<vwEncryptPago>(entity =>
        {
            entity.ToView("vwEncryptPagos");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<vwGrupoGeneracionDeCobro>(entity =>
        {
            entity.ToView("vwGrupoGeneracionDeCobro");
        });

        modelBuilder.Entity<vwReglas_FacturacionCobranza>(entity =>
        {
            entity.ToView("vwReglas_FacturacionCobranza");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<vwReintento>(entity =>
        {
            entity.ToView("vwReintentos");
        });

        modelBuilder.Entity<vwUsuariosPermiso>(entity =>
        {
            entity.ToView("vwUsuariosPermisos");
        });

        modelBuilder.Entity<vw_encrypt_TarjetasDeCredito>(entity =>
        {
            entity.ToView("vw_encrypt_TarjetasDeCredito");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<wsCrmCredisurArchivoCobranza>(entity =>
        {
            entity.ToView("wsCrmCredisurArchivoCobranza");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
