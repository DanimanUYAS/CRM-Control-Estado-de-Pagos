using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class wsCrmCredisurArchivoCobranza
{
    [StringLength(100)]
    public string NumeroCia { get; set; } = null!;

    [Column("Fecha de Envio")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Fecha_de_Envio { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string Moneda { get; set; } = null!;

    public int ClienteId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Monto { get; set; }

    [StringLength(6)]
    public string? Periodo { get; set; }

    public int FacturaId { get; set; }

    [Column("N° Factura DGI")]
    [StringLength(20)]
    public string? N__Factura_DGI { get; set; }

    public int? Documento { get; set; }
}
