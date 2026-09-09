using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("ArticuloId", Name = "IX_FK_ArticuloSeguroElectrodomesticos")]
[Index("Marca_Id", Name = "IX_FK_SeguroElectrodomesticosMarca")]
[Index("Modelo_Id", Name = "IX_FK_SeguroElectrodomesticosModelo")]
public partial class Productos_SeguroElectrodomestico
{
    [StringLength(100)]
    public string? NumeroDeSerie { get; set; }

    public int MesesGarantiaOriginal { get; set; }

    public int MesesGarantiaExtendida { get; set; }

    public int? ArticuloId { get; set; }

    [Key]
    public int Id { get; set; }

    public int? Marca_Id { get; set; }

    public int? Modelo_Id { get; set; }

    [StringLength(250)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PrecioArticulo { get; set; }

    public int? Moneda_Id { get; set; }

    public int? PrecioGE_Id { get; set; }

    [StringLength(100)]
    public string? NumeroContrato { get; set; }

    [StringLength(100)]
    public string? NumeroFactura { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PrecioGtiaManual { get; set; }

    public int? MonedaGtiaManual_Id { get; set; }

    [StringLength(100)]
    public string? NumeroTicket { get; set; }

    public bool? FinanciaCicloCuotas { get; set; }

    public int? ArticuloMotocicloId { get; set; }

    public bool? GtaCambio { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NombreArticuloExterno { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CodigoArticuloExterno { get; set; }

    [ForeignKey("ArticuloId")]
    [InverseProperty("Productos_SeguroElectrodomesticos")]
    public virtual Articulo? Articulo { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("Productos_SeguroElectrodomestico")]
    public virtual Productos_Seguro IdNavigation { get; set; } = null!;

    [ForeignKey("Marca_Id")]
    [InverseProperty("Productos_SeguroElectrodomesticos")]
    public virtual Marca? Marca { get; set; }

    [ForeignKey("Modelo_Id")]
    [InverseProperty("Productos_SeguroElectrodomesticos")]
    public virtual Modelo? Modelo { get; set; }
}
