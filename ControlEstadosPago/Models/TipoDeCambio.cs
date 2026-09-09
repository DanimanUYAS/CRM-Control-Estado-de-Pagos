using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("TipoDeCambio")]
public partial class TipoDeCambio
{
    [Key]
    public long Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Fecha { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? UYU { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? USD { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PYG { get; set; }
}
