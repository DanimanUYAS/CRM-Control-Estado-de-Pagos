using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class PerfilDeUsuario
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    public bool Eliminado { get; set; }

    [InverseProperty("IdPerfilNavigation")]
    public virtual ICollection<ConsultasPerfil> ConsultasPerfils { get; set; } = new List<ConsultasPerfil>();

    [ForeignKey("PerfilDeUsuarioPermiso_Permiso_Id")]
    [InverseProperty("PerfilDeUsuarioPermiso_Permisos")]
    public virtual ICollection<Permiso> Permisos { get; set; } = new List<Permiso>();

    [ForeignKey("Perfiles_Id")]
    [InverseProperty("Perfiles")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
