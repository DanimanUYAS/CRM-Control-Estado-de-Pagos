using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class ClientesDeAlta_FormaPago
{
    public int ClienteId { get; set; }

    public int ProductoTemplate_Id { get; set; }

    public string? FormaDePAgo { get; set; }

    [StringLength(100)]
    public string? NombreFormaPago { get; set; }
}
