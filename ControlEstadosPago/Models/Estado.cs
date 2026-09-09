using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class Estado
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string TipoEstado { get; set; } = null!;

    [InverseProperty("Estado")]
    public virtual ICollection<ClienteHistorial> ClienteHistorials { get; set; } = new List<ClienteHistorial>();

    [InverseProperty("EstadoReal")]
    public virtual ICollection<EstadosAuxiliare> EstadosAuxiliares { get; set; } = new List<EstadosAuxiliare>();

    [InverseProperty("HistorialClienteEstado_HistorialCliente")]
    public virtual ICollection<HistorialCliente> HistorialClientes { get; set; } = new List<HistorialCliente>();
}
