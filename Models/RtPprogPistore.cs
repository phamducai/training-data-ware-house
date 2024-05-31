using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("RT_PProgPIStore")]
[Index("StkClustId", "FortuneRate", "PitemId", Name = "NonClusteredIndex-20230917-230434")]
public partial class RtPprogPistore
{
    [Column("PProg_ID")]
    public int? PprogId { get; set; }

    [Column("StkClust_ID")]
    public int? StkClustId { get; set; }

    [Column("Fortune_Rate", TypeName = "numeric(18, 2)")]
    public decimal? FortuneRate { get; set; }

    [Column("PItem_ID")]
    public int? PitemId { get; set; }

    [Column("PItem_Code")]
    [StringLength(20)]
    public string? PitemCode { get; set; }

    [Column("MaxPItem_Qty", TypeName = "numeric(18, 2)")]
    public decimal? MaxPitemQty { get; set; }

    [Column("TotalPItem_Qty", TypeName = "numeric(18, 2)")]
    public decimal? TotalPitemQty { get; set; }
}
