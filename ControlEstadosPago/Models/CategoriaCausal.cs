using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("CategoriaCausal")]
public partial class CategoriaCausal
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [InverseProperty("Categoria")]
    public virtual ICollection<CausalesDeBaja> CausalesDeBajas { get; set; } = new List<CausalesDeBaja>();
}
