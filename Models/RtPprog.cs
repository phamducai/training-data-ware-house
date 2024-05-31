using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("RT_PProgs")]
[Index("PprogCode", "PtypeId", "PromotionCode", "PromDescription", "EffectDate", "DueDate", "Disabled", Name = "NonClusteredIndex-20230917-230527")]
public partial class RtPprog
{
    [Column("PProg_ID")]
    public int? PprogId { get; set; }

    [Column("PProg_Code")]
    [StringLength(20)]
    public string? PprogCode { get; set; }

    [Column("PType_ID")]
    public int? PtypeId { get; set; }

    [Column("Promotion_Code")]
    [StringLength(12)]
    public string? PromotionCode { get; set; }

    [Column("Prom_Description")]
    [StringLength(200)]
    public string? PromDescription { get; set; }

    [Column("Effect_Date", TypeName = "datetime")]
    public DateTime? EffectDate { get; set; }

    [Column("Due_Date", TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    public bool? Disabled { get; set; }
}
