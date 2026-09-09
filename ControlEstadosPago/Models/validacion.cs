using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("validacion")]
public partial class validacion
{
    public int? idcliente { get; set; }
}
