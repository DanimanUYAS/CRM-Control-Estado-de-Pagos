using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("Cliente_Id", Name = "IX_ClienteId", IsUnique = true, AllDescending = true)]
public partial class EstadosDePago
{
    [Key]
    public int Id { get; set; }

    public int? CuotasFacturadas { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaUltimoPago { get; set; }

    public int? TotalCuotas { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal? MontoPago { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoTotal { get; set; }

    [StringLength(200)]
    public string? Descripcion { get; set; }

    public int Cliente_Id { get; set; }

    public int? MesesGratis { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaPrimerRechazo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaSegundoRechazo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaTercerRechazo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaUltimoCobro { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaPenultimoPago { get; set; }

    public int Reintentos { get; set; }

    public int CobrosFallidos { get; set; }

    public int CobrosConsecutivos { get; set; }

    public int PagosPendientes { get; set; }

    [ForeignKey("Cliente_Id")]
    [InverseProperty("EstadosDePago")]
    public virtual Cliente Cliente { get; set; } = null!;
}
