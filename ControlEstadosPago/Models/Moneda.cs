using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Moneda
{
    [Key]
    public int Id { get; set; }

    [StringLength(4)]
    public string? Tipo { get; set; }

    public int? Pais_Id { get; set; }

    [StringLength(4)]
    public string? Codigo { get; set; }

    [InverseProperty("Moneda")]
    public virtual ICollection<CuentasCorriente> CuentasCorrientes { get; set; } = new List<CuentasCorriente>();

    [InverseProperty("Moneda")]
    public virtual ICollection<Precio> Precios { get; set; } = new List<Precio>();

    [InverseProperty("Moneda")]
    public virtual ICollection<PreciosGE> PreciosGEs { get; set; } = new List<PreciosGE>();
}
