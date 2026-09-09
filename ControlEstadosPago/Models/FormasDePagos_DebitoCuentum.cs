using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class FormasDePagos_DebitoCuentum
{
    public int NumeroCuenta { get; set; }

    [StringLength(250)]
    public string Sucursal { get; set; } = null!;

    [Key]
    public int Id { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("FormasDePagos_DebitoCuentum")]
    public virtual FormasDePago IdNavigation { get; set; } = null!;
}
