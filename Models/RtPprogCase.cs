using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("RT_PProgCase")]
[Index("PcaseIdx", Name = "NonClusteredIndex-20230917-230303")]
public partial class RtPprogCase
{
    [Column("PProg_ID")]
    public int? PprogId { get; set; }

    [Column("PCase_IDX")]
    public int? PcaseIdx { get; set; }

    [StringLength(200)]
    public string? Description { get; set; }

    [Column("Promotion_Type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PromotionType { get; set; }
}
