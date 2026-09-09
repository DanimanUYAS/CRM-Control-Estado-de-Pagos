using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("FormasDePagos_PagoContado")]
public partial class FormasDePagos_PagoContado
{
    public int Pago { get; set; }

    [Key]
    public int Id { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("FormasDePagos_PagoContado")]
    public virtual FormasDePago IdNavigation { get; set; } = null!;
}
