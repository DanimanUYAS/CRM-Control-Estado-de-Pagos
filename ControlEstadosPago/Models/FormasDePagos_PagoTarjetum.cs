using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class FormasDePagos_PagoTarjetum
{
    public int Numero { get; set; }

    [Key]
    public int Id { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("FormasDePagos_PagoTarjetum")]
    public virtual FormasDePago IdNavigation { get; set; } = null!;
}
