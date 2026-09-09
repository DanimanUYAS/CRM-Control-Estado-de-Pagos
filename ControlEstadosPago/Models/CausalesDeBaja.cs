using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("CausalesDeBaja")]
public partial class CausalesDeBaja
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Nombre { get; set; } = null!;

    public int? CategoriaId { get; set; }

    [ForeignKey("CategoriaId")]
    [InverseProperty("CausalesDeBajas")]
    public virtual CategoriaCausal? Categoria { get; set; }
}
