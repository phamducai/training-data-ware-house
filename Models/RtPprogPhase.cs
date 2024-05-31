using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("RT_PProgPhase")]
[Index("PhaseDate", "StkClustId", "PitemId", "FortuneRate", Name = "NonClusteredIndex-20230917-230333")]
public partial class RtPprogPhase
{
    [Column("PProg_ID")]
    public int? PprogId { get; set; }

    [Column("Phase_Date", TypeName = "datetime")]
    public DateTime? PhaseDate { get; set; }

    [Column("StkClust_ID")]
    public int? StkClustId { get; set; }

    [Column("Fortune_Rate", TypeName = "numeric(18, 2)")]
    public decimal? FortuneRate { get; set; }

    [Column("PItem_ID")]
    public int? PitemId { get; set; }

    [Column("PItem_Code")]
    [StringLength(20)]
    public string? PitemCode { get; set; }

    [Column("AddPItem_Qty", TypeName = "numeric(18, 2)")]
    public decimal? AddPitemQty { get; set; }

    [Column("GivePItem_Qty", TypeName = "numeric(18, 2)")]
    public decimal? GivePitemQty { get; set; }
}
