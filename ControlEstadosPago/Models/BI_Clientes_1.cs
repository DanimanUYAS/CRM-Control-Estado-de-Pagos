using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class BI_Clientes_1
{
    public int ClienteId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InicioVigencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaBaja { get; set; }

    [StringLength(50)]
    public string? ContratoSAP { get; set; }

    [StringLength(200)]
    public string NombreContrato { get; set; } = null!;

    [StringLength(150)]
    public string? Poliza { get; set; }

    public int? DocCliente { get; set; }

    [StringLength(50)]
    public string TipoEstado { get; set; } = null!;

    [StringLength(100)]
    public string? Tarjeta { get; set; }

    public string? UsuarioAlta { get; set; }

    public string? UsuarioBaja { get; set; }
}
