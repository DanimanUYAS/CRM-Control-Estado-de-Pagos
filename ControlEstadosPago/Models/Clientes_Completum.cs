using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class Clientes_Completum
{
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

    [StringLength(100)]
    public string? Numero { get; set; }

    [StringLength(25)]
    public string? Numtelefono { get; set; }

    public int Expr2 { get; set; }

    [StringLength(200)]
    public string Expr3 { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FechaCompra { get; set; }

    public int Descuento { get; set; }

    public bool Expr4 { get; set; }

    public int? ClienteId { get; set; }

    public int Usuario_Id { get; set; }

    public int Vendedor_Id { get; set; }

    public int? FormaDePago_Id { get; set; }

    public int ModalidadDeFacturacion_Id { get; set; }

    public int ProductoTemplate_Id { get; set; }

    public int ClienteCorporativo_Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InicioVigencia { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinVigencia { get; set; }

    public bool? EsTitular { get; set; }

    public int? IDProgramaViejo { get; set; }

    [StringLength(150)]
    public string? Poliza { get; set; }

    public int? Expr5 { get; set; }

    public int? ClienteTitular_Id { get; set; }

    [StringLength(30)]
    public string? Matricula { get; set; }

    public int? Expr6 { get; set; }

    public int? Modelo_Id { get; set; }

    public int? Marca_Id { get; set; }

    [StringLength(100)]
    public string? NumeroDeSerie { get; set; }

    public int? MesesGarantiaOriginal { get; set; }

    public int? MesesGarantiaExtendida { get; set; }

    public int? NumeroContrato { get; set; }

    public int? ArticuloId { get; set; }

    public int? Expr7 { get; set; }

    public int? MarcaID { get; set; }

    public int? ModeloID { get; set; }

    [StringLength(25)]
    public string? NumTarjeta { get; set; }
}
