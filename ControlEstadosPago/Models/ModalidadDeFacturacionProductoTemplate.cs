using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[PrimaryKey("ModalidadDeFacturacion_Id", "ProductoTemplate_Id")]
[Table("ModalidadDeFacturacionProductoTemplate")]
public partial class ModalidadDeFacturacionProductoTemplate
{
    [Key]
    public int ModalidadDeFacturacion_Id { get; set; }

    [Key]
    public int ProductoTemplate_Id { get; set; }

    public bool? EsPredeterminado { get; set; }

    [ForeignKey("ModalidadDeFacturacion_Id")]
    [InverseProperty("ModalidadDeFacturacionProductoTemplates")]
    public virtual ModalidadesDeFacturacion ModalidadDeFacturacion { get; set; } = null!;

    [ForeignKey("ProductoTemplate_Id")]
    [InverseProperty("ModalidadDeFacturacionProductoTemplates")]
    public virtual ProductosTemplate ProductoTemplate { get; set; } = null!;
}
