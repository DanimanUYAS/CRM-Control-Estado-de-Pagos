using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[PrimaryKey("IdUsuario", "IdProducto")]
[Table("Supervisor_ProductoTemplate")]
public partial class Supervisor_ProductoTemplate
{
    [Key]
    public int IdUsuario { get; set; }

    [Key]
    public int IdProducto { get; set; }
}
