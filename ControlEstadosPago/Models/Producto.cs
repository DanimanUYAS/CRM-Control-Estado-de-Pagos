using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("ClienteCorporativo_Id", Name = "IX_FK_ProductoClienteCorporativo1")]
[Index("FormaDePago_Id", "ProductoTemplate_Id", Name = "IX_FK_ProductoFormaDePago")]
[Index("ModalidadDeFacturacion_Id", Name = "IX_FK_ProductoModalidadDeFacturacion")]
[Index("ProductoTemplate_Id", Name = "IX_FK_ProductoProductoTemplate")]
[Index("Usuario_Id", Name = "IX_FK_ProductoUsuario")]
[Index("Vendedor_Id", Name = "IX_FK_ProductoVendedor")]
public partial class Producto
{
    [Key]
    public int Id { get; set; }

    [StringLength(200)]
    public string Nombre { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaCompra { get; set; }

    public int Descuento { get; set; }

    public bool Eliminado { get; set; }

    public int? ClienteId { get; set; }

    public int Usuario_Id { get; set; }

    public int Vendedor_Id { get; set; }

    public int? FormaDePago_Id { get; set; }

    public int ModalidadDeFacturacion_Id { get; set; }

    public int ProductoTemplate_Id { get; set; }

    public int ClienteCorporativo_Id { get; set; }

    public int? Precio_Id { get; set; }

    public int? CantidadCuotas { get; set; }

    public int? UsuarioSupervisor_Id { get; set; }

    public int? PuntoDeVenta_Id { get; set; }

    public int? IdVentaExterno { get; set; }

    public int? CuotasTC { get; set; }

    public int? CanalVenta_Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NroCondicionado { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoTotal { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodigoSucursalExterno { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NombreSucursalExterno { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodigoVendedorExterno { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NombreVendedorExterno { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? IMEI { get; set; }

    [StringLength(200)]
    public string? Modelo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? NroTransaccion { get; set; }

    [ForeignKey("ClienteCorporativo_Id")]
    [InverseProperty("Productos")]
    public virtual ClientesCorporativo ClienteCorporativo { get; set; } = null!;

    [InverseProperty("Producto")]
    public virtual ICollection<ClienteHistorial> ClienteHistorials { get; set; } = new List<ClienteHistorial>();

    [ForeignKey("FormaDePago_Id")]
    [InverseProperty("Productos")]
    public virtual FormasDePago? FormaDePago { get; set; }

    [ForeignKey("ModalidadDeFacturacion_Id")]
    [InverseProperty("Productos")]
    public virtual ModalidadesDeFacturacion ModalidadDeFacturacion { get; set; } = null!;

    [ForeignKey("ProductoTemplate_Id")]
    [InverseProperty("Productos")]
    public virtual ProductosTemplate ProductoTemplate { get; set; } = null!;

    [InverseProperty("IdNavigation")]
    public virtual Productos_Seguro? Productos_Seguro { get; set; }

    [ForeignKey("Usuario_Id")]
    [InverseProperty("Productos")]
    public virtual Usuario Usuario { get; set; } = null!;

    [ForeignKey("Vendedor_Id")]
    [InverseProperty("Productos")]
    public virtual Vendedore Vendedor { get; set; } = null!;

    [ForeignKey("ProductoAtributoProducto1_AtributoProducto_Id")]
    [InverseProperty("ProductoAtributoProducto1_AtributoProductos")]
    public virtual ICollection<AtributoProducto> AtributosProductos { get; set; } = new List<AtributoProducto>();

    [ForeignKey("BonificacionProducto_Bonificacion_Id")]
    [InverseProperty("BonificacionProducto_Bonificacions")]
    public virtual ICollection<Bonificacione> Bonificacions { get; set; } = new List<Bonificacione>();

    [ForeignKey("ProductoPrecio_Precio_Id")]
    [InverseProperty("ProductoPrecio_Precios")]
    public virtual ICollection<Precio> Precios { get; set; } = new List<Precio>();
}
