using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("TiposDeBonificacion")]
public partial class TiposDeBonificacion
{
    [Key]
    public int Id { get; set; }

    [StringLength(250)]
    public string Descripcion { get; set; } = null!;

    [InverseProperty("TipoDeBonificacion")]
    public virtual ICollection<Bonificacione> Bonificaciones { get; set; } = new List<Bonificacione>();
}
