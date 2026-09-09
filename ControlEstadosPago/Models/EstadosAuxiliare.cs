using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class EstadosAuxiliare
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    public int? EstadoRealId { get; set; }

    [ForeignKey("EstadoRealId")]
    [InverseProperty("EstadosAuxiliares")]
    public virtual Estado? EstadoReal { get; set; }
}
