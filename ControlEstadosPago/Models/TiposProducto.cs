using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("TiposProducto")]
public partial class TiposProducto
{
    [Key]
    public int Id { get; set; }

    [StringLength(150)]
    public string Nombre { get; set; } = null!;
}
