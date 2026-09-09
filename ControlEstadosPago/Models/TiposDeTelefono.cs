using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("TiposDeTelefono")]
public partial class TiposDeTelefono
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(250)]
    public string? Descripcion { get; set; }

    [InverseProperty("TipoDeTelefono")]
    public virtual ICollection<Telefono> Telefonos { get; set; } = new List<Telefono>();
}
