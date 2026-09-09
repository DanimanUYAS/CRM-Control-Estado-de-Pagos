using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class TipoTarjeta
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [InverseProperty("TipoTarjeta")]
    public virtual ICollection<TarjetasDeCredito> TarjetasDeCreditos { get; set; } = new List<TarjetasDeCredito>();

    [InverseProperty("TiposTarjetas")]
    public virtual ICollection<TiposTarjetasProductoTemplate> TiposTarjetasProductoTemplates { get; set; } = new List<TiposTarjetasProductoTemplate>();
}
