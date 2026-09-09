using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class ReqAudio
{
    public long Id { get; set; }

    public int ProductoTemplate_Id { get; set; }

    public int Sucursal_Id { get; set; }

    public bool RequiereAudio { get; set; }

    [ForeignKey("ProductoTemplate_Id")]
    public virtual ProductosTemplate ProductoTemplate { get; set; } = null!;

    [ForeignKey("Sucursal_Id")]
    public virtual Sucursale Sucursal { get; set; } = null!;
}
