using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("PreciosCelular")]
public partial class PreciosCelular
{
    [Key]
    public int Id { get; set; }

    public int? Desde { get; set; }

    public int? Hasta { get; set; }

    public int? Porcentaje { get; set; }
}
