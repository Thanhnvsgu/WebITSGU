namespace Models.EF
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
        public virtual DbSet<Bomon> Bomons { get; set; }
        public virtual DbSet<Chitietchuyentiep> Chitietchuyentieps { get; set; }
        public virtual DbSet<ChitietLoaiBaiDang> ChitietLoaiBaiDangs { get; set; }
        public virtual DbSet<Chitietquyen> Chitietquyens { get; set; }
        public virtual DbSet<Chucvu> Chucvus { get; set; }
        public virtual DbSet<CongtacSV> CongtacSVs { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Gioithieu> Gioithieux { get; set; }
        public virtual DbSet<Loaibaidang> Loaibaidangs { get; set; }
        public virtual DbSet<LoaiDaotao> LoaiDaotaos { get; set; }
        public virtual DbSet<Monhoc> Monhocs { get; set; }
        public virtual DbSet<NDCongtacSV> NDCongtacSVs { get; set; }
        public virtual DbSet<NoidungDT> NoidungDTs { get; set; }
        public virtual DbSet<NoidungGioithieu> NoidungGioithieux { get; set; }
        public virtual DbSet<Quyennguoidung> Quyennguoidungs { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<Taikhoan> Taikhoans { get; set; }
        public virtual DbSet<Thongbaochuyentiep> Thongbaochuyentieps { get; set; }
        public virtual DbSet<ThongtinGV> ThongtinGVs { get; set; }
        public virtual DbSet<Thongtinnguoidung> Thongtinnguoidungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Baidang>()
                .Property(e => e.Mabaidang)
                .IsUnicode(false);

            modelBuilder.Entity<Baidang>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Baidang>()
                .Property(e => e.ĐoituongHT)
                .IsUnicode(false);

            modelBuilder.Entity<Bomon>()
                .Property(e => e.MaBM)
                .IsUnicode(false);

            modelBuilder.Entity<Chitietchuyentiep>()
                .Property(e => e.Machuyentiep)
                .IsUnicode(false);

            modelBuilder.Entity<Chitietchuyentiep>()
                .Property(e => e.Taikhoannhan)
                .IsUnicode(false);

            modelBuilder.Entity<ChitietLoaiBaiDang>()
                .Property(e => e.MaCTLoaiBD)
                .IsUnicode(false);

            modelBuilder.Entity<ChitietLoaiBaiDang>()
                .Property(e => e.TagID)
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

            modelBuilder.Entity<CongtacSV>()
                .Property(e => e.MaCTSV)
                .IsUnicode(false);

            modelBuilder.Entity<File>()
                .Property(e => e.Mabaidang)
                .IsUnicode(false);

            modelBuilder.Entity<File>()
                .Property(e => e.MaNDCTSV)
                .IsUnicode(false);

            modelBuilder.Entity<Gioithieu>()
                .Property(e => e.MaGT)
                .IsUnicode(false);

            modelBuilder.Entity<Loaibaidang>()
                .Property(e => e.Maloai)
                .IsUnicode(false);

            modelBuilder.Entity<Loaibaidang>()
                .HasMany(e => e.ChitietLoaiBaiDangs)
                .WithRequired(e => e.Loaibaidang)
                .HasForeignKey(e => e.MaCTLoaiBD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiDaotao>()
                .Property(e => e.MaloaiDT)
                .IsUnicode(false);

            modelBuilder.Entity<Monhoc>()
                .Property(e => e.MaMH)
                .IsUnicode(false);

            modelBuilder.Entity<Monhoc>()
                .Property(e => e.MaBM)
                .IsUnicode(false);

            modelBuilder.Entity<Monhoc>()
                .Property(e => e.MaGV)
                .IsUnicode(false);

            modelBuilder.Entity<NDCongtacSV>()
                .Property(e => e.MaNDCTSV)
                .IsUnicode(false);

            modelBuilder.Entity<NDCongtacSV>()
                .Property(e => e.MaCTSV)
                .IsUnicode(false);

            modelBuilder.Entity<NDCongtacSV>()
                .Property(e => e.Tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NoidungDT>()
                .Property(e => e.MaNDDT)
                .IsUnicode(false);

            modelBuilder.Entity<NoidungDT>()
                .Property(e => e.MaloaiDT)
                .IsUnicode(false);

            modelBuilder.Entity<NoidungDT>()
                .Property(e => e.Tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NoidungGioithieu>()
                .Property(e => e.MaNDGT)
                .IsUnicode(false);

            modelBuilder.Entity<NoidungGioithieu>()
                .Property(e => e.MaGT)
                .IsUnicode(false);

            modelBuilder.Entity<NoidungGioithieu>()
                .Property(e => e.Tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Quyennguoidung>()
                .Property(e => e.Maquyen)
                .IsUnicode(false);

            modelBuilder.Entity<Quyennguoidung>()
                .HasMany(e => e.Chitietquyens)
                .WithRequired(e => e.Quyennguoidung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.TagID)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.Tentaikhoan)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .HasMany(e => e.ChitietLoaiBaiDangs)
                .WithRequired(e => e.Tag)
                .WillCascadeOnDelete(false);

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
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Taikhoan>()
                .Property(e => e.Trangthaihd)
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

            modelBuilder.Entity<ThongtinGV>()
                .Property(e => e.MaGV)
                .IsUnicode(false);

            modelBuilder.Entity<ThongtinGV>()
                .Property(e => e.MaBM)
                .IsUnicode(false);

            modelBuilder.Entity<ThongtinGV>()
                .Property(e => e.Machucvu)
                .IsUnicode(false);

            modelBuilder.Entity<ThongtinGV>()
                .Property(e => e.Diachimail)
                .IsUnicode(false);

            modelBuilder.Entity<ThongtinGV>()
                .HasOptional(e => e.ThongtinGV1)
                .WithRequired(e => e.ThongtinGV2);

            modelBuilder.Entity<Thongtinnguoidung>()
                .Property(e => e.Sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<Thongtinnguoidung>()
                .Property(e => e.Tentaikhoan)
                .IsUnicode(false);
        }
    }
}
