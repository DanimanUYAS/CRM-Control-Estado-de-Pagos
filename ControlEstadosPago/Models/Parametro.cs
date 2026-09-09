using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("ConsultaId", Name = "IX_FK_ConsultaParametro")]
public partial class Parametro
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Valor { get; set; } = null!;

    public int ConsultaId { get; set; }

    [ForeignKey("ConsultaId")]
    [InverseProperty("Parametros")]
    public virtual Consulta Consulta { get; set; } = null!;
}
