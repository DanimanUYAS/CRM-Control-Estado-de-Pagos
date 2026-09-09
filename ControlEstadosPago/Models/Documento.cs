using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("ClienteId", Name = "IX_FK_ClienteDocumento")]
[Index("TipoDeDocumento_Id", Name = "IX_FK_DocumentoTipoDeDocumento")]
[Index("Numero", Name = "IX_NumeroDoc", AllDescending = true)]
[Index("EsTitular", Name = "ix_Documentos_01")]
public partial class Documento
{
    [Key]
    public int Id { get; set; }

    public int ClienteId { get; set; }

    [StringLength(100)]
    public string Numero { get; set; } = null!;

    public bool EsTitular { get; set; }

    public int TipoDeDocumento_Id { get; set; }

    public DateOnly? FechaEmision { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("Documentos")]
    public virtual Cliente Cliente { get; set; } = null!;

    [ForeignKey("TipoDeDocumento_Id")]
    [InverseProperty("Documentos")]
    public virtual TipoDeDocumento TipoDeDocumento { get; set; } = null!;

    [ForeignKey("HistorialClienteDocumento_HistorialCliente_Id")]
    [InverseProperty("HistorialClienteDocumento_HistorialClientes")]
    public virtual ICollection<HistorialCliente> HistorialClienteDocumento_Documentos { get; set; } = new List<HistorialCliente>();
}
