using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("OLE DB sd")]
public partial class OleDbSd
{
    public DateOnly? Actual { get; set; }

    public DateOnly? WorkingDate { get; set; }

    [Column("Trans_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TransNo { get; set; }

    [Column("StkTrCls_ID")]
    public int? StkTrClsId { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    [Column("Stk_ID")]
    public int? StkId { get; set; }

    [Column("Goods_ID")]
    public int? GoodsId { get; set; }

    [Column("SKUBase_Qty")]
    public double? SkubaseQty { get; set; }

    [Column("Sales_Amt")]
    public double? SalesAmt { get; set; }

    [Column("VAT_Amt")]
    public double? VatAmt { get; set; }

    [Column("Direct_Disc_Amt")]
    public double? DirectDiscAmt { get; set; }

    [Column("Tax_ID")]
    public int? TaxId { get; set; }

    public bool? Disabled { get; set; }

    [Column("Pmt_ID")]
    public int? PmtId { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? Noted { get; set; }
}
