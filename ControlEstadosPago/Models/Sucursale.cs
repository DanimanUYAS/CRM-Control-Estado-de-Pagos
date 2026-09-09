using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Sucursale
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    public int? ProductoTemplate_Id { get; set; }

    public int? NumeroSucursal { get; set; }

    public int? UltimoNumero { get; set; }

    [StringLength(50)]
    public string? Telefono { get; set; }

    public bool? EsCallCenter { get; set; }
}
