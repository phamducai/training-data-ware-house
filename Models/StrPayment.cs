using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("STr_Payment")]
[Index("WorkingDate", "StkTrClsId", "PmtId", "UserId", "Disabled", Name = "NonClusteredIndex-20230917-230952")]
public partial class StrPayment
{
    [Column("Trans_No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TransNo { get; set; }

    public DateOnly? WorkingDate { get; set; }

    [Column("StkTrCls_ID")]
    public int? StkTrClsId { get; set; }

    [Column("Pmt_ID")]
    public int? PmtId { get; set; }

    [Column("Payment_Amt", TypeName = "numeric(12, 2)")]
    public decimal? PaymentAmt { get; set; }

    [Column("User_ID")]
    public int? UserId { get; set; }

    public bool? Disabled { get; set; }

    [Column("P_tran_ID")]
    public string? PTranId { get; set; }

    [Column("P_OrderID")]
    public string? POrderId { get; set; }

    [Column("Pmt_IDX")]
    public int? PmtIdx { get; set; }
}
