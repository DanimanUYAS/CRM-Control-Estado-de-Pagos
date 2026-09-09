using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("MarcaId", Name = "IX_FK_MarcaModelo")]
public partial class Modelo
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int MarcaId { get; set; }

    public int? IdGallito { get; set; }

    [ForeignKey("MarcaId")]
    [InverseProperty("Modelos")]
    public virtual Marca Marca { get; set; } = null!;

    [InverseProperty("Modelo")]
    public virtual ICollection<Productos_SeguroCoche> Productos_SeguroCoches { get; set; } = new List<Productos_SeguroCoche>();

    [InverseProperty("Modelo")]
    public virtual ICollection<Productos_SeguroElectrodomestico> Productos_SeguroElectrodomesticos { get; set; } = new List<Productos_SeguroElectrodomestico>();

    [ForeignKey("Modelos_Id")]
    [InverseProperty("Modelos")]
    public virtual ICollection<ProductosTemplate_SeguroCocheTemplate> SeguroCocheTemplateModelo_Modelos { get; set; } = new List<ProductosTemplate_SeguroCocheTemplate>();

    [ForeignKey("Modelos_Id")]
    [InverseProperty("Modelos")]
    public virtual ICollection<ProductosTemplate_SeguroElectrodomesticoTemplate> SeguroElectrodomesticoTemplateModelo_Modelos { get; set; } = new List<ProductosTemplate_SeguroElectrodomesticoTemplate>();
}
