using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("NumerosContrato")]
public partial class NumerosContrato
{
    [Key]
    public int Id { get; set; }

    public int ProductoTemplateId { get; set; }

    [StringLength(50)]
    public string? NumeroCia { get; set; }

    [StringLength(50)]
    public string? ContratoSAP { get; set; }
}
