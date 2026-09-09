using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Transaccione
{
    [Key]
    public long Id { get; set; }

    public int ClienteId { get; set; }

    [StringLength(50)]
    public string? AntelEnvioId { get; set; }

    [StringLength(50)]
    public string? AntelExtId { get; set; }

    [StringLength(50)]
    public string? NroTransaccion { get; set; }

    [StringLength(50)]
    public string? NroFactura { get; set; }

    public int? Ordinal { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("Transacciones")]
    public virtual Cliente Cliente { get; set; } = null!;
}
