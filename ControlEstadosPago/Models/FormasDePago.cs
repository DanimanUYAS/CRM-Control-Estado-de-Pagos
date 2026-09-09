using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("ProductoTemplateFormaDePago_FormaDePago_Id", Name = "IX_FK_ProductoTemplateFormaDePago")]
public partial class FormasDePago
{
    [Key]
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public int? ProductoTemplateFormaDePago_FormaDePago_Id { get; set; }

    [InverseProperty("FormasDePagos")]
    public virtual ICollection<FormasDePagosProductoTemplate> FormasDePagosProductoTemplates { get; set; } = new List<FormasDePagosProductoTemplate>();

    [InverseProperty("IdNavigation")]
    public virtual FormasDePagos_DebitoCuentum? FormasDePagos_DebitoCuentum { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual FormasDePagos_PagoContado? FormasDePagos_PagoContado { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual FormasDePagos_PagoTarjetum? FormasDePagos_PagoTarjetum { get; set; }

    [InverseProperty("FormaDePago")]
    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    [InverseProperty("FormaDePago")]
    public virtual ICollection<Pagos2> Pagos2s { get; set; } = new List<Pagos2>();

    [ForeignKey("ProductoTemplateFormaDePago_FormaDePago_Id")]
    [InverseProperty("FormasDePagos")]
    public virtual ProductosTemplate? ProductoTemplateFormaDePago_FormaDePago { get; set; }

    [InverseProperty("FormaDePago")]
    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();

    [InverseProperty("FormaDePago")]
    public virtual ICollection<TiposTarjetasProductoTemplate> TiposTarjetasProductoTemplates { get; set; } = new List<TiposTarjetasProductoTemplate>();

    [ForeignKey("HistorialClienteFormaDePago_HistorialCliente_Id")]
    [InverseProperty("HistorialClienteFormaDePago_HistorialClientes")]
    public virtual ICollection<HistorialCliente> HistorialClienteFormaDePago_FormaDePagos { get; set; } = new List<HistorialCliente>();
}
