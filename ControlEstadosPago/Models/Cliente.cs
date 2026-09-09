using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("Departamento_Id", Name = "IX_FK_ClienteDepartamento")]
[Index("Estado_Id", Name = "IX_FK_ClienteEstado")]
[Index("Localidad_Id", Name = "IX_FK_ClienteLocalidad")]
[Index("Producto_Id", Name = "IX_FK_ProductoCliente")]
[Index("VendedorCliente_Cliente_Id", Name = "IX_FK_VendedorCliente")]
[Index("Producto_Id", "Eliminado", "Estado_Id", "Id", Name = "Ix_cliente_01")]
[Index("Eliminado", "Estado_Id", Name = "Ix_cliente_02")]
public partial class Cliente
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? FechaNacimiento { get; set; }

    [StringLength(250)]
    public string? Domicilio { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaDeCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaUltimaModificacion { get; set; }

    public bool Eliminado { get; set; }

    public bool RequiereSeguimiento { get; set; }

    [StringLength(250)]
    public string? SegundoApellido { get; set; }

    [StringLength(200)]
    public string? Email { get; set; }

    public int Estado_Id { get; set; }

    public int? VendedorCliente_Cliente_Id { get; set; }

    public int? Departamento_Id { get; set; }

    public int? Localidad_Id { get; set; }

    public int Producto_Id { get; set; }

    public int? CausalDeBaja_Id { get; set; }

    public bool? RenuevaAutomaticamente { get; set; }

    [StringLength(50)]
    public string? NombreTitular { get; set; }

    [StringLength(50)]
    public string? ApellidoTitular { get; set; }

    [StringLength(50)]
    public string? SegundoApellidoTitular { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaDeBaja { get; set; }

    public int? Documento { get; set; }

    public int? DocumentoTitular { get; set; }

    public int? EstadoDeCobro_Id { get; set; }

    public int? UsuarioAlta_Id { get; set; }

    public int? UsuarioBaja_Id { get; set; }

    [StringLength(10)]
    public string? Sexo { get; set; }

    public int? Estadoaux_Id { get; set; }

    [StringLength(50)]
    public string? CodigoPostal { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaDeAlta { get; set; }

    public int? UsuarioModificacion_Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Ocupacion { get; set; }

    public DateTime? MonitorUpdated_At { get; set; }

    [StringLength(256)]
    public string? TransaccionTMK { get; set; }

    [InverseProperty("Cliente")]
    public virtual ICollection<Audio> Audios { get; set; } = new List<Audio>();

    [InverseProperty("Cliente")]
    public virtual ICollection<CuentasCorriente> CuentasCorrientes { get; set; } = new List<CuentasCorriente>();

    [InverseProperty("Cliente")]
    public virtual ICollection<Documento> Documentos { get; set; } = new List<Documento>();

    [InverseProperty("Cliente")]
    public virtual EstadosDePago? EstadosDePago { get; set; }

    [InverseProperty("Cliente")]
    public virtual ICollection<Incidencia> Incidencia { get; set; } = new List<Incidencia>();

    [InverseProperty("Cliente")]
    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    [InverseProperty("Cliente")]
    public virtual ICollection<Pagos2> Pagos2s { get; set; } = new List<Pagos2>();

    [InverseProperty("ClienteTitular")]
    public virtual ICollection<Productos_Seguro> Productos_Seguros { get; set; } = new List<Productos_Seguro>();

    [InverseProperty("ClienteTelefono_Telefono")]
    public virtual ICollection<Telefono> Telefonos { get; set; } = new List<Telefono>();

    [InverseProperty("Cliente")]
    public virtual ICollection<Transaccione> Transacciones { get; set; } = new List<Transaccione>();

    [ForeignKey("TarjetaDeCreditoCliente_TarjetaDeCredito_Id")]
    [InverseProperty("TarjetaDeCreditoCliente_TarjetaDeCreditos")]
    public virtual ICollection<TarjetasDeCredito> TarjetaDeCreditos { get; set; } = new List<TarjetasDeCredito>();
}
