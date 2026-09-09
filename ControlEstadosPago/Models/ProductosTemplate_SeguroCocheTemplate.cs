using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("ProductosTemplate_SeguroCocheTemplate")]
public partial class ProductosTemplate_SeguroCocheTemplate
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("ProductosTemplate_SeguroCocheTemplate")]
    public virtual ProductosTemplate_SeguroTemplate IdNavigation { get; set; } = null!;

    [ForeignKey("SeguroCocheTemplateMarca_Marca_Id")]
    [InverseProperty("SeguroCocheTemplateMarca_Marcas")]
    public virtual ICollection<Marca> Marcas { get; set; } = new List<Marca>();

    [ForeignKey("SeguroCocheTemplateModelo_Modelo_Id")]
    [InverseProperty("SeguroCocheTemplateModelo_Modelos")]
    public virtual ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();
}
