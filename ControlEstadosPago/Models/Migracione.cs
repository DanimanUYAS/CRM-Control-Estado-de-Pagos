using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("NombreArchivo", Name = "IX_Migraciones_NombreArchivo", IsUnique = true)]
public partial class Migracione
{
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// Usado para almacenar el nombre único de la migración
    /// </summary>
    [StringLength(100)]
    public string? Nombre { get; set; }

    /// <summary>
    /// Usado para almacenar la descripción de la migración ejecutada.
    /// </summary>
    [StringLength(255)]
    public string Descripcion { get; set; } = null!;

    [StringLength(255)]
    public string NombreArchivo { get; set; } = null!;

    /// <summary>
    /// Fecha y hora en que se ejecutó la migración
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime Fecha { get; set; }

    [StringLength(150)]
    public string Usuario { get; set; } = null!;
}
