using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Paise
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    [ForeignKey("Pais_Id")]
    [InverseProperty("Pais")]
    public virtual ICollection<Articulo> Articulos { get; set; } = new List<Articulo>();
}
