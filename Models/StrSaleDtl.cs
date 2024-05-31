using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("STr_SaleDtl")]
[Index("WorkingDate", "StkTrClsId", "Actual", "Time", "Hour", "Week", "Month", "Year", "StkId", "GoodsId", "TaxId", "Disabled", Name = "str_saledtl_NonClusteredIndex")]
public partial class StrSaleDtl
{
    [Column("Trans_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TransNo { get; set; }

    public DateOnly? WorkingDate { get; set; }

    [Column("Shift_No")]
    public int? ShiftNo { get; set; }

    [Column("StkTrCls_ID")]
    public int? StkTrClsId { get; set; }

    public DateOnly? Actual { get; set; }

    public TimeOnly? Time { get; set; }

    public int? Hour { get; set; }

    public int? Week { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    [Column("Stk_ID")]
    public int? StkId { get; set; }

    [Column("Goods_ID")]
    public int? GoodsId { get; set; }

    [Column("SKU_Code")]
    [StringLength(12)]
    [Unicode(false)]
    public string? SkuCode { get; set; }

    [Column("SKUBase_Qty")]
    public double? SkubaseQty { get; set; }

    [Column("SKUBaseUnit_ID")]
    public int? SkubaseUnitId { get; set; }

    [Column("Sales_Amt")]
    public double? SalesAmt { get; set; }

    [Column("VAT_Amt")]
    public double? VatAmt { get; set; }

    [Column("Direct_Disc_Amt")]
    public double? DirectDiscAmt { get; set; }

    [Column("User_ID")]
    public int? UserId { get; set; }

    [Column("WS_ID")]
    public int? WsId { get; set; }

    [Column("Tax_ID")]
    public int? TaxId { get; set; }

    public bool? Disabled { get; set; }
}
