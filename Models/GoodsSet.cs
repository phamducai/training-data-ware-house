using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("GoodsSet")]
[Index("Disabled", Name = "NonClusteredIndex-20230917-230157")]
public partial class GoodsSet
{
    [Column("GSet_ID")]
    public int? GsetId { get; set; }

    [Column("GSet_Code")]
    [StringLength(4)]
    [Unicode(false)]
    public string? GsetCode { get; set; }

    [Column("GSet_Desc")]
    [StringLength(50)]
    public string? GsetDesc { get; set; }

    public bool? Disabled { get; set; }
}
