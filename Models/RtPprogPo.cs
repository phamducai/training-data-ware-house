using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("RT_PProgPOS")]
[Index("StkClustId", Name = "NonClusteredIndex-20230917-230512")]
public partial class RtPprogPo
{
    [Column("PProg_ID")]
    public int? PprogId { get; set; }

    [Column("StkClust_ID")]
    public int? StkClustId { get; set; }
}
