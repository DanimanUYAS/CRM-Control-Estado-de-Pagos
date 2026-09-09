using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class Duracione
{
    public int Id { get; set; }

    public int Dias { get; set; }

    public bool? EstaVigente { get; set; }

    public bool? EstaPredeterminado { get; set; }
}
