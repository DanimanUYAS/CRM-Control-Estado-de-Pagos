using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("TablaTemporal")]
public partial class TablaTemporal
{
    public int? ID { get; set; }

    [Unicode(false)]
    public string? Password { get; set; }
}
