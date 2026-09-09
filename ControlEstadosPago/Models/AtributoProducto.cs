using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class AtributoProducto
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    public bool EsRequerido { get; set; }

    [InverseProperty("AtributosProducto")]
    public virtual ICollection<AtributoProductoProductoTemplate> AtributoProductoProductoTemplates { get; set; } = new List<AtributoProductoProductoTemplate>();

    [ForeignKey("AtributosProducto_Id")]
    [InverseProperty("AtributosProductos")]
    public virtual ICollection<Producto> ProductoAtributoProducto1_AtributoProductos { get; set; } = new List<Producto>();

    [ForeignKey("ProductoAtributoProducto_Producto_Id")]
    [InverseProperty("ProductoAtributoProducto_Productos")]
    public virtual ICollection<ProductosTemplate_SeguroTemplate> ProductoAtributoProducto_AtributoProductos { get; set; } = new List<ProductosTemplate_SeguroTemplate>();

    [ForeignKey("AtributosProducto_Id")]
    [InverseProperty("AtributosProductos")]
    public virtual ICollection<TiposProductoTemplate> TipoProductoTemplateAtributoProducto_AtributoProductos { get; set; } = new List<TiposProductoTemplate>();
}
