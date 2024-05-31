using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("RT_Price")]
public partial class RtPrice
{
    [Column("Goods_ID")]
    public int? GoodsId { get; set; }

    [Column("SKU_Code")]
    [StringLength(12)]
    [Unicode(false)]
    public string? SkuCode { get; set; }

    [Column("RT_Price", TypeName = "numeric(18, 5)")]
    public decimal? RtPrice1 { get; set; }
}
