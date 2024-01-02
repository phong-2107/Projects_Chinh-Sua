using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entities
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CT_AnhXe> CT_AnhXe { get; set; }
        public virtual DbSet<CT_HOPDONG> CT_HOPDONG { get; set; }
        public virtual DbSet<CT_MauXe> CT_MauXe { get; set; }
        public virtual DbSet<CT_PNhap> CT_PNhap { get; set; }
        public virtual DbSet<HangSX> HangSXes { get; set; }
        public virtual DbSet<HopDong> HopDongs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<MauSac> MauSacs { get; set; }
        public virtual DbSet<MauXe> MauXes { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoanLogin> TaiKhoanLogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CT_AnhXe>()
                .Property(e => e.IDMAUXE)
                .IsFixedLength();

            modelBuilder.Entity<CT_AnhXe>()
                .Property(e => e.IDMAU)
                .IsFixedLength();

            modelBuilder.Entity<CT_AnhXe>()
                .HasMany(e => e.CT_MauXe)
                .WithRequired(e => e.CT_AnhXe)
                .HasForeignKey(e => new { e.IDMAUXE, e.IDMAU })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_HOPDONG>()
                .Property(e => e.IDHD)
                .IsFixedLength();

            modelBuilder.Entity<CT_HOPDONG>()
                .Property(e => e.SOKHUNG)
                .IsFixedLength();

            modelBuilder.Entity<CT_HOPDONG>()
                .Property(e => e.IDCTHD)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.SOKHUNG)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.SOMAY)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.IDMAUXE)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.IDPHIEUNHAP)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .Property(e => e.IDMAU)
                .IsFixedLength();

            modelBuilder.Entity<CT_MauXe>()
                .HasMany(e => e.CT_HOPDONG)
                .WithRequired(e => e.CT_MauXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CT_PNhap>()
                .Property(e => e.IDMAUXE)
                .IsFixedLength();

            modelBuilder.Entity<CT_PNhap>()
                .Property(e => e.IDPHIEUNHAP)
                .IsFixedLength();

            modelBuilder.Entity<CT_PNhap>()
                .Property(e => e.TONGGT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HangSX>()
                .Property(e => e.IDHANGSX)
                .IsFixedLength();

            modelBuilder.Entity<HangSX>()
                .HasMany(e => e.MauXes)
                .WithRequired(e => e.HangSX)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HopDong>()
                .Property(e => e.IDHD)
                .IsFixedLength();

            modelBuilder.Entity<HopDong>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<HopDong>()
                .Property(e => e.IDKH)
                .IsFixedLength();

            modelBuilder.Entity<HopDong>()
                .Property(e => e.TONGTT)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HopDong>()
                .HasMany(e => e.CT_HOPDONG)
                .WithRequired(e => e.HopDong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.IDKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HopDongs)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MauSac>()
                .Property(e => e.IDMAU)
                .IsFixedLength();

            modelBuilder.Entity<MauSac>()
                .HasMany(e => e.CT_AnhXe)
                .WithRequired(e => e.MauSac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MauXe>()
                .Property(e => e.IDMAUXE)
                .IsFixedLength();

            modelBuilder.Entity<MauXe>()
                .Property(e => e.GIANHAP)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MauXe>()
                .Property(e => e.GIABAN)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MauXe>()
                .Property(e => e.IDNCC)
                .IsFixedLength();

            modelBuilder.Entity<MauXe>()
                .Property(e => e.IDHANGSX)
                .IsFixedLength();

            modelBuilder.Entity<MauXe>()
                .HasMany(e => e.CT_AnhXe)
                .WithRequired(e => e.MauXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MauXe>()
                .HasMany(e => e.CT_PNhap)
                .WithRequired(e => e.MauXe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.IDNCC)
                .IsFixedLength();

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HopDongs)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.PhieuNhaps)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.IDPHIEUNHAP)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.IDNV)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.IDNCC)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.TONGHOADON)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.CT_MauXe)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.CT_PNhap)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoanLogin>()
                .Property(e => e.MATKHAU)
                .IsFixedLength();

            modelBuilder.Entity<TaiKhoanLogin>()
                .HasMany(e => e.NhanViens)
                .WithRequired(e => e.TaiKhoanLogin)
                .WillCascadeOnDelete(false);
        }
    }
}
