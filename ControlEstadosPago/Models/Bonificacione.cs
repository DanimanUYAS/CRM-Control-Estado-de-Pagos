using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("TipoDeBonificacion_Id", Name = "IX_FK_TipoDeBonificacionBonificacion")]
public partial class Bonificacione
{
    [Key]
    public int Id { get; set; }

    public double Porcentaje { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Validez { get; set; }

    public int TipoDeBonificacion_Id { get; set; }

    [ForeignKey("TipoDeBonificacion_Id")]
    [InverseProperty("Bonificaciones")]
    public virtual TiposDeBonificacion TipoDeBonificacion { get; set; } = null!;

    [ForeignKey("Bonificacion_Id")]
    [InverseProperty("Bonificacions")]
    public virtual ICollection<Producto> BonificacionProducto_Bonificacions { get; set; } = new List<Producto>();

    [ForeignKey("Bonificaciones_Id")]
    [InverseProperty("Bonificaciones")]
    public virtual ICollection<ProductosTemplate> ProductoTemplateBonificacion_Bonificacions { get; set; } = new List<ProductosTemplate>();
}
