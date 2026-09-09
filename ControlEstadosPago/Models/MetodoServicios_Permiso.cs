using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class MetodoServicios_Permiso
{
    [Column(TypeName = "numeric(18, 0)")]
    public decimal IDMetodoServicios { get; set; }

    public int IDPermisos { get; set; }

    [ForeignKey("IDMetodoServicios")]
    public virtual MetodoServicio IDMetodoServiciosNavigation { get; set; } = null!;

    [ForeignKey("IDPermisos")]
    public virtual Permiso IDPermisosNavigation { get; set; } = null!;
}
