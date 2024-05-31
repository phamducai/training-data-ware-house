using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("GSetItems")]
[Index("GsitemId", Name = "NonClusteredIndex-20230917-230220")]
public partial class GsetItem
{
    [Column("GSet_ID")]
    public int? GsetId { get; set; }

    [Column("GSItem_ID")]
    public int? GsitemId { get; set; }
}
