namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chucvu")]
    public partial class Chucvu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chucvu()
        {
            Taikhoans = new HashSet<Taikhoan>();
        }

        [Key]
        [StringLength(50)]
        public string Machucvu { get; set; }

        [StringLength(100)]
        public string Tenchucvu { get; set; }

        public bool? Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taikhoan> Taikhoans { get; set; }
    }
}
