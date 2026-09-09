using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[PrimaryKey("ProductoTemplate_Id", "CantidadCuotas")]
public partial class ProductoTemplateCantidadCuota
{
    [Key]
    public int ProductoTemplate_Id { get; set; }

    [Key]
    public int CantidadCuotas { get; set; }

    [ForeignKey("ProductoTemplate_Id")]
    [InverseProperty("ProductoTemplateCantidadCuota")]
    public virtual ProductosTemplate ProductoTemplate { get; set; } = null!;
}
