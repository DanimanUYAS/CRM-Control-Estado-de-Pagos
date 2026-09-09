using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("EstadosAuxiliaresProductosTemplate")]
public partial class EstadosAuxiliaresProductosTemplate
{
    public int? IdProductoTemplate { get; set; }

    public int? IdEstadoAuxiliar { get; set; }

    [ForeignKey("IdEstadoAuxiliar")]
    public virtual EstadosAuxiliare? IdEstadoAuxiliarNavigation { get; set; }

    [ForeignKey("IdProductoTemplate")]
    public virtual ProductosTemplate? IdProductoTemplateNavigation { get; set; }
}
