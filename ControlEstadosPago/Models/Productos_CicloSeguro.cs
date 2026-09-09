using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Productos_CicloSeguro")]
public partial class Productos_CicloSeguro
{
    [Key]
    public int Id { get; set; }

    public int? NroContrato { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PrecioCompra { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroSerie { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Marca { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Modelo { get; set; }

    public int? MonedaId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DireccionBien { get; set; }

    public int? LocalidadBien { get; set; }

    public int? DepartamentoBien { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NombreBeneficiario1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApellidoBeneficiario1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DocumentoBeneficiario1 { get; set; }

    public int? TipoDocumentoBeneficiarioId1 { get; set; }

    public DateOnly? FechaFactura { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoTotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NombreBeneficiario2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApellidoBeneficiario2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DocumentoBeneficiario2 { get; set; }

    public int? TipoDocumentoBeneficiario2 { get; set; }

    public int? PorcentajeBeneficiario2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NombreBeneficiario3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApellidoBeneficiario3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DocumentoBeneficiario3 { get; set; }

    public int? TipoDocumentoBeneficiario3 { get; set; }

    public int? PorcentajeBeneficiario3 { get; set; }

    public int? PorcentajeBeneficiario1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroCuadro { get; set; }

    [StringLength(250)]
    public string? Observaciones { get; set; }

    public bool? FinanciaConCicloCuotas { get; set; }

    public bool? EsCasa { get; set; }
}
