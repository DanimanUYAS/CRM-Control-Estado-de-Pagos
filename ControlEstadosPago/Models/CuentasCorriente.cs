using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("ClienteId", Name = "IX_FK_ClienteCuentaCorriente")]
[Index("Moneda_Id", Name = "IX_FK_CuentaCorrienteMoneda")]
[Index("Banco_Id", Name = "ix_CuentasCorrientes_01")]
public partial class CuentasCorriente
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Numero { get; set; } = null!;

    public int ClienteId { get; set; }

    public int Moneda_Id { get; set; }

    public int? Banco_Id { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("CuentasCorrientes")]
    public virtual Cliente Cliente { get; set; } = null!;

    [InverseProperty("HistorialClienteCuentaCorriente_HistorialCliente")]
    public virtual ICollection<HistorialCliente> HistorialClientes { get; set; } = new List<HistorialCliente>();

    [ForeignKey("Moneda_Id")]
    [InverseProperty("CuentasCorrientes")]
    public virtual Moneda Moneda { get; set; } = null!;
}
