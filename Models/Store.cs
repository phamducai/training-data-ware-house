using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models;

[Keyless]
[Table("Store")]
[Index("StkId", "NodeId", "StkName", "PlaceId", "Phone", "Email", "OpenDate", "ClosedDate", "Disabled", Name = "NonClusteredIndex-20230917-230803")]
public partial class Store
{
    [Column("STK_ID")]
    public int? StkId { get; set; }

    [Column("STK_Code")]
    [StringLength(12)]
    [Unicode(false)]
    public string? StkCode { get; set; }

    [Column("StkClust_ID")]
    public int? StkClustId { get; set; }

    [Column("Node_ID")]
    public int? NodeId { get; set; }

    [Column("Invoice_Code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceCode { get; set; }

    [Column("Invoice_Symb")]
    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceSymb { get; set; }

    [Column("STK_SYMB")]
    [StringLength(25)]
    [Unicode(false)]
    public string? StkSymb { get; set; }

    [Column("STK_CAP")]
    [StringLength(10)]
    [Unicode(false)]
    public string? StkCap { get; set; }

    [Column("STK_Name")]
    [StringLength(60)]
    public string? StkName { get; set; }

    [Column("STK_Addr")]
    [StringLength(120)]
    public string? StkAddr { get; set; }

    [Column("Place_ID")]
    public int? PlaceId { get; set; }

    [Column("PLC_NAME")]
    [StringLength(200)]
    public string? PlcName { get; set; }

    [StringLength(24)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [StringLength(40)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("Con_Person")]
    [StringLength(50)]
    public string? ConPerson { get; set; }

    [Column("Open_Date", TypeName = "datetime")]
    public DateTime? OpenDate { get; set; }

    [Column("Closed_Date", TypeName = "datetime")]
    public DateTime? ClosedDate { get; set; }

    public bool? Disabled { get; set; }
}
