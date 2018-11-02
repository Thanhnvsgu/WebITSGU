namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gioithieu")]
    public partial class Gioithieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gioithieu()
        {
            NoidungGioithieux = new HashSet<NoidungGioithieu>();
        }

        [Key]
        [StringLength(50)]
        public string MaGT { get; set; }

        [StringLength(100)]
        public string TenGT { get; set; }

        public bool? Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoidungGioithieu> NoidungGioithieux { get; set; }
    }
}
