namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SGU : DbContext
    {
        public SGU()
            : base("name=SGU")
        {
        }

        public virtual DbSet<Baidang> Baidangs { get; set; }
        public virtual DbSet<Chitietchuyentiep> Chitietchuyentieps { get; set; }
        public virtual DbSet<Chitietquyen> Chitietquyens { get; set; }
        public virtual DbSet<Chucvu> Chucvus { get; set; }
        public virtual DbSet<Loaibaidang> Loaibaidangs { get; set; }
        public virtual DbSet<Phanquyen> Phanquyens { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }
        public virtual DbSet<Thongbaochuyentiep> Thongbaochuyentieps { get; set; }
        public virtual DbSet<Thongbaonhan> Thongbaonhans { get; set; }
        public virtual DbSet<Thongtinnguoidung> Thongtinnguoidungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Baidang>()
                .Property(e => e.Mabaidang)
                .IsUnicode(false);

            modelBuilder.Entity<Baidang>()
                .Property(e => e.Maloai)
                .IsUnicode(false);

            modelBuilder.Entity<Baidang>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Baidang>()
                .Property(e => e.Tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Baidang>()
                .Property(e => e.Dinhkem)
                .IsUnicode(false);

            modelBuilder.Entity<Chitietchuyentiep>()
                .Property(e => e.Machuyentiep)
                .IsUnicode(false);

            modelBuilder.Entity<Chitietchuyentiep>()
                .Property(e => e.Taikhoannhan)
                .IsUnicode(false);

            modelBuilder.Entity<Chitietquyen>()
                .Property(e => e.Tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Chitietquyen>()
                .Property(e => e.Maquyen)
                .IsUnicode(false);

            modelBuilder.Entity<Chucvu>()
                .Property(e => e.Machucvu)
                .IsUnicode(false);

            modelBuilder.Entity<Loaibaidang>()
                .Property(e => e.Maloai)
                .IsUnicode(false);

            modelBuilder.Entity<Phanquyen>()
                .Property(e => e.Maquyen)
                .IsUnicode(false);

            modelBuilder.Entity<Phanquyen>()
                .Property(e => e.Tenquyen)
                .IsUnicode(false);

            modelBuilder.Entity<Phanquyen>()
                .HasMany(e => e.Chitietquyens)
                .WithRequired(e => e.Phanquyen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.Tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Taikhoan>()
                .Property(e => e.Tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Taikhoan>()
                .Property(e => e.Machucvu)
                .IsUnicode(false);

            modelBuilder.Entity<Taikhoan>()
                .Property(e => e.Matkhau)
                .IsUnicode(false);

            modelBuilder.Entity<Taikhoan>()
                .HasMany(e => e.Chitietchuyentieps)
                .WithRequired(e => e.Taikhoan)
                .HasForeignKey(e => e.Taikhoannhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taikhoan>()
                .HasMany(e => e.Chitietquyens)
                .WithRequired(e => e.Taikhoan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Taikhoan>()
                .HasMany(e => e.Thongbaochuyentieps)
                .WithOptional(e => e.Taikhoan)
                .HasForeignKey(e => e.Taikhoangui);

            modelBuilder.Entity<Taikhoan>()
                .HasMany(e => e.Thongbaonhans)
                .WithOptional(e => e.Taikhoan)
                .HasForeignKey(e => e.Taikhoangui);

            modelBuilder.Entity<Taikhoan>()
                .HasMany(e => e.Thongbaonhans1)
                .WithOptional(e => e.Taikhoan1)
                .HasForeignKey(e => e.Taikhoannhan);

            modelBuilder.Entity<Thongbaochuyentiep>()
                .Property(e => e.Machuyentiep)
                .IsUnicode(false);

            modelBuilder.Entity<Thongbaochuyentiep>()
                .Property(e => e.Taikhoangui)
                .IsUnicode(false);

            modelBuilder.Entity<Thongbaochuyentiep>()
                .HasMany(e => e.Chitietchuyentieps)
                .WithRequired(e => e.Thongbaochuyentiep)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Thongbaonhan>()
                .Property(e => e.Manhan)
                .IsUnicode(false);

            modelBuilder.Entity<Thongbaonhan>()
                .Property(e => e.Taikhoangui)
                .IsUnicode(false);

            modelBuilder.Entity<Thongbaonhan>()
                .Property(e => e.Taikhoannhan)
                .IsUnicode(false);

            modelBuilder.Entity<Thongtinnguoidung>()
                .Property(e => e.Tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Thongtinnguoidung>()
                .Property(e => e.Diachimail)
                .IsUnicode(false);

            modelBuilder.Entity<Thongtinnguoidung>()
                .Property(e => e.Sodienthoai)
                .IsUnicode(false);
        }
    }
}
