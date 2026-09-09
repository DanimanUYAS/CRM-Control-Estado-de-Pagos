using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Audio
{
    [Key]
    public int Id { get; set; }

    public int ClienteId { get; set; }

    [StringLength(50)]
    public string NombreAudio { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(50)]
    public string? PesoArchivo { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("Audios")]
    public virtual Cliente Cliente { get; set; } = null!;
}
