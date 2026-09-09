using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class ClientesCorporativo
{
    [Key]
    public int Id { get; set; }

    [StringLength(250)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("ClienteCorporativo")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    [InverseProperty("ClienteCorporativo")]
    public virtual ICollection<ProductosTemplate> ProductosTemplates { get; set; } = new List<ProductosTemplate>();

    [InverseProperty("ClienteCorporativo")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
