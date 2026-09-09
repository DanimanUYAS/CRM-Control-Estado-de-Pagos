using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("ClienteTransaccion")]
public partial class ClienteTransaccion
{
    public int ClienteId { get; set; }

    public int TransaccionId { get; set; }

    [ForeignKey("ClienteId")]
    public virtual Cliente Cliente { get; set; } = null!;
}
