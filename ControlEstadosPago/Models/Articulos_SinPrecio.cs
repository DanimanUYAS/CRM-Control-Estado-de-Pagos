using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
public partial class Articulos_SinPrecio
{
    public int Id { get; set; }

    [StringLength(200)]
    public string Nombre { get; set; } = null!;

    public int? ArticuloSeguroElectrodomesticoTemplate_Articulo_Id { get; set; }

    public int? FamiliaArticulos_Id { get; set; }

    public int Articulo_Id { get; set; }

    public int Pais_Id { get; set; }

    public int? Expr1 { get; set; }

    [StringLength(50)]
    public string? Expr2 { get; set; }

    public int? Expr3 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Valor { get; set; }

    public int? PeriodoGtia { get; set; }

    public int? Moneda_Id { get; set; }

    public int? ProductoTemplate_Id { get; set; }

    public int? Expr4 { get; set; }

    public bool? EstaVigente { get; set; }

    public int? Expr5 { get; set; }

    public int? Expr6 { get; set; }

    public int? TipoGtia_Id { get; set; }

    public int? Periodo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Porcentaje { get; set; }
}
