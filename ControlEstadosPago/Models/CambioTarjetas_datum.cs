using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class CambioTarjetas_datum
{
    public int ClienteID { get; set; }

    [StringLength(100)]
    public string? NumeroTarjeta { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    [StringLength(50)]
    public string? MarcaTarjeta { get; set; }

    public int? TipoTarjeta_id { get; set; }

    [StringLength(50)]
    public string? FacturaID { get; set; }
}
