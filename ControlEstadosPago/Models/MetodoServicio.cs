using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class MetodoServicio
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal ID { get; set; }

    [StringLength(50)]
    public string Service { get; set; } = null!;

    [StringLength(250)]
    public string Metodo { get; set; } = null!;
}
