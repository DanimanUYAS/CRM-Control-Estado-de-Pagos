using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("Parametros_CRM")]
public partial class Parametros_CRM
{
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Valor { get; set; }
}
