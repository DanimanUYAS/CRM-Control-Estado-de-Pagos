using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("GrupoGeneracionCobraza_ProductoTemplate")]
public partial class GrupoGeneracionCobraza_ProductoTemplate
{
    public int Id { get; set; }

    public int IdGrupoGeneracionCobranza { get; set; }

    public int IdProductoTemplate { get; set; }
}
