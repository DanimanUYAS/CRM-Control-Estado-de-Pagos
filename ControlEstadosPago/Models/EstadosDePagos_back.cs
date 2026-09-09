using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("EstadosDePagos_back")]
[Index("FechaRegistro", "Id", Name = "EstadosDePagos_PK", IsUnique = true)]
[Index("FechaRegistro", "Id", "Cliente_Id", Name = "NonClusteredIndex-20201127-204559")]
[Index("FechaRegistro", Name = "NonClusteredIndex-FechaRegistro")]
public partial class EstadosDePagos_back
{
    public DateOnly? FechaRegistro { get; set; }

    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaUltimoPago { get; set; }

    public int Cliente_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaUltimoCobro { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaPenultimoPago { get; set; }

    public int Reintentos { get; set; }

    public int? Estado_Id { get; set; }

    public int? EstadoDeCobro_Id { get; set; }

    public int? PagosPendientes { get; set; }

    public int? CobrosFallidos { get; set; }

    public int? CobrosConsecutivos { get; set; }
}
