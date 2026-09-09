using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("CLIENTES_RW")]
public partial class CLIENTES_RW
{
    public int? ID { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }
}
