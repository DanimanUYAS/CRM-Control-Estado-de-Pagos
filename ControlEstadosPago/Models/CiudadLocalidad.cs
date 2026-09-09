using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("CiudadLocalidad")]
public partial class CiudadLocalidad
{
    public int? IdCiudad { get; set; }

    public int? IdLocalidad { get; set; }
}
