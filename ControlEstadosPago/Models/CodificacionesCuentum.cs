using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

public partial class CodificacionesCuentum
{
    [Key]
    public int Id { get; set; }

    [StringLength(25)]
    public string TipoTarjetaBanco { get; set; } = null!;

    [StringLength(4)]
    public string Moneda { get; set; } = null!;

    [StringLength(50)]
    public string CodificacionCuenta { get; set; } = null!;

    [StringLength(50)]
    public string DeudorSAP { get; set; } = null!;

    [StringLength(50)]
    public string Origen { get; set; } = null!;
}
