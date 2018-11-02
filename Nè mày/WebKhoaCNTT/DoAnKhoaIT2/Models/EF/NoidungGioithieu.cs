namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NoidungGioithieu")]
    public partial class NoidungGioithieu
    {
        [Key]
        [StringLength(50)]
        public string MaNDGT { get; set; }

        [StringLength(50)]
        public string MaGT { get; set; }

        [StringLength(100)]
        public string Tentaikhoan { get; set; }

        [StringLength(100)]
        public string Tieude { get; set; }

        public string NoidungGT { get; set; }

        public DateTime? Ngaydang { get; set; }

        public bool? Flag { get; set; }

        public virtual Gioithieu Gioithieu { get; set; }

        public virtual Taikhoan Taikhoan { get; set; }
    }
}
