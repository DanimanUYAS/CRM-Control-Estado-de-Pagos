using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Regla_FacturacionCobranza")]
public partial class Regla_FacturacionCobranza
{
    [Key]
    public int Id { get; set; }

    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [Unicode(false)]
    public string Descripcion { get; set; } = null!;

    [InverseProperty("Regla_FacturacionCobranza")]
    public virtual ICollection<Regla_FacturacionCobranza_ProductoTemplate> Regla_FacturacionCobranza_ProductoTemplates { get; set; } = new List<Regla_FacturacionCobranza_ProductoTemplate>();
}
