using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ControlEstadosPago.Models;

[Table("IdenTransExt")]
public partial class IdenTransExt
{
    [Key]
    public int Id { get; set; }

    public long IdTransExtAntel { get; set; }
}
