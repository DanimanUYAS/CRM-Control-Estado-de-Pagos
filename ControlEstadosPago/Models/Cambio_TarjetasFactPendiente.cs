using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class Cambio_TarjetasFactPendiente
{
    [StringLength(50)]
    [Unicode(false)]
    public string? FacturaID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ClienteID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MarcaTarjeta { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroTarjeta { get; set; }
}
