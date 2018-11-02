namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Taikhoan")]
    public partial class Taikhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Taikhoan()
        {
            Baidangs = new HashSet<Baidang>();
            Chitietchuyentieps = new HashSet<Chitietchuyentiep>();
            Chitietquyens = new HashSet<Chitietquyen>();
            Tags = new HashSet<Tag>();
            Thongbaochuyentieps = new HashSet<Thongbaochuyentiep>();
            Thongbaonhans = new HashSet<Thongbaonhan>();
            Thongbaonhans1 = new HashSet<Thongbaonhan>();
            Thongtinnguoidungs = new HashSet<Thongtinnguoidung>();
        }

        [Key]
        [StringLength(100)]
        public string Tentaikhoan { get; set; }

        [StringLength(50)]
        public string Machucvu { get; set; }

        [StringLength(100)]
        public string Matkhau { get; set; }

        public bool? Trangthai { get; set; }

        public bool? Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Baidang> Baidangs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietchuyentiep> Chitietchuyentieps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietquyen> Chitietquyens { get; set; }

        public virtual Chucvu Chucvu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thongbaochuyentiep> Thongbaochuyentieps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thongbaonhan> Thongbaonhans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thongbaonhan> Thongbaonhans1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thongtinnguoidung> Thongtinnguoidungs { get; set; }
    }
}
