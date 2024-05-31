using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("RT_ProgCPItem")]
[Index("PcaseIdx", "PitemId", Name = "NonClusteredIndex-20230917-230613")]
public partial class RtProgCpitem
{
    [Column("PProg_ID")]
    public int? PprogId { get; set; }

    [Column("PCase_IDX")]
    public int? PcaseIdx { get; set; }

    [Column("PItem_ID")]
    public int? PitemId { get; set; }

    [Column("PItem_Code")]
    [StringLength(20)]
    public string? PitemCode { get; set; }

    [Column("PItem_Qty", TypeName = "numeric(18, 2)")]
    public decimal? PitemQty { get; set; }
}
