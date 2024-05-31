using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("OBJS")]
public partial class Obj
{
    [Column("Obj_ID")]
    public int? ObjId { get; set; }

    [Column("Obj_Desc")]
    [StringLength(100)]
    public string? ObjDesc { get; set; }
}
