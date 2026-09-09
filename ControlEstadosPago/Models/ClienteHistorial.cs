using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("ClienteHistorial")]
[Index("IdCliente", Name = "ix_ClienteHistorial_01")]
public partial class ClienteHistorial
{
    [Key]
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int Usuario_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaDeModificacion { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FechaNacimiento { get; set; }

    [StringLength(250)]
    public string? Domicilio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaDeCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaUltimaModificacion { get; set; }

    public bool Eliminado { get; set; }

    public bool RequiereSeguimiento { get; set; }

    [StringLength(250)]
    public string? SegundoApellido { get; set; }

    [StringLength(200)]
    public string? Email { get; set; }

    public int Estado_Id { get; set; }

    public int? Vendedor_Id { get; set; }

    public int? Departamento_Id { get; set; }

    public int? Localidad_Id { get; set; }

    public int Producto_Id { get; set; }

    public int? UsuarioDioAlta { get; set; }

    public int? Precio_Id { get; set; }

    public int? UsuarioDioBaja { get; set; }

    [ForeignKey("Departamento_Id")]
    [InverseProperty("ClienteHistorials")]
    public virtual Departamento? Departamento { get; set; }

    [ForeignKey("Estado_Id")]
    [InverseProperty("ClienteHistorials")]
    public virtual Estado Estado { get; set; } = null!;

    [ForeignKey("Localidad_Id")]
    [InverseProperty("ClienteHistorials")]
    public virtual Localidade? Localidad { get; set; }

    [ForeignKey("Producto_Id")]
    [InverseProperty("ClienteHistorials")]
    public virtual Producto Producto { get; set; } = null!;
}
