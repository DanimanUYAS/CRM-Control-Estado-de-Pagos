using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("ConsultasPerfil")]
public partial class ConsultasPerfil
{
    [Key]
    public int Id { get; set; }

    public int IdConsulta { get; set; }

    public int IdPerfil { get; set; }

    [ForeignKey("IdConsulta")]
    [InverseProperty("ConsultasPerfils")]
    public virtual Consulta IdConsultaNavigation { get; set; } = null!;

    [ForeignKey("IdPerfil")]
    [InverseProperty("ConsultasPerfils")]
    public virtual PerfilDeUsuario IdPerfilNavigation { get; set; } = null!;
}
