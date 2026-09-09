using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("ModalidadesDeFacturacion")]
public partial class ModalidadesDeFacturacion
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("ModalidadDeFacturacion")]
    public virtual ICollection<ModalidadDeFacturacionProductoTemplate> ModalidadDeFacturacionProductoTemplates { get; set; } = new List<ModalidadDeFacturacionProductoTemplate>();

    [InverseProperty("ModalidadDeFacturacion")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    [InverseProperty("ModalidadDeFacturacion")]
    public virtual ICollection<ProductosTemplate> ProductosTemplates { get; set; } = new List<ProductosTemplate>();
}
