using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("HistorialClienteCuentaCorriente_HistorialCliente_Id", Name = "IX_FK_HistorialClienteCuentaCorriente")]
[Index("HistorialClienteEstado_HistorialCliente_Id", Name = "IX_FK_HistorialClienteEstado")]
[Index("HistorialClienteProducto_HistorialCliente_Id", Name = "IX_FK_HistorialClienteProducto")]
[Index("HistorialClienteUsuario_HistorialCliente_Id", Name = "IX_FK_HistorialClienteUsuario")]
[Index("HistorialClienteVendedor_HistorialCliente_Id", Name = "IX_FK_HistorialClienteVendedor")]
public partial class HistorialCliente
{
    [Key]
    public int Id { get; set; }

    public int IdCliente { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(100)]
    public string Apellido { get; set; } = null!;

    public bool EsTitular { get; set; }

    public string? NombreTitular { get; set; }

    public string? ApellidoTitular { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaNacimiento { get; set; }

    [StringLength(300)]
    public string Domicilio { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaContratacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InicioVigencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FinVigencia { get; set; }

    public int IdProgramaViejo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaDeCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaDeUltimaModificacion { get; set; }

    public bool Eliminado { get; set; }

    public bool RequiereSeguimiento { get; set; }

    [StringLength(200)]
    public string SegundoApellido { get; set; } = null!;

    [StringLength(200)]
    public string UsuarioId { get; set; } = null!;

    public string IncidenciasId { get; set; } = null!;

    public string CochesId { get; set; } = null!;

    public string ProductoId { get; set; } = null!;

    public string TelefonosId { get; set; } = null!;

    public string FormasDePagoId { get; set; } = null!;

    public string EstadoId { get; set; } = null!;

    public string CuentaCorrienteId { get; set; } = null!;

    public string DocumentosId { get; set; } = null!;

    public string VendedorId { get; set; } = null!;

    public int HistorialClienteUsuario_HistorialCliente_Id { get; set; }

    public int HistorialClienteProducto_HistorialCliente_Id { get; set; }

    public int HistorialClienteEstado_HistorialCliente_Id { get; set; }

    public int HistorialClienteCuentaCorriente_HistorialCliente_Id { get; set; }

    public int HistorialClienteVendedor_HistorialCliente_Id { get; set; }

    [ForeignKey("HistorialClienteCuentaCorriente_HistorialCliente_Id")]
    [InverseProperty("HistorialClientes")]
    public virtual CuentasCorriente HistorialClienteCuentaCorriente_HistorialCliente { get; set; } = null!;

    [ForeignKey("HistorialClienteEstado_HistorialCliente_Id")]
    [InverseProperty("HistorialClientes")]
    public virtual Estado HistorialClienteEstado_HistorialCliente { get; set; } = null!;

    [ForeignKey("HistorialClienteProducto_HistorialCliente_Id")]
    [InverseProperty("HistorialClientes")]
    public virtual ProductosTemplate_SeguroTemplate HistorialClienteProducto_HistorialCliente { get; set; } = null!;

    [ForeignKey("HistorialClienteUsuario_HistorialCliente_Id")]
    [InverseProperty("HistorialClientes")]
    public virtual Usuario HistorialClienteUsuario_HistorialCliente { get; set; } = null!;

    [ForeignKey("HistorialClienteVendedor_HistorialCliente_Id")]
    [InverseProperty("HistorialClientes")]
    public virtual Vendedore HistorialClienteVendedor_HistorialCliente { get; set; } = null!;

    [ForeignKey("HistorialClienteDocumento_Documento_Id")]
    [InverseProperty("HistorialClienteDocumento_Documentos")]
    public virtual ICollection<Documento> HistorialClienteDocumento_HistorialClientes { get; set; } = new List<Documento>();

    [ForeignKey("HistorialClienteFormaDePago_FormaDePago_Id")]
    [InverseProperty("HistorialClienteFormaDePago_FormaDePagos")]
    public virtual ICollection<FormasDePago> HistorialClienteFormaDePago_HistorialClientes { get; set; } = new List<FormasDePago>();

    [ForeignKey("HistorialClienteIncidencia_Incidencia_Id")]
    [InverseProperty("HistorialClienteIncidencia_Incidencia")]
    public virtual ICollection<Incidencia> HistorialClienteIncidencia_HistorialClientes { get; set; } = new List<Incidencia>();

    [ForeignKey("HistorialClienteTelefono_Telefono_Id")]
    [InverseProperty("HistorialClienteTelefono_Telefonos")]
    public virtual ICollection<Telefono> HistorialClienteTelefono_HistorialClientes { get; set; } = new List<Telefono>();
}
