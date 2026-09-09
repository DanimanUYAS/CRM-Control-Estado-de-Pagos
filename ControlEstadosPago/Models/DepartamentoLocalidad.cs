using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("DepartamentoLocalidad")]
public partial class DepartamentoLocalidad
{
    public int? Departamento_Id { get; set; }

    public int? Localidad_Id { get; set; }
}
