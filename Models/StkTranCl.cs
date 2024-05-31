using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

public partial class StkTranCl
{
    [Key]
    [Column("StkTrCls_ID")]
    public int StkTrClsId { get; set; }

    [Column("StkTrCls_Code")]
    [StringLength(2)]
    [Unicode(false)]
    public string StkTrClsCode { get; set; } = null!;

    [Column("StkTrCls_Name")]
    [StringLength(100)]
    public string StkTrClsName { get; set; } = null!;

    [Column("Resource_ID")]
    public int ResourceId { get; set; }

    [Column("SKUStat_IDs")]
    [StringLength(2)]
    [Unicode(false)]
    public string SkustatIds { get; set; } = null!;

    [Column("GType_IDs")]
    [StringLength(4)]
    [Unicode(false)]
    public string GtypeIds { get; set; } = null!;

    [Column("isStockOut")]
    public bool IsStockOut { get; set; }

    [Column("FrStkType_IDs")]
    [StringLength(4)]
    [Unicode(false)]
    public string FrStkTypeIds { get; set; } = null!;

    [Column("isStockIn")]
    public bool IsStockIn { get; set; }

    [Column("ToStkType_IDs")]
    [StringLength(2)]
    [Unicode(false)]
    public string ToStkTypeIds { get; set; } = null!;

    [Column("ExObjCls_IDs")]
    [StringLength(2)]
    [Unicode(false)]
    public string ExObjClsIds { get; set; } = null!;

    [Column("isChg_Qty")]
    public bool IsChgQty { get; set; }

    [Column("isChg_Amt")]
    public bool IsChgAmt { get; set; }

    [Column("isChg_Status")]
    public bool IsChgStatus { get; set; }

    [Column("isChg_Loca")]
    public bool IsChgLoca { get; set; }

    [Column("isPayment")]
    public bool IsPayment { get; set; }

    [Column("isDebt")]
    public bool IsDebt { get; set; }

    [Column("isInvoice")]
    public bool IsInvoice { get; set; }

    [Column("Obj_ID")]
    public int ObjId { get; set; }

    public bool Disabled { get; set; }

    [Column("StkTrCls_IDX")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StkTrClsIdx { get; set; }
}
