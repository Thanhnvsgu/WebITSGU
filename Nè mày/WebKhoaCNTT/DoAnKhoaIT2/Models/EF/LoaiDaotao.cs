namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiDaotao")]
    public partial class LoaiDaotao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiDaotao()
        {
            NoidungDTs = new HashSet<NoidungDT>();
        }

        [Key]
        [StringLength(50)]
        public string MaloaiDT { get; set; }

        [StringLength(100)]
        public string Tenloai { get; set; }

        public bool? Flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoidungDT> NoidungDTs { get; set; }
    }
}
