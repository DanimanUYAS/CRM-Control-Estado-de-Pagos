using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class VentasProvisoria
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string IdAudio { get; set; } = null!;

    public int Call { get; set; }

    public int UsuarioAlta_Id { get; set; }

    public int Estado { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaNacimiento { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [StringLength(50)]
    public string? SegundoApellido { get; set; }

    [StringLength(50)]
    public string? NombreTitular { get; set; }

    [StringLength(50)]
    public string? ApellidoTitular { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(100)]
    public string NumeroDoc { get; set; } = null!;

    public bool EsTitularDoc { get; set; }

    public int TipoDeDocumento { get; set; }

    [StringLength(100)]
    public string? Direccion { get; set; }

    public int Departamento_Id { get; set; }

    public int Localidad_Id { get; set; }

    [StringLength(25)]
    public string? Telefono { get; set; }

    public int TipoTel_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InicioVigencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FinVigencia { get; set; }

    public int Duracion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaCompra { get; set; }

    [StringLength(50)]
    public string Producto { get; set; } = null!;

    public bool EsTitular { get; set; }

    public int FormaDePago_Id { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Precio { get; set; }

    [StringLength(50)]
    public string? IdVenta { get; set; }

    public int? TipoTarjeta_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaVencimiento { get; set; }

    [StringLength(50)]
    public string? NroCuenta { get; set; }

    public int? Moneda_Id { get; set; }

    public int? Banco_Id { get; set; }

    [StringLength(100)]
    public string? Poliza { get; set; }

    public bool EstaProcesada { get; set; }

    [StringLength(50)]
    public string? NroTarjeta { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaDeCarga { get; set; }

    [StringLength(20)]
    public string? Celular { get; set; }

    [StringLength(50)]
    public string? IMEI { get; set; }

    [StringLength(100)]
    public string? Modelo { get; set; }
}
