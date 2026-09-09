using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class GeneracionDeFactura
{
    public int IdFactura { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaGeneracion { get; set; }
}
