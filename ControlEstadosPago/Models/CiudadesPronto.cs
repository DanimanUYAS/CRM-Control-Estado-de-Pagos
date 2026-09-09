using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("CiudadesPronto")]
public partial class CiudadesPronto
{
    public double? IdCiudad { get; set; }

    [StringLength(255)]
    public string? Nombre { get; set; }
}
