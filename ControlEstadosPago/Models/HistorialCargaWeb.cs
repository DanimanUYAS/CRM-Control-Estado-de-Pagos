using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("HistorialCargaWeb")]
public partial class HistorialCargaWeb
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Fecha { get; set; }

    public int IdUsuario { get; set; }

    public bool Resultado { get; set; }

    [Unicode(false)]
    public string? Errores { get; set; }

    public int? IdCliente { get; set; }

    [StringLength(50)]
    public string? Poliza { get; set; }

    [StringLength(50)]
    public string? NumeroCia { get; set; }

    public long? NroLote { get; set; }
}
