using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("tceliminar")]
public partial class tceliminar
{
    [Column(TypeName = "decimal(28, 0)")]
    public decimal? Id { get; set; }
}
