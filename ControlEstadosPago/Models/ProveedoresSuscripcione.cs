using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class ProveedoresSuscripcione
{
    [Key]
    public int Id { get; set; }

    [StringLength(150)]
    public string Proveedor { get; set; } = null!;

    [StringLength(256)]
    public string? Identificador { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaModificacion { get; set; }

    public bool Estado { get; set; }

    [StringLength(512)]
    public string? PublicKey { get; set; }
}
