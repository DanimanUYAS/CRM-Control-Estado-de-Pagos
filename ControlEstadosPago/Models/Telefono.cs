using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Index("ClienteTelefono_Telefono_Id", Name = "IX_FK_ClienteTelefono")]
[Index("TipoDeTelefono_Id", Name = "IX_FK_TelefonoTipoDeTelefono")]
[Index("Numero", Name = "IX_NumeroTel")]
public partial class Telefono
{
    [Key]
    public int Id { get; set; }

    [StringLength(25)]
    public string Numero { get; set; } = null!;

    public int ClienteTelefono_Telefono_Id { get; set; }

    public int TipoDeTelefono_Id { get; set; }

    [ForeignKey("ClienteTelefono_Telefono_Id")]
    [InverseProperty("Telefonos")]
    public virtual Cliente ClienteTelefono_Telefono { get; set; } = null!;

    [ForeignKey("TipoDeTelefono_Id")]
    [InverseProperty("Telefonos")]
    public virtual TiposDeTelefono TipoDeTelefono { get; set; } = null!;

    [ForeignKey("HistorialClienteTelefono_HistorialCliente_Id")]
    [InverseProperty("HistorialClienteTelefono_HistorialClientes")]
    public virtual ICollection<HistorialCliente> HistorialClienteTelefono_Telefonos { get; set; } = new List<HistorialCliente>();
}
