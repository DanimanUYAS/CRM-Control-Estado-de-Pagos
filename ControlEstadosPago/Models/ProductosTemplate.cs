using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("ProductosTemplate")]
[Index("ClienteCorporativo_Id", Name = "IX_FK_ProductoTemplateClienteCorporativo")]
[Index("ModalidadDeFacturacion_Id", Name = "IX_FK_ProductoTemplateModalidadDeFacturacion")]
[Index("TipoProductoTemplate_Id", Name = "IX_FK_ProductoTemplateTipoProductoTemplate")]
public partial class ProductosTemplate
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Nombre { get; set; } = null!;

    public bool Eliminado { get; set; }

    public int ClienteCorporativo_Id { get; set; }

    public int? ModalidadDeFacturacion_Id { get; set; }

    public int TipoProductoTemplate_Id { get; set; }

    public bool? TienePlazoMinimo { get; set; }

    public int? CantMesesPlazoMinimo { get; set; }

    public bool? FacturarAlDarLaBaja { get; set; }

    [StringLength(250)]
    public string? RutaLogo { get; set; }

    public bool? BajaAutomaticaFinVigencia { get; set; }

    [StringLength(20)]
    public string? NroContrato { get; set; }

    [StringLength(30)]
    public string? TipificacionCarga { get; set; }

    [StringLength(2)]
    public string? NroSuplemento { get; set; }

    public int? IndFacElect { get; set; }

    public int? TasaIVA { get; set; }

    public bool AsistenciaConMorosidad { get; set; }

    public int? LimiteEdad { get; set; }

    public bool? AltasHabilitadas { get; set; }

    public bool? TieneCodigosActivacion { get; set; }

    public int? ProveedorSuscripcionId { get; set; }

    [InverseProperty("AtributoProductoProductoTemplate_AtributoProducto")]
    public virtual ICollection<AtributoProductoProductoTemplate> AtributoProductoProductoTemplates { get; set; } = new List<AtributoProductoProductoTemplate>();

    [InverseProperty("ProductoTemplate")]
    public virtual ICollection<BancosProductoTemplate> BancosProductoTemplates { get; set; } = new List<BancosProductoTemplate>();

    [ForeignKey("ClienteCorporativo_Id")]
    [InverseProperty("ProductosTemplates")]
    public virtual ClientesCorporativo ClienteCorporativo { get; set; } = null!;

    [InverseProperty("ProductoTemplateFormaDePago_FormaDePago")]
    public virtual ICollection<FormasDePago> FormasDePagos { get; set; } = new List<FormasDePago>();

    [InverseProperty("ProductoTemplate")]
    public virtual ICollection<FormasDePagosProductoTemplate> FormasDePagosProductoTemplates { get; set; } = new List<FormasDePagosProductoTemplate>();

    [InverseProperty("ProductoTemplate")]
    public virtual ICollection<Incidencia> Incidencia { get; set; } = new List<Incidencia>();

    [ForeignKey("ModalidadDeFacturacion_Id")]
    [InverseProperty("ProductosTemplates")]
    public virtual ModalidadesDeFacturacion? ModalidadDeFacturacion { get; set; }

    [InverseProperty("ProductoTemplate")]
    public virtual ICollection<ModalidadDeFacturacionProductoTemplate> ModalidadDeFacturacionProductoTemplates { get; set; } = new List<ModalidadDeFacturacionProductoTemplate>();

    [InverseProperty("ProductoTemplatePrecio_Precio")]
    public virtual ICollection<Precio> Precios { get; set; } = new List<Precio>();

    [InverseProperty("ProductoTemplate")]
    public virtual ICollection<PreciosGE> PreciosGEs { get; set; } = new List<PreciosGE>();

    [InverseProperty("ProductoTemplate")]
    public virtual ICollection<ProductoTemplateCantidadCuota> ProductoTemplateCantidadCuota { get; set; } = new List<ProductoTemplateCantidadCuota>();

    [InverseProperty("ProductoTemplate")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    [InverseProperty("IdNavigation")]
    public virtual ProductosTemplate_SeguroTemplate? ProductosTemplate_SeguroTemplate { get; set; }

    [InverseProperty("ProductoTemplate")]
    public virtual ICollection<Regla_FacturacionCobranza_ProductoTemplate> Regla_FacturacionCobranza_ProductoTemplates { get; set; } = new List<Regla_FacturacionCobranza_ProductoTemplate>();

    [ForeignKey("TipoProductoTemplate_Id")]
    [InverseProperty("ProductosTemplates")]
    public virtual TiposProductoTemplate TipoProductoTemplate { get; set; } = null!;

    [InverseProperty("ProductoTemplate")]
    public virtual ICollection<TiposTarjetasProductoTemplate> TiposTarjetasProductoTemplates { get; set; } = new List<TiposTarjetasProductoTemplate>();

    [ForeignKey("ProductoTemplateBonificacion_Bonificacion_Id")]
    [InverseProperty("ProductoTemplateBonificacion_Bonificacions")]
    public virtual ICollection<Bonificacione> Bonificaciones { get; set; } = new List<Bonificacione>();

    [ForeignKey("ProductoTemplateVendedor_Vendedor_Id")]
    [InverseProperty("ProductoTemplateVendedor_Vendedors")]
    public virtual ICollection<Vendedore> Vendedores { get; set; } = new List<Vendedore>();
}
