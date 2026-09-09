using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Productos_SeguroReintegro")]
public partial class Productos_SeguroReintegro
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoACubrir { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoContratado { get; set; }

    public int? Moneda_Id { get; set; }

    public int? NumeroContrato { get; set; }

    public bool? Financiado { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("Productos_SeguroReintegro")]
    public virtual Productos_Seguro IdNavigation { get; set; } = null!;
}
