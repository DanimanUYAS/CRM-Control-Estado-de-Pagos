using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Productos_Seguro")]
[Index("ClienteTitular_Id", Name = "IX_FK_SeguroCliente")]
[Index("Poliza", Name = "IX_Productos_Seguro_01")]
public partial class Productos_Seguro
{
    [Column(TypeName = "datetime")]
    public DateTime InicioVigencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FinVigencia { get; set; }

    public bool EsTitular { get; set; }

    public int? IDProgramaViejo { get; set; }

    [StringLength(150)]
    public string? Poliza { get; set; }

    [Key]
    public int Id { get; set; }

    public int? ClienteTitular_Id { get; set; }

    public int? SucursalCliente_Id { get; set; }

    [ForeignKey("ClienteTitular_Id")]
    [InverseProperty("Productos_Seguros")]
    public virtual Cliente? ClienteTitular { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("Productos_Seguro")]
    public virtual Producto IdNavigation { get; set; } = null!;

    [InverseProperty("IdNavigation")]
    public virtual Productos_SeguroCoche? Productos_SeguroCoche { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual Productos_SeguroElectrodomestico? Productos_SeguroElectrodomestico { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual Productos_SeguroReintegro? Productos_SeguroReintegro { get; set; }
}
