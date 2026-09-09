using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("IndicadoresFacturacion")]
public partial class IndicadoresFacturacion
{
    [Key]
    public int Id { get; set; }

    [StringLength(30)]
    public string Nombre { get; set; } = null!;
}
