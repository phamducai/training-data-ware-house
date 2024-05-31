using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("STr_SaleSet_2023")]
[Index("WorkingDate")]
public partial class StrSaleSet2023
{
    [Column("Trans_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TransNo { get; set; }

    public DateOnly? WorkingDate { get; set; }

    [Column("StkTrCls_ID")]
    public int? StkTrClsId { get; set; }

    [Column("Stk_ID")]
    public int? StkId { get; set; }

    [Column("PProg_ID")]
    public int? PprogId { get; set; }

    [Column("PCase_IDX")]
    public int? PcaseIdx { get; set; }

    [Column("SSet_IDX")]
    public int? SsetIdx { get; set; }

    [Column("SSet_Qty")]
    public int? SsetQty { get; set; }

    [Column("Goods_ID")]
    public int? GoodsId { get; set; }

    [Column("Goods_Qty", TypeName = "numeric(18, 2)")]
    public decimal? GoodsQty { get; set; }

    [Column("SKU_Code")]
    [StringLength(12)]
    [Unicode(false)]
    public string? SkuCode { get; set; }

    [Column("GoodsUnit_ID")]
    public int? GoodsUnitId { get; set; }

    [Column("Payable_Amt", TypeName = "numeric(18, 2)")]
    public decimal? PayableAmt { get; set; }

    [Column("Tax_ID")]
    public int? TaxId { get; set; }

    public bool? Disabled { get; set; }
}
