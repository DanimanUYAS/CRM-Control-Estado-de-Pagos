using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class vwReglas_FacturacionCobranza
{
    public int Id { get; set; }

    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Unicode(false)]
    public string Descripcion { get; set; } = null!;
}
