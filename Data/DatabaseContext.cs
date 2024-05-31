using System;
using System.Collections.Generic;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Barcode> Barcodes { get; set; }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<GoodsGrp> GoodsGrps { get; set; }

    public virtual DbSet<GoodsSet> GoodsSets { get; set; }

    public virtual DbSet<GsetItem> GsetItems { get; set; }

    public virtual DbSet<Obj> Objs { get; set; }

    public virtual DbSet<OleDbDestination> OleDbDestinations { get; set; }

    public virtual DbSet<OleDbSd> OleDbSds { get; set; }

    public virtual DbSet<PaymentMode> PaymentModes { get; set; }

    public virtual DbSet<RtPprog> RtPprogs { get; set; }

    public virtual DbSet<RtPprogCase> RtPprogCases { get; set; }

    public virtual DbSet<RtPprogPhase> RtPprogPhases { get; set; }

    public virtual DbSet<RtPprogPistore> RtPprogPistores { get; set; }

    public virtual DbSet<RtPprogPo> RtPprogPos { get; set; }

    public virtual DbSet<RtPrice> RtPrices { get; set; }

    public virtual DbSet<RtProgCpitem> RtProgCpitems { get; set; }

    public virtual DbSet<RtProgPsitem> RtProgPsitems { get; set; }

    public virtual DbSet<Station> Stations { get; set; }

    public virtual DbSet<StkTranCl> StkTranCls { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    public virtual DbSet<StrHdr> StrHdrs { get; set; }

    public virtual DbSet<StrHdr2021> StrHdr2021s { get; set; }

    public virtual DbSet<StrHdr2022> StrHdr2022s { get; set; }

    public virtual DbSet<StrHdr2023> StrHdr2023s { get; set; }

    public virtual DbSet<StrPayment> StrPayments { get; set; }

    public virtual DbSet<StrPayment2021> StrPayment2021s { get; set; }

    public virtual DbSet<StrPayment2022> StrPayment2022s { get; set; }

    public virtual DbSet<StrPayment2023> StrPayment2023s { get; set; }

    public virtual DbSet<StrSaleDtl> StrSaleDtls { get; set; }

    public virtual DbSet<StrSaleDtl2021> StrSaleDtl2021s { get; set; }

    public virtual DbSet<StrSaleDtl2022> StrSaleDtl2022s { get; set; }

    public virtual DbSet<StrSaleDtl2023> StrSaleDtl2023s { get; set; }

    public virtual DbSet<StrSaleSet> StrSaleSets { get; set; }

    public virtual DbSet<StrSaleSet2021> StrSaleSet2021s { get; set; }

    public virtual DbSet<StrSaleSet2022> StrSaleSet2022s { get; set; }

    public virtual DbSet<StrSaleSet2023> StrSaleSet2023s { get; set; }

    public virtual DbSet<Taxation> Taxations { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=192.168.10.18\\\\\\\\POS_SQLSERVER,1433;Database=HQ_DW;User Id=it;Password=Famima@123;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Barcode>(entity =>
        {
            entity.HasIndex(e => e.GoodsId, "ClusteredIndex-20230917-230012").IsClustered();
        });

        modelBuilder.Entity<Good>(entity =>
        {
            entity.HasIndex(e => e.GoodsId, "ClusteredIndex-20230917-230031").IsClustered();
        });

        modelBuilder.Entity<GoodsGrp>(entity =>
        {
            entity.HasIndex(e => e.GgrpId, "ClusteredIndex-20230917-230125").IsClustered();
        });

        modelBuilder.Entity<GoodsSet>(entity =>
        {
            entity.HasIndex(e => e.GsetId, "ClusteredIndex-20230917-230146").IsClustered();
        });

        modelBuilder.Entity<GsetItem>(entity =>
        {
            entity.HasIndex(e => e.GsetId, "ClusteredIndex-20230917-230212").IsClustered();
        });

        modelBuilder.Entity<Obj>(entity =>
        {
            entity.HasIndex(e => e.ObjId, "ClusteredIndex-20230917-230229").IsClustered();
        });

        modelBuilder.Entity<PaymentMode>(entity =>
        {
            entity.HasIndex(e => e.PmtId, "ClusteredIndex-20230917-230238").IsClustered();
        });

        modelBuilder.Entity<RtPprog>(entity =>
        {
            entity.HasIndex(e => e.PprogId, "ClusteredIndex-20230917-230520").IsClustered();
        });

        modelBuilder.Entity<RtPprogCase>(entity =>
        {
            entity.HasIndex(e => e.PprogId, "ClusteredIndex-20230917-230256").IsClustered();
        });

        modelBuilder.Entity<RtPprogPhase>(entity =>
        {
            entity.HasIndex(e => e.PprogId, "ClusteredIndex-20230917-230325").IsClustered();
        });

        modelBuilder.Entity<RtPprogPistore>(entity =>
        {
            entity.HasIndex(e => e.PprogId, "ClusteredIndex-20230917-230425").IsClustered();
        });

        modelBuilder.Entity<RtPprogPo>(entity =>
        {
            entity.HasIndex(e => e.PprogId, "ClusteredIndex-20230917-230504").IsClustered();
        });

        modelBuilder.Entity<RtPrice>(entity =>
        {
            entity.HasIndex(e => e.GoodsId, "ClusteredIndex-20230917-230545").IsClustered();
        });

        modelBuilder.Entity<RtProgCpitem>(entity =>
        {
            entity.HasIndex(e => e.PprogId, "ClusteredIndex-20230917-230606").IsClustered();
        });

        modelBuilder.Entity<RtProgPsitem>(entity =>
        {
            entity.HasIndex(e => e.PprogId, "ClusteredIndex-20230917-230629").IsClustered();
        });

        modelBuilder.Entity<Station>(entity =>
        {
            entity.HasIndex(e => e.SunitId, "ClusteredIndex-20230917-230649").IsClustered();
        });

        modelBuilder.Entity<StkTranCl>(entity =>
        {
            entity.Property(e => e.ExObjClsIds).HasDefaultValue("");
            entity.Property(e => e.FrStkTypeIds).HasDefaultValue("");
            entity.Property(e => e.GtypeIds).HasDefaultValue("");
            entity.Property(e => e.SkustatIds).HasDefaultValue("");
            entity.Property(e => e.StkTrClsCode)
                .HasDefaultValue("")
                .IsFixedLength();
            entity.Property(e => e.StkTrClsIdx)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.StkTrClsName).HasDefaultValue("");
            entity.Property(e => e.ToStkTypeIds).HasDefaultValue("");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasIndex(e => e.StkClustId, "ClusteredIndex-20230917-230722").IsClustered();
        });

        modelBuilder.Entity<StrHdr>(entity =>
        {
            entity.HasIndex(e => new { e.WorkingDate, e.TransNo }, "ClusteredIndex-20230917-230843").IsClustered();
        });

        modelBuilder.Entity<StrPayment>(entity =>
        {
            entity.HasIndex(e => new { e.WorkingDate, e.TransNo }, "ClusteredIndex-20230917-230946").IsClustered();
        });

        modelBuilder.Entity<StrSaleDtl>(entity =>
        {
            entity.HasIndex(e => new { e.WorkingDate, e.TransNo }, "Idx_Str_saledtl_ClusteredIndex_Trans_No").IsClustered();
        });

        modelBuilder.Entity<StrSaleSet>(entity =>
        {
            entity.HasIndex(e => new { e.WorkingDate, e.TransNo }, "ClusteredIndex-20230917-231435").IsClustered();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
