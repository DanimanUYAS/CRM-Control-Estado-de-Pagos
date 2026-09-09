using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("Moneda_Id", Name = "IX_FK_MonedaPrecio")]
[Index("ProductoTemplatePrecio_Precio_Id", Name = "IX_FK_ProductoTemplatePrecio")]
public partial class Precio
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Valor { get; set; }

    [StringLength(250)]
    public string? Descripcion { get; set; }

    public int Moneda_Id { get; set; }

    public int ProductoTemplatePrecio_Precio_Id { get; set; }

    public int? ModalidadDeFacturacion_Id { get; set; }

    public bool? EstaVigente { get; set; }

    public bool? EsPredeterminado { get; set; }

    [ForeignKey("Moneda_Id")]
    [InverseProperty("Precios")]
    public virtual Moneda Moneda { get; set; } = null!;

    [ForeignKey("ProductoTemplatePrecio_Precio_Id")]
    [InverseProperty("Precios")]
    public virtual ProductosTemplate ProductoTemplatePrecio_Precio { get; set; } = null!;

    [ForeignKey("Precio_Id")]
    [InverseProperty("Precios")]
    public virtual ICollection<Producto> ProductoPrecio_Precios { get; set; } = new List<Producto>();
}
