using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Suscripcione
{
    [Key]
    public int Id { get; set; }

    [StringLength(256)]
    public string Aplicacion { get; set; } = null!;

    [StringLength(256)]
    public string Proveedor { get; set; } = null!;

    [StringLength(512)]
    public string Proveedor_Id { get; set; } = null!;

    public int Cliente_Id { get; set; }

    [StringLength(256)]
    public string NombreUsuario { get; set; } = null!;

    [StringLength(256)]
    public string? Suscripcion_Id { get; set; }

    [StringLength(256)]
    public string? Order_Id { get; set; }

    [StringLength(256)]
    public string? User_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaSuscripcion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCancelacion { get; set; }

    [StringLength(256)]
    public string? Codigo { get; set; }

    [StringLength(50)]
    public string Estado { get; set; } = null!;
}
