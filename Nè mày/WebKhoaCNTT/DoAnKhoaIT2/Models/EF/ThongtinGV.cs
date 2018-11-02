namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongtinGV")]
    public partial class ThongtinGV
    {
        [Key]
        [StringLength(50)]
        public string MaGV { get; set; }

        [StringLength(50)]
        public string MaBM { get; set; }

        [StringLength(50)]
        public string Machucvu { get; set; }

        [StringLength(100)]
        public string TenGV { get; set; }

        [StringLength(100)]
        public string Diachimail { get; set; }

        public bool? Flag { get; set; }

        public virtual Bomon Bomon { get; set; }

        public virtual ThongtinGV ThongtinGV1 { get; set; }

        public virtual ThongtinGV ThongtinGV2 { get; set; }
    }
}
