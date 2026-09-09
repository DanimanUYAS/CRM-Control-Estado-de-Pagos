using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("Cliente_Id", Name = "IX_FK_ClienteIncidencia")]
[Index("EstadoIncidencia_Id", Name = "IX_FK_IncidenciaEstadoIncidencia")]
[Index("ProductoTemplate_Id", Name = "IX_FK_IncidenciaProductoTemplate")]
[Index("TipoIncidencia_Id", Name = "IX_FK_IncidenciaTipoIncidencia")]
[Index("Usuario_Id", Name = "IX_FK_UsuariosIncidencia")]
public partial class Incidencia
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaInicio { get; set; }

    public string Descripcion { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaFin { get; set; }

    public bool RequiereSeguimiento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaIngreso { get; set; }

    public int Usuario_Id { get; set; }

    public int Cliente_Id { get; set; }

    public int TipoIncidencia_Id { get; set; }

    public int EstadoIncidencia_Id { get; set; }

    public int ProductoTemplate_Id { get; set; }

    public bool? ErrorEnRetencion { get; set; }

    [ForeignKey("Cliente_Id")]
    [InverseProperty("Incidencia")]
    public virtual Cliente Cliente { get; set; } = null!;

    [ForeignKey("EstadoIncidencia_Id")]
    [InverseProperty("Incidencia")]
    public virtual EstadoIncidencia EstadoIncidencia { get; set; } = null!;

    [ForeignKey("ProductoTemplate_Id")]
    [InverseProperty("Incidencia")]
    public virtual ProductosTemplate ProductoTemplate { get; set; } = null!;

    [ForeignKey("TipoIncidencia_Id")]
    [InverseProperty("Incidencia")]
    public virtual TiposIncidencia TipoIncidencia { get; set; } = null!;

    [ForeignKey("Usuario_Id")]
    [InverseProperty("Incidencia")]
    public virtual Usuario Usuario { get; set; } = null!;

    [ForeignKey("Incidencias_Id")]
    [InverseProperty("Incidencias")]
    public virtual ICollection<Archivo> Archivos { get; set; } = new List<Archivo>();

    [ForeignKey("HistorialClienteIncidencia_HistorialCliente_Id")]
    [InverseProperty("HistorialClienteIncidencia_HistorialClientes")]
    public virtual ICollection<HistorialCliente> HistorialClienteIncidencia_Incidencia { get; set; } = new List<HistorialCliente>();
}
