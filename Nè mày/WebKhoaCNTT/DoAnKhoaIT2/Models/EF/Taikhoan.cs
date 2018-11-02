namespace Models.EF
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
            Chitietchuyentieps = new HashSet<Chitietchuyentiep>();
            Chitietquyens = new HashSet<Chitietquyen>();
            NDCongtacSVs = new HashSet<NDCongtacSV>();
            NoidungDTs = new HashSet<NoidungDT>();
            NoidungGioithieux = new HashSet<NoidungGioithieu>();
            Tags = new HashSet<Tag>();
            Thongtinnguoidungs = new HashSet<Thongtinnguoidung>();
        }

        [Key]
        
        [StringLength(100)]
        public string Tentaikhoan { get; set; }

        [StringLength(50)]
        public string Machucvu { get; set; }

        [StringLength(1000)]
        public string Matkhau { get; set; }

        public DateTime? TGdangki { get; set; }

        [StringLength(100)]
        public string Mail { get; set; }

        [StringLength(10)]
        public string Trangthaihd { get; set; }

        public bool? Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietchuyentiep> Chitietchuyentieps { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietquyen> Chitietquyens { get; set; }

        public virtual Chucvu Chucvu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NDCongtacSV> NDCongtacSVs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoidungDT> NoidungDTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoidungGioithieu> NoidungGioithieux { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tag> Tags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thongtinnguoidung> Thongtinnguoidungs { get; set; }
    }
}
