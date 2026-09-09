using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class vwUsuariosPermiso
{
    public int Id { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    public bool Eliminado { get; set; }

    public int PerfilDeUsuarioPermiso_Permiso_Id { get; set; }

    public int Permisos_Id { get; set; }

    public int Perfiles_Id { get; set; }

    public int Usuarios_Id { get; set; }

    public int Expr1 { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Expr2 { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool Expr3 { get; set; }

    public int? ProductoTemplate_Id { get; set; }

    public int? Sucursal_Id { get; set; }

    public int? Pais_Id { get; set; }

    public bool? IsAdmin { get; set; }

    public bool? IsABMUser { get; set; }

    public bool? IsABMUserExterno { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodigoSeguridad { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodigoReporte { get; set; }

    public int? ClienteCorporativo_Id { get; set; }
}
