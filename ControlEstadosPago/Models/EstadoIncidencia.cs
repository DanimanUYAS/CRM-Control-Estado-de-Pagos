using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class EstadoIncidencia
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    [InverseProperty("EstadoIncidencia")]
    public virtual ICollection<Incidencia> Incidencia { get; set; } = new List<Incidencia>();
}
