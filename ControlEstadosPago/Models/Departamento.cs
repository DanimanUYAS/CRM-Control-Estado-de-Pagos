using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Departamento
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Nombre { get; set; } = null!;

    public int? Pais_Id { get; set; }

    [InverseProperty("Departamento")]
    public virtual ICollection<ClienteHistorial> ClienteHistorials { get; set; } = new List<ClienteHistorial>();
}
