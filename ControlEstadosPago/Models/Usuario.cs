using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Usuario
{
    [Key]
    public int Id { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public bool Eliminado { get; set; }

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

    [ForeignKey("ClienteCorporativo_Id")]
    [InverseProperty("Usuarios")]
    public virtual ClientesCorporativo? ClienteCorporativo { get; set; }

    [InverseProperty("HistorialClienteUsuario_HistorialCliente")]
    public virtual ICollection<HistorialCliente> HistorialClientes { get; set; } = new List<HistorialCliente>();

    [InverseProperty("Usuario")]
    public virtual ICollection<Incidencia> Incidencia { get; set; } = new List<Incidencia>();

    [InverseProperty("Usuario")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    [ForeignKey("Usuarios_Id")]
    [InverseProperty("Usuarios")]
    public virtual ICollection<PerfilDeUsuario> Perfiles { get; set; } = new List<PerfilDeUsuario>();
}
