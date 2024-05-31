using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("PaymentMode")]
public partial class PaymentMode
{
    [Column("Pmt_ID")]
    public int? PmtId { get; set; }

    [Column("Pmt_Code")]
    [StringLength(5)]
    [Unicode(false)]
    public string? PmtCode { get; set; }

    [Column("IDX")]
    public int? Idx { get; set; }

    [StringLength(100)]
    public string? Descript { get; set; }
}
