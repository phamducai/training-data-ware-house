using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Index("WsId", "WsName", "SunitCode", "NodeId", "IsNode", "PunitId", "Status", Name = "NonClusteredIndex-20230917-230657")]
public partial class Station
{
    [Column("WS_ID")]
    public int? WsId { get; set; }

    [Column("WS_Name")]
    [StringLength(20)]
    [Unicode(false)]
    public string? WsName { get; set; }

    [Column("SUnit_ID")]
    public int? SunitId { get; set; }

    [Column("SUnit_Code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SunitCode { get; set; }

    [Column("Node_ID")]
    public int? NodeId { get; set; }

    [Column("isNode")]
    public bool? IsNode { get; set; }

    [Column("PUnit_ID")]
    public int? PunitId { get; set; }

    public bool? Status { get; set; }
}
