using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("ArticuloSeguroElectrodomesticoTemplate_Articulo_Id", Name = "IX_FK_ArticuloSeguroElectrodomesticoTemplate")]
public partial class Articulo
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Nombre { get; set; } = null!;

    public int? ArticuloSeguroElectrodomesticoTemplate_Articulo_Id { get; set; }

    public int? FamiliaArticulos_Id { get; set; }

    [ForeignKey("ArticuloSeguroElectrodomesticoTemplate_Articulo_Id")]
    [InverseProperty("Articulos")]
    public virtual ProductosTemplate_SeguroElectrodomesticoTemplate? ArticuloSeguroElectrodomesticoTemplate_Articulo { get; set; }

    [InverseProperty("Articulo")]
    public virtual ICollection<PreciosGE> PreciosGEs { get; set; } = new List<PreciosGE>();

    [InverseProperty("Articulo")]
    public virtual ICollection<Productos_SeguroElectrodomestico> Productos_SeguroElectrodomesticos { get; set; } = new List<Productos_SeguroElectrodomestico>();

    [ForeignKey("ArticuloMarca_Marca_Id")]
    [InverseProperty("ArticuloMarca_Marcas")]
    public virtual ICollection<Marca> Marcas { get; set; } = new List<Marca>();

    [ForeignKey("Articulo_Id")]
    [InverseProperty("Articulos")]
    public virtual ICollection<Paise> Pais { get; set; } = new List<Paise>();

    [ForeignKey("ArticuloTipoProductoTemplate_TipoProductoTemplate_Id")]
    [InverseProperty("ArticuloTipoProductoTemplate_TipoProductoTemplates")]
    public virtual ICollection<TiposProductoTemplate> TipoProductoTemplates { get; set; } = new List<TiposProductoTemplate>();
}
