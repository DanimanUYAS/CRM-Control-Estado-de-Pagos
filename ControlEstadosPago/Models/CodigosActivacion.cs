using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("CodigosActivacion")]
[Index("Id", Name = "IX_CodigosActivacion", IsUnique = true)]
public partial class CodigosActivacion
{
    [Key]
    public int Id { get; set; }

    public int? ProductoTemplateId { get; set; }

    [StringLength(256)]
    public string? Codigo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaModificacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaAsignacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaBaja { get; set; }

    [StringLength(20)]
    public string? Estado { get; set; }

    public int? IdCliente { get; set; }
}
