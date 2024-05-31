using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
public partial class User
{
    [Column("User_ID")]
    public int? UserId { get; set; }

    [Column("Node_ID")]
    public int? NodeId { get; set; }

    public int? Type { get; set; }

    [Column("Login_Name")]
    [StringLength(15)]
    [Unicode(false)]
    public string? LoginName { get; set; }

    [Column("Full_Name")]
    [StringLength(60)]
    public string? FullName { get; set; }

    [StringLength(100)]
    public string? OrgPosition { get; set; }

    public bool? Status { get; set; }
}
