namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thongbaochuyentiep")]
    public partial class Thongbaochuyentiep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thongbaochuyentiep()
        {
            Chitietchuyentieps = new HashSet<Chitietchuyentiep>();
        }

        [Key]
        [StringLength(50)]
        public string Machuyentiep { get; set; }

        [StringLength(100)]
        public string Tieude { get; set; }

        [StringLength(500)]
        public string Noidung { get; set; }

        [StringLength(100)]
        public string Taikhoangui { get; set; }

        public DateTime? Ngaychuyen { get; set; }

        [StringLength(50)]
        public string Trangthaichuyen { get; set; }

        public bool? Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietchuyentiep> Chitietchuyentieps { get; set; }

        public virtual Taikhoan Taikhoan { get; set; }
    }
}
