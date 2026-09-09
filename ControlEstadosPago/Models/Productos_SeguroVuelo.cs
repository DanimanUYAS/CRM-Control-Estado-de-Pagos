using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Productos_SeguroVuelo")]
public partial class Productos_SeguroVuelo
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    public DateOnly? Fecha { get; set; }

    public int? CantidadBultos { get; set; }

    public int? ProductoId { get; set; }
}
