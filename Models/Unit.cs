using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
public partial class Unit
{
    [Column("Unit_ID")]
    public int? UnitId { get; set; }

    [Column("Unit_Code")]
    [StringLength(8)]
    public string? UnitCode { get; set; }
}
