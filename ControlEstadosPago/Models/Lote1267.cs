using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("Lote1267")]
public partial class Lote1267
{
    [StringLength(20)]
    public string id_crm { get; set; } = null!;

    [StringLength(1)]
    public string serie { get; set; } = null!;

    [StringLength(20)]
    public string nro_documento { get; set; } = null!;

    [StringLength(50)]
    public string nro_interno { get; set; } = null!;

    [StringLength(3)]
    public string id_tipo_comprobante { get; set; } = null!;
}
