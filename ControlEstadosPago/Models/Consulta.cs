using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Consulta
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Nombre { get; set; } = null!;

    [StringLength(200)]
    public string? Descripcion { get; set; }

    [InverseProperty("IdConsultaNavigation")]
    public virtual ICollection<ConsultasPerfil> ConsultasPerfils { get; set; } = new List<ConsultasPerfil>();

    [InverseProperty("Consulta")]
    public virtual ICollection<Parametro> Parametros { get; set; } = new List<Parametro>();
}
