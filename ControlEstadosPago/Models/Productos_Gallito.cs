using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Productos_Gallito")]
public partial class Productos_Gallito
{
    [Key]
    public int Id { get; set; }

    public int? IdAviso { get; set; }

    public DateOnly? FechaPublicacion { get; set; }

    public int? CantidadDomingos { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TipoCoche { get; set; }

    public int? MarcaId { get; set; }

    public int? ModeloId { get; set; }

    public int? AnoCoche { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? TipoDeAviso { get; set; }

    [StringLength(3500)]
    [Unicode(false)]
    public string? TextoAviso { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? EstadoCertificado { get; set; }

    public DateOnly? FechaRevisado { get; set; }

    public int? ProductoId { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? ModeloDesc { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? MarcaDesc { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string? DocumentoIdentidad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NombreCliente { get; set; }

    [StringLength(70)]
    [Unicode(false)]
    public string? DireccionCliente { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TelefonoCliente { get; set; }

    public int? EstadoClienteId { get; set; }

    [Unicode(false)]
    public string? Comentario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCreacion { get; set; }
}
