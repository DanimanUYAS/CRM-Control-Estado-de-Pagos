using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class TablasMonitore
{
    [Key]
    public int Id { get; set; }

    [StringLength(256)]
    public string NombreTabla { get; set; } = null!;

    public string Comando { get; set; } = null!;

    public bool Activo { get; set; }
}
