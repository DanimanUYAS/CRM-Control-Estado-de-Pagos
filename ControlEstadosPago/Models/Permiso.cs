using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Permiso
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string TipoDeAcceso { get; set; } = null!;

    [ForeignKey("Permisos_Id")]
    [InverseProperty("Permisos")]
    public virtual ICollection<PerfilDeUsuario> PerfilDeUsuarioPermiso_Permisos { get; set; } = new List<PerfilDeUsuario>();
}
