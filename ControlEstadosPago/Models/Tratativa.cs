using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Tratativa
{
    [Key]
    public int Id { get; set; }

    public int? Tratativa_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaInicio { get; set; }

    public string? Descripcion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaFin { get; set; }

    public bool? RequiereSeguimiento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaIngreso { get; set; }

    public int? Cliente_Id { get; set; }

    public int? EstadoIncidencia_Id { get; set; }

    public int? ProductoTemplate_Id { get; set; }

    public int? ClienteNuevo_Id { get; set; }
}
