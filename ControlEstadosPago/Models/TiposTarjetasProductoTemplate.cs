using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[PrimaryKey("TiposTarjetas_Id", "ProductoTemplate_Id", "FormaDePago_Id")]
[Table("TiposTarjetasProductoTemplate")]
public partial class TiposTarjetasProductoTemplate
{
    [Key]
    public int TiposTarjetas_Id { get; set; }

    [Key]
    public int ProductoTemplate_Id { get; set; }

    [Key]
    public int FormaDePago_Id { get; set; }

    [StringLength(50)]
    public string? CodigoDeComercio { get; set; }

    public int? Sucursal { get; set; }

    [ForeignKey("FormaDePago_Id")]
    [InverseProperty("TiposTarjetasProductoTemplates")]
    public virtual FormasDePago FormaDePago { get; set; } = null!;

    [ForeignKey("ProductoTemplate_Id")]
    [InverseProperty("TiposTarjetasProductoTemplates")]
    public virtual ProductosTemplate ProductoTemplate { get; set; } = null!;

    [ForeignKey("TiposTarjetas_Id")]
    [InverseProperty("TiposTarjetasProductoTemplates")]
    public virtual TipoTarjeta TiposTarjetas { get; set; } = null!;
}
