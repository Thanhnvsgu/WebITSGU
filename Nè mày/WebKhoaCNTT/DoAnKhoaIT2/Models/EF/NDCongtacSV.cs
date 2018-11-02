namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NDCongtacSV")]
    public partial class NDCongtacSV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NDCongtacSV()
        {
            Files = new HashSet<File>();
        }

        [Key]
        [StringLength(50)]
        public string MaNDCTSV { get; set; }

        [StringLength(50)]
        public string MaCTSV { get; set; }

        [StringLength(100)]
        public string Tentaikhoan { get; set; }

        [StringLength(100)]
        public string Tieude { get; set; }

        public string NoidungCTSV { get; set; }

        public DateTime? Ngaydang { get; set; }

        public bool? flag { get; set; }

        public virtual CongtacSV CongtacSV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<File> Files { get; set; }

        public virtual Taikhoan Taikhoan { get; set; }
    }
}
