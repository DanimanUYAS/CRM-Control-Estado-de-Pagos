using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("IdLoteInterno", "Fecha", Name = "IX_Pagos_LoteInternoFecha")]
[Index("ProcesoDGI", Name = "IX_ProcesoDGI")]
[Index("ProcesoGeneracion", Name = "IX_ProcesoGeneracion")]
[Index("ProcesoCobro", "ProcesoFacturacion", "ProcesoGeneracion", Name = "NonClusteredIndex-20191101-101656")]
[Index("Cliente_Id", "NumeroTarjeta", "Banco", Name = "PK_Pagos_Cliente_numrtar_banco")]
[Index("YaCobrado", Name = "ix_Pagos_yacobrado")]
public partial class Pago
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal? MontoViejo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Fecha { get; set; }

    public int? Cuota { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroFactura { get; set; }

    public bool? YaCobrado { get; set; }

    public int? Cliente_Id { get; set; }

    public int? FormaDePago_Id { get; set; }

    public int? TarjetaDeCredito_Id { get; set; }

    public bool? YaFacturado { get; set; }

    public int? ProcesoFacturacion { get; set; }

    public bool? YaGeneroCobranza { get; set; }

    [StringLength(50)]
    public string? MesDeCargo { get; set; }

    [StringLength(50)]
    public string? CodigoAutorizacion { get; set; }

    public int? DocumentoFacturacion_Id { get; set; }

    [StringLength(300)]
    public string? Descripcion { get; set; }

    public int? ProcesoGeneracion { get; set; }

    public int? ProcesoCobro { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaGeneracion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaCobro { get; set; }

    public bool? EsFacturaDeBaja { get; set; }

    public int? FacturaAsociada_Id { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Monto { get; set; }

    [StringLength(100)]
    public string? NumeroTarjeta { get; set; }

    [StringLength(20)]
    public string? TipoTarjeta { get; set; }

    [StringLength(15)]
    public string? Documento { get; set; }

    public int? MesCargoNumero { get; set; }

    public int? AñoCargoNumero { get; set; }

    public int? TipoTarjeta_Id { get; set; }

    public int? IdViejo { get; set; }

    public int? UsuarioFacturacion_Id { get; set; }

    public int? UsuarioGeneracion_Id { get; set; }

    public int? UsuarioCobro_Id { get; set; }

    public int? UsuarioModificacion_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaPrimerRechazo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaSegundoRechazo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaTercerRechazo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NumeroCuenta { get; set; }

    public int? Banco { get; set; }

    public int? CuentaId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? NumeroCorrelativo { get; set; }

    [StringLength(10)]
    public string? NumeroDGI { get; set; }

    [StringLength(10)]
    public string? Serie { get; set; }

    public long? ProcesoDGI { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaProcesoDGI { get; set; }

    public bool? YaGeneroSAP { get; set; }

    public int? IdFacturaAsociada { get; set; }

    public int? IdLoteInterno { get; set; }

    [StringLength(200)]
    public string? Liquidacion { get; set; }

    public bool? CobroExitoso { get; set; }

    [StringLength(100)]
    public string? EstadoFacturacion { get; set; }

    [ForeignKey("Cliente_Id")]
    [InverseProperty("Pagos")]
    public virtual Cliente? Cliente { get; set; }

    [ForeignKey("FormaDePago_Id")]
    [InverseProperty("Pagos")]
    public virtual FormasDePago? FormaDePago { get; set; }

    [ForeignKey("TarjetaDeCredito_Id")]
    [InverseProperty("Pagos")]
    public virtual TarjetasDeCredito? TarjetaDeCredito { get; set; }
}
