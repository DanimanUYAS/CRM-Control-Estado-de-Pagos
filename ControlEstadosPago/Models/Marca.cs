using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Marca
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? IdGallito { get; set; }

    [InverseProperty("Marca")]
    public virtual ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();

    [InverseProperty("Marca")]
    public virtual ICollection<Productos_SeguroCoche> Productos_SeguroCoches { get; set; } = new List<Productos_SeguroCoche>();

    [InverseProperty("Marca")]
    public virtual ICollection<Productos_SeguroElectrodomestico> Productos_SeguroElectrodomesticos { get; set; } = new List<Productos_SeguroElectrodomestico>();

    [ForeignKey("Marcas_Id")]
    [InverseProperty("Marcas")]
    public virtual ICollection<Articulo> ArticuloMarca_Marcas { get; set; } = new List<Articulo>();

    [ForeignKey("Marcas_Id")]
    [InverseProperty("Marcas")]
    public virtual ICollection<ProductosTemplate_SeguroCocheTemplate> SeguroCocheTemplateMarca_Marcas { get; set; } = new List<ProductosTemplate_SeguroCocheTemplate>();

    [ForeignKey("Marcas_Id")]
    [InverseProperty("Marcas")]
    public virtual ICollection<ProductosTemplate_SeguroElectrodomesticoTemplate> SeguroElectrodomesticoTemplateMarca_Marcas { get; set; } = new List<ProductosTemplate_SeguroElectrodomesticoTemplate>();

    [ForeignKey("Marcas_Id")]
    [InverseProperty("Marcas")]
    public virtual ICollection<TiposProductoTemplate> TipoProductoTemplateMarca_Marcas { get; set; } = new List<TiposProductoTemplate>();
}
