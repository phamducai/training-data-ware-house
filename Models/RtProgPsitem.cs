using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("RT_ProgPSItem")]
[Index("PcaseIdx", "PsitemId", Name = "NonClusteredIndex-20230917-230637")]
public partial class RtProgPsitem
{
    [Column("PProg_ID")]
    public int? PprogId { get; set; }

    [Column("PCase_IDX")]
    public int? PcaseIdx { get; set; }

    [Column("PSItem_ID")]
    public int? PsitemId { get; set; }

    [Column("PSItem_Code")]
    [StringLength(20)]
    public string? PsitemCode { get; set; }

    [Column("Sold_TrQty", TypeName = "numeric(18, 2)")]
    public decimal? SoldTrQty { get; set; }

    [Column("Sold_TrAmt", TypeName = "numeric(18, 2)")]
    public decimal? SoldTrAmt { get; set; }
}
