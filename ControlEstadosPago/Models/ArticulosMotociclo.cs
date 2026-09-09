using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("ArticulosMotociclo")]
public partial class ArticulosMotociclo
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string? NroSerie { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    public int? GarantiaFabrica { get; set; }

    public int? Porcentaje12Meses { get; set; }

    public int? Porcentaje24Meses { get; set; }

    public int? Porcentaje36Meses { get; set; }

    public int? Porcentaje48Meses { get; set; }

    public int? PorcentajeCambio { get; set; }
}
