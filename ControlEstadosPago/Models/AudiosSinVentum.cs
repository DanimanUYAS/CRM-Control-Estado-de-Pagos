using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("IdCall", "Fecha", Name = "IX_AudiosSinVenta_01")]
public partial class AudiosSinVentum
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string NombreAudio { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(50)]
    public string? PesoArchivo { get; set; }

    public int IdCall { get; set; }
}
