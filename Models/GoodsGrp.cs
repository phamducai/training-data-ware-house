using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("GoodsGrp")]
[Index("GgrpCode", "GgrpName", Name = "NonClusteredIndex-20230917-230133")]
public partial class GoodsGrp
{
    [Column("GGrp_ID")]
    public int? GgrpId { get; set; }

    [Column("GGrp_Code")]
    [StringLength(8)]
    public string? GgrpCode { get; set; }

    [Column("GGrp_Name")]
    [StringLength(20)]
    public string? GgrpName { get; set; }
}
