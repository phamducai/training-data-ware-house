using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("Str_Hdr_2023")]
[Index("WorkingDate")]
public partial class StrHdr2023
{
    [Column("Trans_No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TransNo { get; set; }

    public DateOnly? WorkingDate { get; set; }

    public DateOnly? Actual { get; set; }

    public TimeOnly? Time { get; set; }

    public int? Hour { get; set; }

    public int? Week { get; set; }

    public int? Month { get; set; }

    public int? Year { get; set; }

    [Column("Job_Date", TypeName = "datetime")]
    public DateTime? JobDate { get; set; }

    [Column("StkTrCls_ID")]
    public int? StkTrClsId { get; set; }

    [Column("TrRef_No")]
    [StringLength(20)]
    public string? TrRefNo { get; set; }

    [Column("TrRef_Date")]
    public DateOnly? TrRefDate { get; set; }

    [Column("Shift_No")]
    public int? ShiftNo { get; set; }

    [Column("WS_ID")]
    public int? WsId { get; set; }

    [Column("Member_No")]
    [StringLength(25)]
    public string? MemberNo { get; set; }

    [Column("Node_ID")]
    public int? NodeId { get; set; }

    [Column("User_ID")]
    public int? UserId { get; set; }

    [Column("Random_Code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RandomCode { get; set; }

    [StringLength(100)]
    public string? Remark { get; set; }

    public bool? Disabled { get; set; }
}
