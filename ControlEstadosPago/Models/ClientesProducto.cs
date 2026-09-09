using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class ClientesProducto
{
    public int Id { get; set; }

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

    public int? VendedorCliente_Cliente_Id { get; set; }

    public int? Departamento_Id { get; set; }

    public int? Localidad_Id { get; set; }

    public int Producto_Id { get; set; }

    [StringLength(200)]
    public string Expr1 { get; set; } = null!;

    public int ClienteCorporativo_Id { get; set; }
}
