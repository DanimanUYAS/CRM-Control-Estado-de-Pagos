using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class BI_Clientes_TMK_Seguimiento_Campana
{
    public int ClienteId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaDeCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaBaja { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CategoriaCausal { get; set; }

    [StringLength(200)]
    public string? CausalBaja { get; set; }

    [StringLength(50)]
    public string? ContratoSAP { get; set; }

    [StringLength(200)]
    public string NombreContrato { get; set; } = null!;

    [StringLength(50)]
    public string TipoEstado { get; set; } = null!;

    public int? DocCliente { get; set; }

    public string? UsuarioBaja { get; set; }

    public string? UsuarioAlta { get; set; }

    [StringLength(100)]
    public string NumeroCia { get; set; } = null!;

    public int Id { get; set; }
}
