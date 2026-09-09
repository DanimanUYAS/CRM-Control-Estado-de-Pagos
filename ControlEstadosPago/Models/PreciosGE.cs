using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("PreciosGE")]
public partial class PreciosGE
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Valor { get; set; }

    public int PeriodoGtia { get; set; }

    public int Moneda_Id { get; set; }

    public int ProductoTemplate_Id { get; set; }

    public int Articulo_Id { get; set; }

    public bool? EstaVigente { get; set; }

    [ForeignKey("Articulo_Id")]
    [InverseProperty("PreciosGEs")]
    public virtual Articulo Articulo { get; set; } = null!;

    [ForeignKey("Moneda_Id")]
    [InverseProperty("PreciosGEs")]
    public virtual Moneda Moneda { get; set; } = null!;

    [ForeignKey("ProductoTemplate_Id")]
    [InverseProperty("PreciosGEs")]
    public virtual ProductosTemplate ProductoTemplate { get; set; } = null!;
}
