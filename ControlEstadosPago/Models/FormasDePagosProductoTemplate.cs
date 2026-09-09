using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[PrimaryKey("FormasDePagos_Id", "ProductoTemplate_Id")]
[Table("FormasDePagosProductoTemplate")]
public partial class FormasDePagosProductoTemplate
{
    [Key]
    public int FormasDePagos_Id { get; set; }

    [Key]
    public int ProductoTemplate_Id { get; set; }

    public bool? EsPredeterminado { get; set; }

    [ForeignKey("FormasDePagos_Id")]
    [InverseProperty("FormasDePagosProductoTemplates")]
    public virtual FormasDePago FormasDePagos { get; set; } = null!;

    [ForeignKey("ProductoTemplate_Id")]
    [InverseProperty("FormasDePagosProductoTemplates")]
    public virtual ProductosTemplate ProductoTemplate { get; set; } = null!;
}
