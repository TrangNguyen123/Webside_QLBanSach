namespace Website_BanSach.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class quanlybansach : DbContext
    {
        public quanlybansach()
            : base("name=quanlybansach")
        {
        }

        public virtual DbSet<CHITIET_HD> CHITIET_HD { get; set; }
        public virtual DbSet<DANHMUCSACH> DANHMUCSACHes { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public virtual DbSet<QUYEN> QUYENs { get; set; }
        public virtual DbSet<QUYEN_NGUOIDUNG> QUYEN_NGUOIDUNG { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIET_HD)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.gioitinh)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.sodienthoai)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.taikhoan)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.matkhau)
                .IsFixedLength();

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.CHITIET_HD)
                .WithRequired(e => e.SACH)
                .WillCascadeOnDelete(false);
        }
    }
}
