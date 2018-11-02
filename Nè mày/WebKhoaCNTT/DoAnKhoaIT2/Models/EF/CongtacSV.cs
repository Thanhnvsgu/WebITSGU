namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CongtacSV")]
    public partial class CongtacSV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongtacSV()
        {
            NDCongtacSVs = new HashSet<NDCongtacSV>();
        }

        [Key]
        [StringLength(50)]
        public string MaCTSV { get; set; }

        [StringLength(100)]
        public string TenCTSV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NDCongtacSV> NDCongtacSVs { get; set; }
    }
}
