using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class vwGrupoGeneracionDeCobro
{
    public int IdGrupoGeneracionCobranza { get; set; }

    public int IdProductoTemplate { get; set; }

    public int? IdFormaDePago { get; set; }

    public int? IdTipoDeTarjeta_Banco { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;
}
