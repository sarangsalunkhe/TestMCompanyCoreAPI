using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TestMCompanyCoreAPI.Models
{
    public partial class DbBrokerageNewContext : DbContext
    {
        public DbBrokerageNewContext()
        {
        }

        public DbBrokerageNewContext(DbContextOptions<DbBrokerageNewContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mcompany> Mcompanies { get; set; } = null!;
        public virtual DbSet<Mcustomer> Mcustomers { get; set; } = null!;
        public virtual DbSet<Mexpense> Mexpenses { get; set; } = null!;
        public virtual DbSet<MfinancialYear> MfinancialYears { get; set; } = null!;
        public virtual DbSet<Mmaterial> Mmaterials { get; set; } = null!;
        public virtual DbSet<Mmenu> Mmenus { get; set; } = null!;
        public virtual DbSet<MmenuRight> MmenuRights { get; set; } = null!;
        public virtual DbSet<MopningBalnce> MopningBalnces { get; set; } = null!;
        public virtual DbSet<Mpacking> Mpackings { get; set; } = null!;
        public virtual DbSet<MpaymentTerm> MpaymentTerms { get; set; } = null!;
        public virtual DbSet<Mpoterm> Mpoterms { get; set; } = null!;
        public virtual DbSet<Msupplier> Msuppliers { get; set; } = null!;
        public virtual DbSet<Munit> Munits { get; set; } = null!;
        public virtual DbSet<Muser> Musers { get; set; } = null!;
        public virtual DbSet<VbillEntry> VbillEntries { get; set; } = null!;
        public virtual DbSet<VcontractDetail> VcontractDetails { get; set; } = null!;
        public virtual DbSet<VcustomerOutStanding> VcustomerOutStandings { get; set; } = null!;
        public virtual DbSet<VdailyExpenseDetail> VdailyExpenseDetails { get; set; } = null!;
        public virtual DbSet<VsupplierOutStanding> VsupplierOutStandings { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-0J4S9AS;database=DbBrokerageNew;user id=sa;password=Game@123;trusted_connection=false;", x => x.UseNetTopologySuite());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mcompany>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("MCompany");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.Bst)
                    .HasMaxLength(50)
                    .HasColumnName("BST");

                entity.Property(e => e.CellNo).HasMaxLength(20);

                entity.Property(e => e.CompanyAdddess).HasMaxLength(300);

                entity.Property(e => e.CompanyCode).HasMaxLength(3);

                entity.Property(e => e.CompanyName).HasMaxLength(30);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cst)
                    .HasMaxLength(50)
                    .HasColumnName("CST");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.Panno)
                    .HasMaxLength(50)
                    .HasColumnName("PANNo");

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.TallyId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mcustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("MCustomer");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(300)
                    .HasDefaultValueSql("('ABC')");

                entity.Property(e => e.BankName)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('ABC')");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('ABC')");

                entity.Property(e => e.BrokeragePer).HasMaxLength(5);

                entity.Property(e => e.Bstno)
                    .HasMaxLength(50)
                    .HasColumnName("BSTNo");

                entity.Property(e => e.CellNo).HasMaxLength(20);

                entity.Property(e => e.ContactPerson).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cstno)
                    .HasMaxLength(50)
                    .HasColumnName("CSTNo");

                entity.Property(e => e.CustomerAddress).HasMaxLength(300);

                entity.Property(e => e.CustomerCode).HasMaxLength(5);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.EmailId).HasMaxLength(500);

                entity.Property(e => e.Faxno)
                    .HasMaxLength(50)
                    .HasColumnName("FAXNo");

                entity.Property(e => e.Ifsccode)
                    .HasMaxLength(12)
                    .HasColumnName("IFSCCode");

                entity.Property(e => e.Panno)
                    .HasMaxLength(50)
                    .HasColumnName("PANNo");

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Tanno)
                    .HasMaxLength(50)
                    .HasColumnName("TANNo");

                entity.Property(e => e.Vatno)
                    .HasMaxLength(50)
                    .HasColumnName("VATNo");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Mcustomers)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MCustomer_MUser");
            });

            modelBuilder.Entity<Mexpense>(entity =>
            {
                entity.HasKey(e => e.ExpenseId)
                    .HasName("PK_Mexpenses");

                entity.ToTable("MExpenses");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.BatchExpense).HasMaxLength(1);

                entity.Property(e => e.CompanyId).HasDefaultValueSql("('001')");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ExpenseCode).HasMaxLength(3);

                entity.Property(e => e.ExpenseName).HasMaxLength(50);

                entity.Property(e => e.MaxLimit).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Module).HasMaxLength(2);

                entity.Property(e => e.ProductionFlag)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Specification).HasMaxLength(100);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Mexpenses)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MExpenses_MUser");
            });

            modelBuilder.Entity<MfinancialYear>(entity =>
            {
                entity.HasKey(e => e.TrId);

                entity.ToTable("MFinancialYear");

                entity.Property(e => e.AcFlag)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.FinancialYear)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Fyear)
                    .HasMaxLength(4)
                    .HasColumnName("FYear")
                    .IsFixedLength();

                entity.Property(e => e.YearClose)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mmaterial>(entity =>
            {
                entity.HasKey(e => e.MaterialId);

                entity.ToTable("MMaterial");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ForCasteFlag).HasMaxLength(1);

                entity.Property(e => e.MaterialCode).HasMaxLength(7);

                entity.Property(e => e.MaterialName).HasMaxLength(100);

                entity.Property(e => e.Remark)
                    .HasMaxLength(200)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mmenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MMenu");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MenuId).ValueGeneratedOnAdd();

                entity.Property(e => e.MenuName).HasMaxLength(50);

                entity.Property(e => e.Module).HasMaxLength(2);

                entity.Property(e => e.ParentId).HasMaxLength(4);

                entity.Property(e => e.Tag).HasMaxLength(50);
            });

            modelBuilder.Entity<MmenuRight>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MMenuRights");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<MopningBalnce>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("MOpningBalnce");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.AcType).HasMaxLength(1);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Fyear)
                    .HasMaxLength(4)
                    .HasColumnName("FYear")
                    .IsFixedLength();

                entity.Property(e => e.Module).HasMaxLength(2);

                entity.Property(e => e.OpeningBal).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.Tcode)
                    .HasMaxLength(5)
                    .HasColumnName("TCode");
            });

            modelBuilder.Entity<Mpacking>(entity =>
            {
                entity.HasKey(e => e.PackingId);

                entity.ToTable("MPacking");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.PackingCode).HasMaxLength(3);

                entity.Property(e => e.PackingName).HasMaxLength(30);

                entity.Property(e => e.Remark).HasMaxLength(200);
            });

            modelBuilder.Entity<MpaymentTerm>(entity =>
            {
                entity.HasKey(e => e.PaymentTermId);

                entity.ToTable("MPaymentTerms");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.CreatedBy).HasMaxLength(1);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Days).HasMaxLength(3);

                entity.Property(e => e.PaymentTermCode).HasMaxLength(3);

                entity.Property(e => e.PaymentTermDescription).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(200);
            });

            modelBuilder.Entity<Mpoterm>(entity =>
            {
                entity.HasKey(e => e.PotermsId);

                entity.ToTable("MPOTerms");

                entity.Property(e => e.PotermsId).HasColumnName("POtermsId");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Module).HasMaxLength(2);

                entity.Property(e => e.PotermsCode)
                    .HasMaxLength(3)
                    .HasColumnName("POtermsCode");

                entity.Property(e => e.PotermsName)
                    .HasMaxLength(50)
                    .HasColumnName("POtermsName");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Mpoterms)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MPOTerms_MUser");
            });

            modelBuilder.Entity<Msupplier>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("MSupplier");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.AccountNo).HasMaxLength(50);

                entity.Property(e => e.BankAddress).HasMaxLength(500);

                entity.Property(e => e.BankName).HasMaxLength(30);

                entity.Property(e => e.BranchName).HasMaxLength(30);

                entity.Property(e => e.BrokeragePer).HasMaxLength(50);

                entity.Property(e => e.Bstno)
                    .HasMaxLength(50)
                    .HasColumnName("BSTNo");

                entity.Property(e => e.CellNo).HasMaxLength(20);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Cstno)
                    .HasMaxLength(50)
                    .HasColumnName("CSTNo");

                entity.Property(e => e.EmailId).HasMaxLength(500);

                entity.Property(e => e.Faxno)
                    .HasMaxLength(50)
                    .HasColumnName("FAXNo");

                entity.Property(e => e.Panno)
                    .HasMaxLength(50)
                    .HasColumnName("PANNo");

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.SupplierAddress).HasMaxLength(300);

                entity.Property(e => e.SupplierCode).HasMaxLength(5);

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.Tanno)
                    .HasMaxLength(50)
                    .HasColumnName("TANNo");

                entity.Property(e => e.Vatno)
                    .HasMaxLength(50)
                    .HasColumnName("VATNo");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Msuppliers)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("FK_MSupplier_MUser");
            });

            modelBuilder.Entity<Munit>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("MUnit");

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.UnitCode).HasMaxLength(3);

                entity.Property(e => e.UnitName).HasMaxLength(30);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Munits)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MUnit_MUnit");
            });

            modelBuilder.Entity<Muser>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("MUser");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.AcFlag).HasMaxLength(1);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Module).HasMaxLength(2);

                entity.Property(e => e.UserName).HasMaxLength(30);

                entity.Property(e => e.UserPwd).HasMaxLength(50);

                entity.Property(e => e.UserType).HasMaxLength(20);
            });

            modelBuilder.Entity<VbillEntry>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VBillEntry");

                entity.Property(e => e.BillAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillNo).HasMaxLength(10);

                entity.Property(e => e.BillQty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BrokeragePer).HasMaxLength(50);

                entity.Property(e => e.CellNo).HasMaxLength(20);

                entity.Property(e => e.CheckFlag).HasMaxLength(1);

                entity.Property(e => e.CompanyAdddess).HasMaxLength(300);

                entity.Property(e => e.CompanyName).HasMaxLength(30);

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractNo).HasMaxLength(5);

                entity.Property(e => e.ContractQty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CustBrokragePercent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CustCellNo).HasMaxLength(20);

                entity.Property(e => e.CustPhoneNo).HasMaxLength(20);

                entity.Property(e => e.CustomerAddress).HasMaxLength(300);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.Expr1).HasMaxLength(5);

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.MaterialName).HasMaxLength(100);

                entity.Property(e => e.Panno)
                    .HasMaxLength(50)
                    .HasColumnName("PANNo");

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.SupBrokragePercent).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SupCellNo).HasMaxLength(20);

                entity.Property(e => e.SupPhoneNo).HasMaxLength(20);

                entity.Property(e => e.SupplierAddress).HasMaxLength(300);

                entity.Property(e => e.SupplierName).HasMaxLength(50);
            });

            modelBuilder.Entity<VcontractDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VContractDetails");

                entity.Property(e => e.BasicAmount).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.BillAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.BillQty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CellNo).HasMaxLength(20);

                entity.Property(e => e.CompanyAdddess).HasMaxLength(300);

                entity.Property(e => e.CompanyName).HasMaxLength(30);

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractNo).HasMaxLength(5);

                entity.Property(e => e.ContractQty).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.ContractRate).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.CustCellNo).HasMaxLength(20);

                entity.Property(e => e.CustEmail).HasMaxLength(500);

                entity.Property(e => e.CustPhone).HasMaxLength(20);

                entity.Property(e => e.CustomerAddress).HasMaxLength(300);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.DeliveryPlace).HasMaxLength(50);

                entity.Property(e => e.DeliveryType).HasMaxLength(1);

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.Fyear)
                    .HasMaxLength(4)
                    .HasColumnName("FYear");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.MaterialName).HasMaxLength(100);

                entity.Property(e => e.OtherRemark).HasMaxLength(200);

                entity.Property(e => e.PackingName).HasMaxLength(30);

                entity.Property(e => e.PanNo).HasMaxLength(50);

                entity.Property(e => e.PaymentDays).HasMaxLength(3);

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.Poterms)
                    .HasMaxLength(500)
                    .HasColumnName("POTerms");

                entity.Property(e => e.StBagWt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SupCellNo).HasMaxLength(20);

                entity.Property(e => e.SupEmail).HasMaxLength(500);

                entity.Property(e => e.SuppPhone).HasMaxLength(20);

                entity.Property(e => e.SupplierAddress).HasMaxLength(300);

                entity.Property(e => e.SupplierBillDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Supplier Bill Date");

                entity.Property(e => e.SupplierBillNo)
                    .HasMaxLength(10)
                    .HasColumnName("Supplier Bill No");

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(15, 3)");

                entity.Property(e => e.UnitName).HasMaxLength(30);
            });

            modelBuilder.Entity<VcustomerOutStanding>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VCustomerOutStanding");

                entity.Property(e => e.BillAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Bill Amount");

                entity.Property(e => e.BillQuantity)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Bill Quantity");

                entity.Property(e => e.BrokerageAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Brokerage Amount");

                entity.Property(e => e.BrokeragePercent)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Brokerage Percent");

                entity.Property(e => e.CellNo).HasMaxLength(20);

                entity.Property(e => e.CompanyAdddess).HasMaxLength(300);

                entity.Property(e => e.CompanyName).HasMaxLength(30);

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(5)
                    .HasColumnName("Contract No");

                entity.Property(e => e.CustBrokrageReceived).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CustPaidFlag).HasMaxLength(1);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("Customer Name");

                entity.Property(e => e.DeductionAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Deduction Amount");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.Fyear)
                    .HasMaxLength(4)
                    .HasColumnName("FYear");

                entity.Property(e => e.Panno)
                    .HasMaxLength(50)
                    .HasColumnName("PANNo");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Payment Date");

                entity.Property(e => e.PaymentId)
                    .HasMaxLength(10)
                    .HasColumnName("Payment Id");

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.SupplierBillDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Supplier Bill Date");

                entity.Property(e => e.SupplierBillNo)
                    .HasMaxLength(10)
                    .HasColumnName("Supplier Bill No");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("Total Amount");
            });

            modelBuilder.Entity<VdailyExpenseDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VDailyExpenseDetails");

                entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CellNo).HasMaxLength(20);

                entity.Property(e => e.CompanyAdddess).HasMaxLength(300);

                entity.Property(e => e.CompanyName).HasMaxLength(30);

                entity.Property(e => e.DailyExpenseId).HasMaxLength(7);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.ExpenseName).HasMaxLength(50);

                entity.Property(e => e.Fyear)
                    .HasMaxLength(5)
                    .HasColumnName("FYear");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.Purpose).HasMaxLength(100);

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Specification).HasMaxLength(100);

                entity.Property(e => e.TotalAmt).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VatAmount).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<VsupplierOutStanding>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VSupplierOutStanding");

                entity.Property(e => e.BillAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Bill Amount");

                entity.Property(e => e.BillQuantity)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Bill Quantity");

                entity.Property(e => e.BrokerageAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Brokerage Amount");

                entity.Property(e => e.BrokeragePercent)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Brokerage Percent");

                entity.Property(e => e.CellNo).HasMaxLength(20);

                entity.Property(e => e.CompanyAdddess).HasMaxLength(300);

                entity.Property(e => e.CompanyName).HasMaxLength(30);

                entity.Property(e => e.ContractDate).HasColumnType("datetime");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(5)
                    .HasColumnName("Contract No");

                entity.Property(e => e.DeductionAmount)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Deduction Amount");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.Fyear)
                    .HasMaxLength(4)
                    .HasColumnName("FYear");

                entity.Property(e => e.Panno)
                    .HasMaxLength(50)
                    .HasColumnName("PANNo");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Payment Date");

                entity.Property(e => e.PaymentId)
                    .HasMaxLength(10)
                    .HasColumnName("Payment Id");

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.SupBrokrageReceived).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SupPaidFlag).HasMaxLength(1);

                entity.Property(e => e.SupplierBillDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Supplier Bill Date");

                entity.Property(e => e.SupplierBillNo)
                    .HasMaxLength(10)
                    .HasColumnName("Supplier Bill No");

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(50)
                    .HasColumnName("Supplier Name");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("decimal(15, 2)")
                    .HasColumnName("Total Amount");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
