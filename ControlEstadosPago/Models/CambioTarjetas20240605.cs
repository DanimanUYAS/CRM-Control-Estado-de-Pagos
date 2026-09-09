using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("CambioTarjetas20240605")]
public partial class CambioTarjetas20240605
{
    public int ClienteID { get; set; }
}
