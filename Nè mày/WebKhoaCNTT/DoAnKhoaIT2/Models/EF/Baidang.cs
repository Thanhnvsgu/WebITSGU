namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Baidang")]
    public partial class Baidang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Baidang()
        {
            Files = new HashSet<File>();
        }

        [Key]
        [StringLength(50)]
        public string Mabaidang { get; set; }

        [StringLength(50)]
        public string TagID { get; set; }

        [StringLength(100)]
        public string Tieude { get; set; }

        public string Noidung { get; set; }

        public DateTime? Ngaydang { get; set; }

        public DateTime? Thoigianhieuluc { get; set; }

        [StringLength(50)]
        public string ĐoituongHT { get; set; }

        public bool? Flag { get; set; }

        public virtual Tag Tag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<File> Files { get; set; }
    }
}
