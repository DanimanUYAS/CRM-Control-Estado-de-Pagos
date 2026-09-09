using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Vendedore
{
    [Key]
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Sucursal_Id { get; set; }

    [StringLength(50)]
    public string? Codigo { get; set; }

    [StringLength(50)]
    public string? Apellido { get; set; }

    public int? ProductoTemplate_Id { get; set; }

    public bool? EsCallCenter { get; set; }

    [InverseProperty("HistorialClienteVendedor_HistorialCliente")]
    public virtual ICollection<HistorialCliente> HistorialClientes { get; set; } = new List<HistorialCliente>();

    [InverseProperty("Vendedor")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    [ForeignKey("Vendedores_Id")]
    [InverseProperty("Vendedores")]
    public virtual ICollection<ProductosTemplate> ProductoTemplateVendedor_Vendedors { get; set; } = new List<ProductosTemplate>();
}
