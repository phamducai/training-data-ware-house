using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Index("ShortName", "FullName", "GoodsGrpId", "IsPromotion", "Is4SaleOrder", "TaxId", "Disabled", Name = "NonClusteredIndex-20230917-230038")]
public partial class Good
{
    [Column("Goods_ID")]
    public int? GoodsId { get; set; }

    [Column("Goods_Code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? GoodsCode { get; set; }

    [Column("Short_Name")]
    [StringLength(60)]
    public string? ShortName { get; set; }

    [Column("Full_Name")]
    [StringLength(60)]
    public string? FullName { get; set; }

    [Column("Goods_Grp_ID")]
    public int? GoodsGrpId { get; set; }

    [Column("isPromotion")]
    public bool? IsPromotion { get; set; }

    public bool? Is4SaleOrder { get; set; }

    [Column("Tax_ID")]
    public int? TaxId { get; set; }

    [Column("SKUBase_Unit")]
    public int? SkubaseUnit { get; set; }

    public bool? Disabled { get; set; }
}
