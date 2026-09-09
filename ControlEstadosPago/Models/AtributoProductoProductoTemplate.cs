using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[PrimaryKey("AtributosProducto_Id", "AtributoProductoProductoTemplate_AtributoProducto_Id")]
[Table("AtributoProductoProductoTemplate")]
[Index("AtributoProductoProductoTemplate_AtributoProducto_Id", Name = "IX_FK_AtributoProductoProductoTemplate_ProductoTemplate")]
public partial class AtributoProductoProductoTemplate
{
    [Key]
    public int AtributosProducto_Id { get; set; }

    [Key]
    public int AtributoProductoProductoTemplate_AtributoProducto_Id { get; set; }

    public bool? EsRequerido { get; set; }

    [ForeignKey("AtributoProductoProductoTemplate_AtributoProducto_Id")]
    [InverseProperty("AtributoProductoProductoTemplates")]
    public virtual ProductosTemplate AtributoProductoProductoTemplate_AtributoProducto { get; set; } = null!;

    [ForeignKey("AtributosProducto_Id")]
    [InverseProperty("AtributoProductoProductoTemplates")]
    public virtual AtributoProducto AtributosProducto { get; set; } = null!;
}
