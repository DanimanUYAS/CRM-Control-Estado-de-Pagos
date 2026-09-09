using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("TasaIVA")]
public partial class TasaIVA
{
    [Key]
    public int Id { get; set; }

    public int Tasa { get; set; }
}
