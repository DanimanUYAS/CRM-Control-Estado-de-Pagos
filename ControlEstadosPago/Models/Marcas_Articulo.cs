using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Marcas_Articulo
{
    [Key]
    public int Id { get; set; }

    public int? ArticuloId { get; set; }

    public int? MarcaArticuloId { get; set; }
}
