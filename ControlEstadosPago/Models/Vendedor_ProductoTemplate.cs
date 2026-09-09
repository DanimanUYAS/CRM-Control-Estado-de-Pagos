using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[PrimaryKey("IdVendedor", "IdProducto")]
[Table("Vendedor_ProductoTemplate")]
public partial class Vendedor_ProductoTemplate
{
    [Key]
    public int IdVendedor { get; set; }

    [Key]
    public int IdProducto { get; set; }
}
