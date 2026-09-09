using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("Productos_SeguroCoche")]
[Index("Marca_Id", Name = "IX_FK_SeguroCocheMarca")]
[Index("Modelo_Id", Name = "IX_FK_SeguroCocheModelo")]
public partial class Productos_SeguroCoche
{
    [StringLength(30)]
    public string Matricula { get; set; } = null!;

    [Key]
    public int Id { get; set; }

    public int? Modelo_Id { get; set; }

    public int? Marca_Id { get; set; }

    public int? Año { get; set; }

    public int? Color_Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NombreChofer1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApellidoChofer1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NombreChofer2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ApellidoChofer2 { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("Productos_SeguroCoche")]
    public virtual Productos_Seguro IdNavigation { get; set; } = null!;

    [ForeignKey("Marca_Id")]
    [InverseProperty("Productos_SeguroCoches")]
    public virtual Marca? Marca { get; set; }

    [ForeignKey("Modelo_Id")]
    [InverseProperty("Productos_SeguroCoches")]
    public virtual Modelo? Modelo { get; set; }
}
