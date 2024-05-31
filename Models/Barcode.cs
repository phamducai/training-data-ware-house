using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("Barcode")]
[Index("Barcode1", Name = "NonClusteredIndex-20230917-230021")]
public partial class Barcode
{
    [Column("Barcode")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Barcode1 { get; set; }

    [Column("Goods_ID")]
    public int? GoodsId { get; set; }
}
