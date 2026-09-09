using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class completaCliente
{
    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(50)]
    public string Apellido { get; set; } = null!;

    [StringLength(250)]
    public string? SegundoApellido { get; set; }

    [StringLength(250)]
    public string? Domicilio { get; set; }

    [StringLength(50)]
    public string TipoEstado { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaDeCreacion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaUltimaModificacion { get; set; }

    public bool RequiereSeguimiento { get; set; }

    public bool Eliminado { get; set; }

    [StringLength(100)]
    public string? Documento { get; set; }

    [StringLength(25)]
    public string? Telefono { get; set; }

    [StringLength(100)]
    public string? MarcaTarjeta { get; set; }

    [StringLength(25)]
    public string? Tarjeta { get; set; }

    [StringLength(200)]
    public string? Departamento { get; set; }

    [StringLength(200)]
    public string? Localidad { get; set; }

    [StringLength(250)]
    public string ClienteCorporativo { get; set; } = null!;

    [StringLength(200)]
    public string Producto { get; set; } = null!;

    [StringLength(100)]
    public string NumeroCompania { get; set; } = null!;

    [StringLength(30)]
    public string CampoIdentificatorio { get; set; } = null!;

    [StringLength(150)]
    public string? Poliza { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InicioVigencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinVigencia { get; set; }

    [StringLength(30)]
    public string? Matricula { get; set; }

    public int? NumeroContratoElectrodomestico { get; set; }

    public int? MesesGarantiaOriginal { get; set; }

    public int? MesesGarantiaExtendida { get; set; }
}
