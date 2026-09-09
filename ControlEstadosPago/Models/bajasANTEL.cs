using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class bajasANTEL
{
    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [StringLength(150)]
    public string? Poliza { get; set; }

    [StringLength(50)]
    public string TipoEstado { get; set; } = null!;

    [StringLength(50)]
    public string Expr1 { get; set; } = null!;
}
