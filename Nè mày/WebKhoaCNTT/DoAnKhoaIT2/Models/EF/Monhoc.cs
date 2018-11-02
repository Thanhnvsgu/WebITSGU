namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Monhoc")]
    public partial class Monhoc
    {
        [Key]
        [StringLength(50)]
        public string MaMH { get; set; }

        [StringLength(50)]
        public string MaBM { get; set; }

        [StringLength(100)]
        public string TenMH { get; set; }

        [StringLength(50)]
        public string MaGV { get; set; }

        public virtual Bomon Bomon { get; set; }
    }
}
