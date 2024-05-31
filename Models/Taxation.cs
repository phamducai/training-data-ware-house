using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("Taxation")]
public partial class Taxation
{
    [Column("Tax_ID")]
    public int? TaxId { get; set; }

    [Column("Tax_Code")]
    [StringLength(2)]
    [Unicode(false)]
    public string? TaxCode { get; set; }

    [StringLength(50)]
    public string? Description { get; set; }

    [Column("Tax_Rate", TypeName = "numeric(6, 2)")]
    public decimal? TaxRate { get; set; }
}
