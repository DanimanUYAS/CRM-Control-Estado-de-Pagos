using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("TarjetasDeCredito")]
[Index("TipoTarjeta_Id", Name = "IX_FK_TarjetaDeCreditoTipoTarjeta")]
public partial class TarjetasDeCredito
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string? Numero { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FechaVencimiento { get; set; }

    public int TipoTarjeta_Id { get; set; }

    public int? MarcaTarjeta_Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CodigoAutorizacion { get; set; }

    [InverseProperty("TarjetaDeCredito")]
    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    [ForeignKey("TipoTarjeta_Id")]
    [InverseProperty("TarjetasDeCreditos")]
    public virtual TipoTarjeta TipoTarjeta { get; set; } = null!;

    [ForeignKey("TarjetaDeCreditos_Id")]
    [InverseProperty("TarjetaDeCreditos")]
    public virtual ICollection<Cliente> TarjetaDeCreditoCliente_TarjetaDeCreditos { get; set; } = new List<Cliente>();
}
