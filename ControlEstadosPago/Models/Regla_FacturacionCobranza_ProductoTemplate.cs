using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Regla_FacturacionCobranza_ProductoTemplate")]
public partial class Regla_FacturacionCobranza_ProductoTemplate
{
    [Key]
    public int Id { get; set; }

    public int ProductoTemplate_Id { get; set; }

    public int Regla_FacturacionCobranza_Id { get; set; }

    [ForeignKey("ProductoTemplate_Id")]
    [InverseProperty("Regla_FacturacionCobranza_ProductoTemplates")]
    public virtual ProductosTemplate ProductoTemplate { get; set; } = null!;

    [ForeignKey("Regla_FacturacionCobranza_Id")]
    [InverseProperty("Regla_FacturacionCobranza_ProductoTemplates")]
    public virtual Regla_FacturacionCobranza Regla_FacturacionCobranza { get; set; } = null!;
}
