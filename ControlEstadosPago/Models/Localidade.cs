using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Localidade
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("Localidad")]
    public virtual ICollection<ClienteHistorial> ClienteHistorials { get; set; } = new List<ClienteHistorial>();
}
