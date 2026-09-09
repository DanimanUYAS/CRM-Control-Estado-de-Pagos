using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("GrupoGeneracionCobranza")]
public partial class GrupoGeneracionCobranza
{
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    public int? IdFormaDePago { get; set; }

    public int? IdTipoDeTarjeta_Banco { get; set; }
}
