namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tag")]
    public partial class Tag
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tag()
        {
            Baidangs = new HashSet<Baidang>();
        }

        [StringLength(50)]
        public string TagID { get; set; }

        [StringLength(50)]
        public string TenTag { get; set; }

        [StringLength(100)]
        public string Tentaikhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Baidang> Baidangs { get; set; }

        public virtual Taikhoan Taikhoan { get; set; }
    }
}
