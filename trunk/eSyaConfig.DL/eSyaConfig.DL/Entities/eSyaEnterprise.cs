﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HCP.Config.DL.Entities
{
    public partial class eSyaEnterprise : DbContext
    {
        public static string _connString = "";
        public eSyaEnterprise()
        {
        }

        public eSyaEnterprise(DbContextOptions<eSyaEnterprise> options)
            : base(options)
        {
        }

        public virtual DbSet<GtAddrin> GtAddrin { get; set; }
        public virtual DbSet<GtDccnst> GtDccnst { get; set; }
        public virtual DbSet<GtDncn01> GtDncn01 { get; set; }
        public virtual DbSet<GtDncn02> GtDncn02 { get; set; }
        public virtual DbSet<GtDncn03> GtDncn03 { get; set; }
        public virtual DbSet<GtDncnfd> GtDncnfd { get; set; }
        public virtual DbSet<GtDnvcdt> GtDnvcdt { get; set; }
        public virtual DbSet<GtEadpcd> GtEadpcd { get; set; }
        public virtual DbSet<GtEadpll> GtEadpll { get; set; }
        public virtual DbSet<GtEastbl> GtEastbl { get; set; }
        public virtual DbSet<GtEbecnt> GtEbecnt { get; set; }
        public virtual DbSet<GtEcapcd> GtEcapcd { get; set; }
        public virtual DbSet<GtEcapct> GtEcapct { get; set; }
        public virtual DbSet<GtEcaprb> GtEcaprb { get; set; }
        public virtual DbSet<GtEcaprl> GtEcaprl { get; set; }
        public virtual DbSet<GtEcbsen> GtEcbsen { get; set; }
        public virtual DbSet<GtEcbsla> GtEcbsla { get; set; }
        public virtual DbSet<GtEcbsln> GtEcbsln { get; set; }
        public virtual DbSet<GtEcbssc> GtEcbssc { get; set; }
        public virtual DbSet<GtEcbssd> GtEcbssd { get; set; }
        public virtual DbSet<GtEcbssg> GtEcbssg { get; set; }
        public virtual DbSet<GtEcbssu> GtEcbssu { get; set; }
        public virtual DbSet<GtEcbsun> GtEcbsun { get; set; }
        public virtual DbSet<GtEcclco> GtEcclco { get; set; }
        public virtual DbSet<GtEccldt> GtEccldt { get; set; }
        public virtual DbSet<GtEccncd> GtEccncd { get; set; }
        public virtual DbSet<GtEccnpi> GtEccnpi { get; set; }
        public virtual DbSet<GtEccnpl> GtEccnpl { get; set; }
        public virtual DbSet<GtEccnsd> GtEccnsd { get; set; }
        public virtual DbSet<GtEccntc> GtEccntc { get; set; }
        public virtual DbSet<GtEccnti> GtEccnti { get; set; }
        public virtual DbSet<GtEccntr> GtEccntr { get; set; }
        public virtual DbSet<GtEccuco> GtEccuco { get; set; }
        public virtual DbSet<GtEccudn> GtEccudn { get; set; }
        public virtual DbSet<GtEcdccn> GtEcdccn { get; set; }
        public virtual DbSet<GtEcfmac> GtEcfmac { get; set; }
        public virtual DbSet<GtEcfmal> GtEcfmal { get; set; }
        public virtual DbSet<GtEcfmap> GtEcfmap { get; set; }
        public virtual DbSet<GtEcfmfd> GtEcfmfd { get; set; }
        public virtual DbSet<GtEcfmnm> GtEcfmnm { get; set; }
        public virtual DbSet<GtEcfmpa> GtEcfmpa { get; set; }
        public virtual DbSet<GtEcfmps> GtEcfmps { get; set; }
        public virtual DbSet<GtEcfmst> GtEcfmst { get; set; }
        public virtual DbSet<GtEcfmta> GtEcfmta { get; set; }
        public virtual DbSet<GtEcgrrh> GtEcgrrh { get; set; }
        public virtual DbSet<GtEchlms> GtEchlms { get; set; }
        public virtual DbSet<GtEcinvr> GtEcinvr { get; set; }
        public virtual DbSet<GtEciuom> GtEciuom { get; set; }
        public virtual DbSet<GtEcltcd> GtEcltcd { get; set; }
        public virtual DbSet<GtEcltfc> GtEcltfc { get; set; }
        public virtual DbSet<GtEclttl> GtEclttl { get; set; }
        public virtual DbSet<GtEclttm> GtEclttm { get; set; }
        public virtual DbSet<GtEcmamn> GtEcmamn { get; set; }
        public virtual DbSet<GtEcmnfl> GtEcmnfl { get; set; }
        public virtual DbSet<GtEcpabl> GtEcpabl { get; set; }
        public virtual DbSet<GtEcparh> GtEcparh { get; set; }
        public virtual DbSet<GtEcparm> GtEcparm { get; set; }
        public virtual DbSet<GtEcpast> GtEcpast { get; set; }
        public virtual DbSet<GtEcprrl> GtEcprrl { get; set; }
        public virtual DbSet<GtEcpvln> GtEcpvln { get; set; }
        public virtual DbSet<GtEcpyid> GtEcpyid { get; set; }
        public virtual DbSet<GtEcsbmn> GtEcsbmn { get; set; }
        public virtual DbSet<GtEcsmsd> GtEcsmsd { get; set; }
        public virtual DbSet<GtEcsmsh> GtEcsmsh { get; set; }
        public virtual DbSet<GtEcsmsr> GtEcsmsr { get; set; }
        public virtual DbSet<GtEcsmst> GtEcsmst { get; set; }
        public virtual DbSet<GtEcsmsv> GtEcsmsv { get; set; }
        public virtual DbSet<GtEcstrm> GtEcstrm { get; set; }
        public virtual DbSet<GtEcsupa> GtEcsupa { get; set; }
        public virtual DbSet<GtEctm01> GtEctm01 { get; set; }
        public virtual DbSet<GtEctm02> GtEctm02 { get; set; }
        public virtual DbSet<GtEcvyid> GtEcvyid { get; set; }
        public virtual DbSet<GtEuusgr> GtEuusgr { get; set; }
        public virtual DbSet<GtIfcrer> GtIfcrer { get; set; }
        public virtual DbSet<GtMapane> GtMapane { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(_connString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<GtAddrin>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.AreaCode });

                entity.ToTable("GT_ADDRIN");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Taluk).HasMaxLength(150);
            });

            modelBuilder.Entity<GtDccnst>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("GT_DCCNST");

                entity.Property(e => e.DocumentId).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.SchemeName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDesc)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtDncn01>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.DocumentId, e.FinancialYear });

                entity.ToTable("GT_DNCN01");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrentDocDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtDncn02>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.DocumentId, e.FinancialYear, e.TransactionMode });

                entity.ToTable("GT_DNCN02");

                entity.Property(e => e.TransactionMode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrentDocDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtDncn03>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.DocumentId, e.FinancialYear, e.TransactionMode, e.StoreCode });

                entity.ToTable("GT_DNCN03");

                entity.Property(e => e.TransactionMode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrentDocDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtDncnfd>(entity =>
            {
                entity.HasKey(e => new { e.FormId, e.DocumentId });

                entity.ToTable("GT_DNCNFD");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtDnvcdt>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.FinancialYear, e.PaymentId, e.VoucherId, e.VoucherType });

                entity.ToTable("GT_DNVCDT");

                entity.Property(e => e.VoucherType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreditDebitId)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentVoucherDate).HasColumnType("datetime");

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEadpcd>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("GT_EADPCD");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepartmentDesc)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.DeptShortDesc)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEadpll>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.DepartmentId, e.DeptLocnId });

                entity.ToTable("GT_EADPLL");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DeptLocnId).HasColumnName("DeptLocnID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LocnShortDesc)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.GtEadpll)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_EADPLL_GT_EADPCD");
            });

            modelBuilder.Entity<GtEastbl>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.StoreCode, e.StoreClass });

                entity.ToTable("GT_EASTBL");

                entity.Property(e => e.StoreClass)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.BusinessKeyNavigation)
                    .WithMany(p => p.GtEastbl)
                    .HasPrincipalKey(p => p.BusinessKey)
                    .HasForeignKey(d => d.BusinessKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_EASTBL_GT_ECBSLN");
            });

            modelBuilder.Entity<GtEbecnt>(entity =>
            {
                entity.ToTable("GT_EBECNT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcapcd>(entity =>
            {
                entity.HasKey(e => e.ApplicationCode)
                    .HasName("PK_GT_ECAPCD_1");

                entity.ToTable("GT_ECAPCD");

                entity.Property(e => e.ApplicationCode).ValueGeneratedNever();

                entity.Property(e => e.CodeDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ShortCode).HasMaxLength(15);

                entity.HasOne(d => d.CodeTypeNavigation)
                    .WithMany(p => p.GtEcapcd)
                    .HasForeignKey(d => d.CodeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECAPCD_GT_ECAPCT");
            });

            modelBuilder.Entity<GtEcapct>(entity =>
            {
                entity.HasKey(e => e.CodeType);

                entity.ToTable("GT_ECAPCT");

                entity.Property(e => e.CodeType).ValueGeneratedNever();

                entity.Property(e => e.CodeTyepDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodeTypeControl)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcaprb>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.RuleId, e.ProcessId });

                entity.ToTable("GT_ECAPRB");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcaprl>(entity =>
            {
                entity.HasKey(e => new { e.RuleId, e.ProcessId });

                entity.ToTable("GT_ECAPRL");

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(1000);

                entity.Property(e => e.RuleDesc)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.GtEcaprl)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECAPRL_GT_ECPRRL");
            });

            modelBuilder.Entity<GtEcbsen>(entity =>
            {
                entity.HasKey(e => e.BusinessId);

                entity.ToTable("GT_ECBSEN");

                entity.Property(e => e.BusinessId)
                    .HasColumnName("BusinessID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusinessDesc)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.BusinessUnitType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('S')");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcbsla>(entity =>
            {
                entity.HasKey(e => e.BusinessKey);

                entity.ToTable("GT_ECBSLA");

                entity.Property(e => e.BusinessKey).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EMailId)
                    .HasColumnName("eMailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmergencyNumber).HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.Pincode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.WebSite)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtEcbsln>(entity =>
            {
                entity.HasKey(e => new { e.BusinessId, e.SegmentId })
                    .HasName("PK_GT_ECBSLN_1");

                entity.ToTable("GT_ECBSLN");

                entity.HasIndex(e => e.BusinessKey)
                    .HasName("IX_GT_ECBSLN")
                    .IsUnique();

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.SegmentId).HasColumnName("SegmentID");

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.EActiveUsers)
                    .IsRequired()
                    .HasColumnName("eActiveUsers");

                entity.Property(e => e.EBusinessKey)
                    .IsRequired()
                    .HasColumnName("eBusinessKey");

                entity.Property(e => e.ENoOfBeds).HasColumnName("eNoOfBeds");

                entity.Property(e => e.ESyaLicenseType)
                    .IsRequired()
                    .HasColumnName("eSyaLicenseType")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EUserLicenses)
                    .IsRequired()
                    .HasColumnName("eUserLicenses");

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.LocationDescription)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.TocurrConversion).HasColumnName("TOCurrConversion");

                entity.Property(e => e.TolocalCurrency)
                    .IsRequired()
                    .HasColumnName("TOLocalCurrency")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TorealCurrency).HasColumnName("TORealCurrency");
            });

            modelBuilder.Entity<GtEcbssc>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.TocurrencyCode })
                    .HasName("PK_GT_ECBSSC_1");

                entity.ToTable("GT_ECBSSC");

                entity.Property(e => e.TocurrencyCode)
                    .HasColumnName("TOCurrencyCode")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcbssd>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.StatutoryCode });

                entity.ToTable("GT_ECBSSD");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.StatutoryDescription)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcbssg>(entity =>
            {
                entity.HasKey(e => new { e.BusinessId, e.SegmentId });

                entity.ToTable("GT_ECBSSG");

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.SegmentId).HasColumnName("SegmentID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.OrgnDateFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SegmentDesc)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.GtEcbssg)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECBSSG_GT_ECBSEN");
            });

            modelBuilder.Entity<GtEcbssu>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.SubscribedFrom })
                    .HasName("PK_GT_ECBSSU_1");

                entity.ToTable("GT_ECBSSU");

                entity.Property(e => e.SubscribedFrom).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.SubscribedTill).HasColumnType("datetime");

                entity.HasOne(d => d.BusinessKeyNavigation)
                    .WithMany(p => p.GtEcbssu)
                    .HasPrincipalKey(p => p.BusinessKey)
                    .HasForeignKey(d => d.BusinessKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECBSSU_GT_ECBSLN");
            });

            modelBuilder.Entity<GtEcbsun>(entity =>
            {
                entity.HasKey(e => new { e.BusinessId, e.BusinessUnitId });

                entity.ToTable("GT_ECBSUN");

                entity.HasIndex(e => e.BusinessKey)
                    .HasName("IX_GT_ECBSUN")
                    .IsUnique();

                entity.Property(e => e.BusinessId).HasColumnName("BusinessID");

                entity.Property(e => e.BoacostCentre).HasColumnName("BOACostCentre");

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.TocurrConversion).HasColumnName("TOCurrConversion");

                entity.Property(e => e.TolocalCurrency)
                    .IsRequired()
                    .HasColumnName("TOLocalCurrency")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TorealCurrency).HasColumnName("TORealCurrency");

                entity.Property(e => e.UnitDesc)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<GtEcclco>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.FinancialYear });

                entity.ToTable("GT_ECCLCO");

                entity.Property(e => e.FinancialYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.TillDate).HasColumnType("datetime");

                entity.HasOne(d => d.BusinessKeyNavigation)
                    .WithMany(p => p.GtEcclco)
                    .HasPrincipalKey(p => p.BusinessKey)
                    .HasForeignKey(d => d.BusinessKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECCLCO_GT_ECBSLN");
            });

            modelBuilder.Entity<GtEccldt>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.FinancialYear, e.MonthId });

                entity.ToTable("GT_ECCLDT");

                entity.Property(e => e.FinancialYear).HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MonthId).HasColumnName("MonthID");

                entity.Property(e => e.BudgetMonth)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.MonthFreezeHis).HasColumnName("MonthFreezeHIS");

                entity.Property(e => e.MonthFreezeHr).HasColumnName("MonthFreezeHR");

                entity.Property(e => e.PatientIdgen).HasColumnName("PatientIDGen");

                entity.Property(e => e.PatientIdserial)
                    .IsRequired()
                    .HasColumnName("PatientIDSerial")
                    .HasMaxLength(1);

                entity.HasOne(d => d.GtEcclco)
                    .WithMany(p => p.GtEccldt)
                    .HasForeignKey(d => new { d.BusinessKey, d.FinancialYear })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECCLDT_GT_ECCLCO");
            });

            modelBuilder.Entity<GtEccncd>(entity =>
            {
                entity.HasKey(e => e.Isdcode);

                entity.ToTable("GT_ECCNCD");

                entity.Property(e => e.Isdcode)
                    .HasColumnName("ISDCode")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.CountryFlag)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.DateFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsPinapplicable).HasColumnName("IsPINApplicable");

                entity.Property(e => e.IsPoboxApplicable).HasColumnName("IsPOBoxApplicable");

                entity.Property(e => e.MobileNumberPattern)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.PincodePattern)
                    .HasColumnName("PINcodePattern")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PoboxPattern)
                    .HasColumnName("POBoxPattern")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ShortDateFormat)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Uidlabel)
                    .HasColumnName("UIDLabel")
                    .HasMaxLength(50);

                entity.Property(e => e.Uidpattern)
                    .HasColumnName("UIDPattern")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<GtEccnpi>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.Uidlabel });

                entity.ToTable("GT_ECCNPI");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.Uidlabel)
                    .HasColumnName("UIDLabel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Uidpattern)
                    .IsRequired()
                    .HasColumnName("UIDPattern")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtEccnpl>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.PlaceId });

                entity.ToTable("GT_ECCNPL");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.PlaceName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<GtEccnsd>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.StatutoryCode });

                entity.ToTable("GT_ECCNSD");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.StatPattern)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.StatShortCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatutoryDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IsdcodeNavigation)
                    .WithMany(p => p.GtEccnsd)
                    .HasForeignKey(d => d.Isdcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECCNSD_GT_ECCNCD");
            });

            modelBuilder.Entity<GtEccntc>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.TaxCode });

                entity.ToTable("GT_ECCNTC");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.SlabOrPerc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TaxDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaxShortCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.IsdcodeNavigation)
                    .WithMany(p => p.GtEccntc)
                    .HasForeignKey(d => d.Isdcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECCNTC_GT_ECCNCD");
            });

            modelBuilder.Entity<GtEccnti>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.TaxIdentificationId })
                    .HasName("PK_GT_ECCNTI_1");

                entity.ToTable("GT_ECCNTI");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.TaxIdentificationId).HasColumnName("TaxIdentificationID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TaxIdentificationDesc)
                    .IsRequired()
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<GtEccntr>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.TaxCode, e.SerialNumber });

                entity.ToTable("GT_ECCNTR");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.SlabOrPerc)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SplitCategoryPerc).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.TaxDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TaxShortCode)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<GtEccuco>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode);

                entity.ToTable("GT_ECCUCO");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.DecimalPlaces).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.DecimalPortionWord).HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<GtEccudn>(entity =>
            {
                entity.HasKey(e => new { e.CurrencyCode, e.BnorCnId, e.DenomId });

                entity.ToTable("GT_ECCUDN");

                entity.Property(e => e.CurrencyCode).HasMaxLength(4);

                entity.Property(e => e.BnorCnId)
                    .HasColumnName("BNorCN_ID")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DenomId)
                    .HasColumnName("DenomID")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DenomConversion).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.DenomDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.GtEccudn)
                    .HasForeignKey(d => d.CurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECCUDN_GT_ECCUCO");
            });

            modelBuilder.Entity<GtEcdccn>(entity =>
            {
                entity.HasKey(e => new { e.FormId, e.DocumentId });

                entity.ToTable("GT_ECDCCN");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocCatgDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocCodeDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentCategory)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.DocumentCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.DocumentType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.GtEcdccn)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECDCCN_GT_ECFMFD");
            });

            modelBuilder.Entity<GtEcfmac>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.ToTable("GT_ECFMAC");

                entity.Property(e => e.ActionId)
                    .HasColumnName("ActionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcfmal>(entity =>
            {
                entity.HasKey(e => new { e.FormId, e.ActionId });

                entity.ToTable("GT_ECFMAL");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.GtEcfmal)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECFMAL_GT_ECFMAC");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.GtEcfmal)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECFMAL_GT_ECFMFD");
            });

            modelBuilder.Entity<GtEcfmap>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.FormId, e.TaskId, e.ApprovalLevelStage, e.ApproverPriority, e.UserRole });

                entity.ToTable("GT_ECFMAP");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.ApprovalRangeFrom).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.ApprovalRangeTo).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcfmfd>(entity =>
            {
                entity.HasKey(e => e.FormId);

                entity.ToTable("GT_ECFMFD");

                entity.Property(e => e.FormId)
                    .HasColumnName("FormID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ControllerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FormName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ToolTip).HasMaxLength(100);
            });

            modelBuilder.Entity<GtEcfmnm>(entity =>
            {
                entity.HasKey(e => new { e.FormId, e.FormIntId });

                entity.ToTable("GT_ECFMNM");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.FormIntId)
                    .HasColumnName("FormIntID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.NavigateUrl)
                    .IsRequired()
                    .HasColumnName("NavigateURL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.GtEcfmnm)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECFMNM_GT_ECFMFD");
            });

            modelBuilder.Entity<GtEcfmpa>(entity =>
            {
                entity.HasKey(e => new { e.FormId, e.ParameterId });

                entity.ToTable("GT_ECFMPA");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.GtEcfmpa)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECFMPA_GT_ECFMFD");
            });

            modelBuilder.Entity<GtEcfmps>(entity =>
            {
                entity.HasKey(e => new { e.FormId, e.ParameterId, e.SubParameterId });

                entity.ToTable("GT_ECFMPS");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcfmst>(entity =>
            {
                entity.HasKey(e => new { e.FormId, e.StoreCode });

                entity.ToTable("GT_ECFMST");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcfmta>(entity =>
            {
                entity.HasKey(e => new { e.FormId, e.TaskId });

                entity.ToTable("GT_ECFMTA");

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcgrrh>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.ReportHeader });

                entity.ToTable("GT_ECGRRH");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ReportHeaderDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ReportHeaderTemplate).IsRequired();

                entity.HasOne(d => d.BusinessKeyNavigation)
                    .WithMany(p => p.GtEcgrrh)
                    .HasPrincipalKey(p => p.BusinessKey)
                    .HasForeignKey(d => d.BusinessKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECGRRH_GT_ECBSLN");
            });

            modelBuilder.Entity<GtEchlms>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.HolidayDate });

                entity.ToTable("GT_ECHLMS");

                entity.Property(e => e.HolidayDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.HolidayDesc)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcinvr>(entity =>
            {
                entity.HasKey(e => e.InventoryRuleId);

                entity.ToTable("GT_ECINVR");

                entity.Property(e => e.InventoryRuleId)
                    .HasColumnName("InventoryRuleID")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplyToSrn).HasColumnName("ApplyToSRN");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryRuleDesc)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEciuom>(entity =>
            {
                entity.HasKey(e => e.UnitOfMeasure);

                entity.ToTable("GT_ECIUOM");

                entity.Property(e => e.UnitOfMeasure).ValueGeneratedNever();

                entity.Property(e => e.ConversionFactor).HasColumnType("numeric(12, 5)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Uompdesc)
                    .IsRequired()
                    .HasColumnName("UOMPDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Uompurchase)
                    .IsRequired()
                    .HasColumnName("UOMPurchase")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Uomsdesc)
                    .IsRequired()
                    .HasColumnName("UOMSDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Uomstock)
                    .IsRequired()
                    .HasColumnName("UOMStock")
                    .HasMaxLength(4)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtEcltcd>(entity =>
            {
                entity.HasKey(e => new { e.ResourceId, e.Culture })
                    .HasName("PK_GT_ECLTFT");

                entity.ToTable("GT_ECLTCD");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");

                entity.Property(e => e.Culture).HasMaxLength(10);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.Resource)
                    .WithMany(p => p.GtEcltcd)
                    .HasForeignKey(d => d.ResourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECLTFT_GT_ECLTFC");
            });

            modelBuilder.Entity<GtEcltfc>(entity =>
            {
                entity.HasKey(e => e.ResourceId);

                entity.ToTable("GT_ECLTFC");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("ResourceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtEclttl>(entity =>
            {
                entity.HasKey(e => new { e.LanguageCode, e.TableCode, e.TablePrimaryKeyId });

                entity.ToTable("GT_ECLTTL");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.TablePrimaryKeyId).HasColumnName("TablePrimaryKeyID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FieldDescLanguage)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.TableCodeNavigation)
                    .WithMany(p => p.GtEclttl)
                    .HasForeignKey(d => d.TableCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECLTTL_GT_ECLTTM");
            });

            modelBuilder.Entity<GtEclttm>(entity =>
            {
                entity.HasKey(e => e.TableCode);

                entity.ToTable("GT_ECLTTM");

                entity.Property(e => e.TableCode).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtEcmamn>(entity =>
            {
                entity.HasKey(e => e.MainMenuId);

                entity.ToTable("GT_ECMAMN");

                entity.Property(e => e.MainMenuId)
                    .HasColumnName("MainMenuID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MainMenu)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcmnfl>(entity =>
            {
                entity.HasKey(e => new { e.FormId, e.MainMenuId, e.MenuItemId });

                entity.ToTable("GT_ECMNFL");

                entity.HasIndex(e => e.MenuKey)
                    .HasName("IX_GT_ECMNFL")
                    .IsUnique();

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.MainMenuId).HasColumnName("MainMenuID");

                entity.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormNameClient)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.GtEcmnfl)
                    .HasForeignKey(d => d.FormId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECMNFL_GT_ECFMFD");

                entity.HasOne(d => d.MainMenu)
                    .WithMany(p => p.GtEcmnfl)
                    .HasForeignKey(d => d.MainMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECMNFL_GT_ECMAMN");
            });

            modelBuilder.Entity<GtEcpabl>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.ParameterId });

                entity.ToTable("GT_ECPABL");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ParmDesc)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ParmPerc).HasColumnType("numeric(5, 2)");

                entity.Property(e => e.ParmValue).HasColumnType("numeric(18, 6)");

                entity.HasOne(d => d.BusinessKeyNavigation)
                    .WithMany(p => p.GtEcpabl)
                    .HasPrincipalKey(p => p.BusinessKey)
                    .HasForeignKey(d => d.BusinessKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECPABL_GT_ECBSLN");
            });

            modelBuilder.Entity<GtEcparh>(entity =>
            {
                entity.HasKey(e => e.ParameterType);

                entity.ToTable("GT_ECPARH");

                entity.Property(e => e.ParameterType).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ParameterHeaderDesc)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcparm>(entity =>
            {
                entity.HasKey(e => new { e.ParameterType, e.ParameterId });

                entity.ToTable("GT_ECPARM");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ParameterDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParameterValueType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtEcpast>(entity =>
            {
                entity.HasKey(e => new { e.StoreCode, e.ParameterId });

                entity.ToTable("GT_ECPAST");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.StoreCodeNavigation)
                    .WithMany(p => p.GtEcpast)
                    .HasForeignKey(d => d.StoreCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECPAST_GT_ECSTRM");
            });

            modelBuilder.Entity<GtEcprrl>(entity =>
            {
                entity.HasKey(e => e.ProcessId);

                entity.ToTable("GT_ECPRRL");

                entity.Property(e => e.ProcessId)
                    .HasColumnName("ProcessID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ProcessControl)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDesc)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<GtEcpvln>(entity =>
            {
                entity.HasKey(e => new { e.PaymentId, e.VoucherId });

                entity.ToTable("GT_ECPVLN");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcpyid>(entity =>
            {
                entity.HasKey(e => new { e.PaymentId, e.PaymentModeId, e.PaymentModeCategoryId });

                entity.ToTable("GT_ECPYID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEcsbmn>(entity =>
            {
                entity.HasKey(e => new { e.MenuItemId, e.MainMenuId });

                entity.ToTable("GT_ECSBMN");

                entity.Property(e => e.MenuItemId).HasColumnName("MenuItemID");

                entity.Property(e => e.MainMenuId).HasColumnName("MainMenuID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MenuItemName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.MainMenu)
                    .WithMany(p => p.GtEcsbmn)
                    .HasForeignKey(d => d.MainMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECSBMN_GT_ECMAMN");
            });

            modelBuilder.Entity<GtEcsmsd>(entity =>
            {
                entity.HasKey(e => new { e.Smsid, e.ParameterId });

                entity.ToTable("GT_ECSMSD");

                entity.Property(e => e.Smsid)
                    .HasColumnName("SMSID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.Sms)
                    .WithMany(p => p.GtEcsmsd)
                    .HasForeignKey(d => d.Smsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECSMSD_GT_ECSMSH");
            });

            modelBuilder.Entity<GtEcsmsh>(entity =>
            {
                entity.HasKey(e => e.Smsid);

                entity.ToTable("GT_ECSMSH");

                entity.Property(e => e.Smsid)
                    .HasColumnName("SMSID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId).HasColumnName("FormID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Smsdescription)
                    .IsRequired()
                    .HasColumnName("SMSDescription")
                    .HasMaxLength(100);

                entity.Property(e => e.Smsstatement)
                    .IsRequired()
                    .HasColumnName("SMSStatement")
                    .HasMaxLength(500);

                entity.Property(e => e.TeventId).HasColumnName("TEventID");
            });

            modelBuilder.Entity<GtEcsmsr>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.Smsid, e.MobileNumber });

                entity.ToTable("GT_ECSMSR");

                entity.Property(e => e.Smsid)
                    .HasColumnName("SMSID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.RecipientName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(25);

                entity.HasOne(d => d.Sms)
                    .WithMany(p => p.GtEcsmsr)
                    .HasForeignKey(d => d.Smsid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECSMSR_GT_ECSMSH");
            });

            modelBuilder.Entity<GtEcsmst>(entity =>
            {
                entity.HasKey(e => e.TeventId);

                entity.ToTable("GT_ECSMST");

                entity.Property(e => e.TeventId)
                    .HasColumnName("TEventID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.TeventDesc)
                    .IsRequired()
                    .HasColumnName("TEventDesc")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<GtEcsmsv>(entity =>
            {
                entity.HasKey(e => e.Smsvariable);

                entity.ToTable("GT_ECSMSV");

                entity.Property(e => e.Smsvariable)
                    .HasColumnName("SMSVariable")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.Smscomponent)
                    .IsRequired()
                    .HasColumnName("SMSComponent")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtEcstrm>(entity =>
            {
                entity.HasKey(e => e.StoreCode)
                    .HasName("PK_GT_ECSTRM_1");

                entity.ToTable("GT_ECSTRM");

                entity.Property(e => e.StoreCode).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.StoreDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StoreType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GtEcsupa>(entity =>
            {
                entity.HasKey(e => new { e.Isdcode, e.StatutoryCode, e.ParameterId });

                entity.ToTable("GT_ECSUPA");

                entity.Property(e => e.Isdcode).HasColumnName("ISDCode");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);
            });

            modelBuilder.Entity<GtEctm01>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.ToTable("GT_ECTM01");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("TemplateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DispSeqId).HasColumnName("DispSeqID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<GtEctm02>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.ExaminationId });

                entity.ToTable("GT_ECTM02");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.ExaminationId).HasColumnName("ExaminationID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DispSeqId).HasColumnName("DispSeqID");

                entity.Property(e => e.ExaminationName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.OptionValues).HasMaxLength(50);

                entity.Property(e => e.ValueType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.GtEctm02)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_ECTM02_GT_ECTM01");
            });

            modelBuilder.Entity<GtEcvyid>(entity =>
            {
                entity.HasKey(e => e.VoucherId);

                entity.ToTable("GT_ECVYID");

                entity.Property(e => e.VoucherId).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VoucherDesc)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<GtEuusgr>(entity =>
            {
                entity.HasKey(e => new { e.UserGroup, e.UserType, e.UserRole, e.MenuKey });

                entity.ToTable("GT_EUUSGR");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FormId)
                    .IsRequired()
                    .HasColumnName("FormID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.HasOne(d => d.MenuKeyNavigation)
                    .WithMany(p => p.GtEuusgr)
                    .HasPrincipalKey(p => p.MenuKey)
                    .HasForeignKey(d => d.MenuKey)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_EUUSGR_GT_ECMNFL");

                entity.HasOne(d => d.UserGroupNavigation)
                    .WithMany(p => p.GtEuusgrUserGroupNavigation)
                    .HasForeignKey(d => d.UserGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_EUUSGR_GT_ECAPCD");

                entity.HasOne(d => d.UserTypeNavigation)
                    .WithMany(p => p.GtEuusgrUserTypeNavigation)
                    .HasForeignKey(d => d.UserType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GT_EUUSGR_GT_ECAPCD1");
            });

            modelBuilder.Entity<GtIfcrer>(entity =>
            {
                entity.HasKey(e => new { e.BusinessKey, e.CurrencyCode, e.DateOfExchangeRate });

                entity.ToTable("GT_IFCRER");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfExchangeRate).HasColumnType("datetime");

                entity.Property(e => e.BuyingLastVoucherDate).HasColumnType("datetime");

                entity.Property(e => e.BuyingRate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.SellingLastVoucherDate).HasColumnType("datetime");

                entity.Property(e => e.SellingRate).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.StandardRate).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<GtMapane>(entity =>
            {
                entity.HasKey(e => new { e.TemplateType, e.TemplateId, e.LanguageCode });

                entity.ToTable("GT_MAPANE");

                entity.Property(e => e.TemplateType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.LanguageCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.CreatedTerminal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.DisplayType)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Faqs)
                    .HasColumnName("FAQs")
                    .HasMaxLength(500);

                entity.Property(e => e.FaqsAnswer).HasColumnName("FAQsAnswer");

                entity.Property(e => e.ImageUrl)
                    .HasColumnName("ImageURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedTerminal).HasMaxLength(50);

                entity.Property(e => e.VideoUrl)
                    .HasColumnName("VideoURL")
                    .HasMaxLength(500);
            });
        }
    }
}
