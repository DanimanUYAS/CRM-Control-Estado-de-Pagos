using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class Vista_1
{
    [Column(TypeName = "datetime")]
    public DateTime InicioVigencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FinVigencia { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [StringLength(250)]
    public string? SegundoApellido { get; set; }

    [StringLength(250)]
    public string? Domicilio { get; set; }

    [StringLength(100)]
    public string Numero { get; set; } = null!;

    [StringLength(250)]
    public string? Expr2 { get; set; }

    [StringLength(25)]
    public string Expr1 { get; set; } = null!;
}
