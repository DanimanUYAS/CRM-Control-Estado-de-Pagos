using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Sucursal_Vendedor")]
public partial class Sucursal_Vendedor
{
    [Key]
    public int Id { get; set; }

    public int? IdSucursal { get; set; }

    public int? IdVendedor { get; set; }
}
