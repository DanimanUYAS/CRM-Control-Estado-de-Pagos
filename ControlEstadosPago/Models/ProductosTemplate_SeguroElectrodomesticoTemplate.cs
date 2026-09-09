using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("ProductosTemplate_SeguroElectrodomesticoTemplate")]
public partial class ProductosTemplate_SeguroElectrodomesticoTemplate
{
    [Key]
    public int Id { get; set; }

    [InverseProperty("ArticuloSeguroElectrodomesticoTemplate_Articulo")]
    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();

    [ForeignKey("Id")]
    [InverseProperty("ProductosTemplate_SeguroElectrodomesticoTemplate")]
    public virtual ProductosTemplate_SeguroTemplate IdNavigation { get; set; } = null!;

    [ForeignKey("SeguroElectrodomesticoTemplateMarca_Marca_Id")]
    [InverseProperty("SeguroElectrodomesticoTemplateMarca_Marcas")]
    public virtual ICollection<Marca> Marcas { get; set; } = new List<Marca>();

    [ForeignKey("SeguroElectrodomesticoTemplateModelo_Modelo_Id")]
    [InverseProperty("SeguroElectrodomesticoTemplateModelo_Modelos")]
    public virtual ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();
}
