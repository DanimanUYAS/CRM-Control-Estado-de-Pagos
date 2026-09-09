using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Sucursal_Supervisor")]
public partial class Sucursal_Supervisor
{
    [Key]
    public int Id { get; set; }

    public int? IdSucursal { get; set; }

    public int? IdUsuario { get; set; }
}
