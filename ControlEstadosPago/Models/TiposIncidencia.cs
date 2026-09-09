using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class TiposIncidencia
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Tipo { get; set; } = null!;

    [InverseProperty("TipoIncidencia")]
    public virtual ICollection<Incidencia> Incidencia { get; set; } = new List<Incidencia>();
}
