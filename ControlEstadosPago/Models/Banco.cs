using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Banco
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Nombre { get; set; }

    [InverseProperty("Banco")]
    public virtual ICollection<BancosProductoTemplate> BancosProductoTemplates { get; set; } = new List<BancosProductoTemplate>();
}
