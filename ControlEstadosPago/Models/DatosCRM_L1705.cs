using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Keyless]
[Table("DatosCRM_L1705")]
public partial class DatosCRM_L1705
{
    [StringLength(50)]
    [Unicode(false)]
    public string? CFCHENVIO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CFEFECDOC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CFEIVATASB { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CFEIVATTAB { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CFEMONTIP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CFEMONTOT { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CFEMONTOTP { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ERPNRODOC { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? CFESERDOC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CFENRODOC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CFETIPDOC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CFETMOIVAB { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ERPSERDOC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ERPTIPDOC { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ESTADO { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NROMOV { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ORIGEN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? NROLOTE { get; set; }
}
