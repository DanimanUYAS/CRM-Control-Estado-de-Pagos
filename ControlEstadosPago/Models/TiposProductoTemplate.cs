using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("TiposProductoTemplate")]
public partial class TiposProductoTemplate
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("TipoProductoTemplate")]
    public virtual ICollection<ProductosTemplate> ProductosTemplates { get; set; } = new List<ProductosTemplate>();

    [ForeignKey("TipoProductoTemplate_Id")]
    [InverseProperty("TipoProductoTemplates")]
    public virtual ICollection<Articulo> ArticuloTipoProductoTemplate_TipoProductoTemplates { get; set; } = new List<Articulo>();

    [ForeignKey("TipoProductoTemplateAtributoProducto_AtributoProducto_Id")]
    [InverseProperty("TipoProductoTemplateAtributoProducto_AtributoProductos")]
    public virtual ICollection<AtributoProducto> AtributosProductos { get; set; } = new List<AtributoProducto>();

    [ForeignKey("TipoProductoTemplateMarca_Marca_Id")]
    [InverseProperty("TipoProductoTemplateMarca_Marcas")]
    public virtual ICollection<Marca> Marcas { get; set; } = new List<Marca>();
}
