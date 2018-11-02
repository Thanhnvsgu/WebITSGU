namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class File
    {
        [Key]
        public int IDfile { get; set; }

        [StringLength(50)]
        public string Mabaidang { get; set; }

        [StringLength(50)]
        public string MaNDCTSV { get; set; }

        [StringLength(10)]
        public string TenFile { get; set; }

        [StringLength(100)]
        public string FilePath { get; set; }

        public bool? Flag { get; set; }

        public virtual Baidang Baidang { get; set; }

        public virtual NDCongtacSV NDCongtacSV { get; set; }
    }
}
