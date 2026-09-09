using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class vw_encrypt_TarjetasDeCredito
{
    public int Id { get; set; }

    [StringLength(100)]
    public string? Numero { get; set; }
}
