using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("CierrePeriodo")]
public partial class CierrePeriodo
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Fecha { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Descripcion { get; set; }
}
