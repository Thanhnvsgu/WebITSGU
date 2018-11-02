namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phanquyen")]
    public partial class Phanquyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phanquyen()
        {
            Chitietquyens = new HashSet<Chitietquyen>();
        }

        [Key]
        [StringLength(50)]
        public string Maquyen { get; set; }

        [StringLength(100)]
        public string Tenquyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chitietquyen> Chitietquyens { get; set; }
    }
}
