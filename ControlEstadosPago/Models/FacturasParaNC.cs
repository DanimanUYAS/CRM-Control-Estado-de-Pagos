using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("FacturasParaNC")]
public partial class FacturasParaNC
{
    public int? PagoId { get; set; }

    public int? ClienteId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Fecha { get; set; }
}
