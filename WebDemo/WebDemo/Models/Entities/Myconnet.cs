namespace WebDemo.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Myconnet : DbContext
    {
        public Myconnet()
            : base("name=Myconnet")
        {
        }

        public virtual DbSet<chitietdonhang> chitietdonhangs { get; set; }
        public virtual DbSet<chudesach> chudesaches { get; set; }
        public virtual DbSet<donhang> donhangs { get; set; }
        public virtual DbSet<khachhang> khachhangs { get; set; }
        public virtual DbSet<nhaxuatban> nhaxuatbans { get; set; }
        public virtual DbSet<sach> saches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tacgia> tacgias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<chitietdonhang>()
                .Property(e => e.madonhang)
                .IsUnicode(false);

            modelBuilder.Entity<chitietdonhang>()
                .Property(e => e.masach)
                .IsUnicode(false);

            modelBuilder.Entity<chitietdonhang>()
                .Property(e => e.dongia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<chudesach>()
                .Property(e => e.machudesach)
                .IsUnicode(false);

            modelBuilder.Entity<donhang>()
                .Property(e => e.madonhang)
                .IsUnicode(false);

            modelBuilder.Entity<donhang>()
                .Property(e => e.makhachhang)
                .IsUnicode(false);

            modelBuilder.Entity<donhang>()
                .HasMany(e => e.chitietdonhangs)
                .WithRequired(e => e.donhang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<khachhang>()
                .Property(e => e.makhachhang)
                .IsUnicode(false);

            modelBuilder.Entity<khachhang>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<khachhang>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<khachhang>()
                .Property(e => e.matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<nhaxuatban>()
                .Property(e => e.manhaxuatban)
                .IsUnicode(false);

            modelBuilder.Entity<sach>()
                .Property(e => e.masach)
                .IsUnicode(false);

            modelBuilder.Entity<sach>()
                .Property(e => e.giaban)
                .HasPrecision(19, 4);

            modelBuilder.Entity<sach>()
                .Property(e => e.kichco)
                .IsUnicode(false);

            modelBuilder.Entity<sach>()
                .Property(e => e.manhaxuatban)
                .IsUnicode(false);

            modelBuilder.Entity<sach>()
                .Property(e => e.machudesach)
                .IsUnicode(false);

            modelBuilder.Entity<sach>()
                .Property(e => e.matacgia)
                .IsUnicode(false);

            modelBuilder.Entity<sach>()
                .HasMany(e => e.chitietdonhangs)
                .WithRequired(e => e.sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tacgia>()
                .Property(e => e.matacgia)
                .IsUnicode(false);

            modelBuilder.Entity<tacgia>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);
        }
    }
}
