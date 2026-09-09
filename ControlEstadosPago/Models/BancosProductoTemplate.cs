using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[PrimaryKey("Banco_Id", "ProductoTemplate_Id")]
[Table("BancosProductoTemplate")]
public partial class BancosProductoTemplate
{
    [Key]
    public int Banco_Id { get; set; }

    [Key]
    public int ProductoTemplate_Id { get; set; }

    public int? FormaDePago_Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodigoComercio { get; set; }

    [ForeignKey("Banco_Id")]
    [InverseProperty("BancosProductoTemplates")]
    public virtual Banco Banco { get; set; } = null!;

    [ForeignKey("ProductoTemplate_Id")]
    [InverseProperty("BancosProductoTemplates")]
    public virtual ProductosTemplate ProductoTemplate { get; set; } = null!;
}
