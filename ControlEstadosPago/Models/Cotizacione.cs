using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Cotizacione
{
    [Key]
    public int Id { get; set; }

    public int Moneda_Id { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Valor { get; set; }
}
