using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("ProductosTemplate_SeguroTemplate")]
public partial class ProductosTemplate_SeguroTemplate
{
    public double Descuento { get; set; }

    [StringLength(100)]
    public string NumeroCia { get; set; } = null!;

    [StringLength(30)]
    public string CampoIdentificatorio { get; set; } = null!;

    [Key]
    public int Id { get; set; }

    public bool? TieneFinVigencia { get; set; }

    [InverseProperty("HistorialClienteProducto_HistorialCliente")]
    public virtual ICollection<HistorialCliente> HistorialClientes { get; set; } = new List<HistorialCliente>();

    [ForeignKey("Id")]
    [InverseProperty("ProductosTemplate_SeguroTemplate")]
    public virtual ProductosTemplate IdNavigation { get; set; } = null!;

    [InverseProperty("IdNavigation")]
    public virtual ProductosTemplate_SeguroCocheTemplate? ProductosTemplate_SeguroCocheTemplate { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ProductosTemplate_SeguroElectrodomesticoTemplate? ProductosTemplate_SeguroElectrodomesticoTemplate { get; set; }

    [ForeignKey("ProductoAtributoProducto_AtributoProducto_Id")]
    [InverseProperty("ProductoAtributoProducto_AtributoProductos")]
    public virtual ICollection<AtributoProducto> ProductoAtributoProducto_Productos { get; set; } = new List<AtributoProducto>();
}
