using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Archivo
{
    [Key]
    public int Id { get; set; }

    [StringLength(300)]
    public string Path { get; set; } = null!;

    [StringLength(150)]
    public string NombreArchivo { get; set; } = null!;

    [StringLength(10)]
    public string Extension { get; set; } = null!;

    [ForeignKey("Archivos_Id")]
    [InverseProperty("Archivos")]
    public virtual ICollection<Incidencia> Incidencias { get; set; } = new List<Incidencia>();
}
