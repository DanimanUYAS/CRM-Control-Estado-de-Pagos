using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Sucursal_ProductoTemplate")]
public partial class Sucursal_ProductoTemplate
{
    [Key]
    public int Id { get; set; }

    public int Sucursal_Id { get; set; }

    public int ProductoTemplate_Id { get; set; }
}
