using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("AsociacionFactura_NC")]
public partial class AsociacionFactura_NC
{
    [StringLength(20)]
    public string? NC_id { get; set; }

    [StringLength(20)]
    public string? Fac_id { get; set; }
}
