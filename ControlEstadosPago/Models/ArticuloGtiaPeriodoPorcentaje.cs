using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("ArticuloGtiaPeriodoPorcentaje")]
public partial class ArticuloGtiaPeriodoPorcentaje
{
    [Key]
    public int Id { get; set; }

    public int? Articulo_Id { get; set; }

    public int? TipoGtia_Id { get; set; }

    public int? Periodo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Porcentaje { get; set; }
}
