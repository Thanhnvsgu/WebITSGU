namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thongbaonhan")]
    public partial class Thongbaonhan
    {
        [Key]
        [StringLength(50)]
        public string Manhan { get; set; }

        [StringLength(100)]
        public string Taikhoangui { get; set; }

        [StringLength(100)]
        public string Taikhoannhan { get; set; }

        [StringLength(100)]
        public string Tieude { get; set; }

        [StringLength(500)]
        public string Noidung { get; set; }

        public DateTime? Ngaychuyen { get; set; }

        [StringLength(20)]
        public string Trangthaixem { get; set; }

        [StringLength(20)]
        public string Hinhthucchuyen { get; set; }

        public bool? Flag { get; set; }

        public virtual Taikhoan Taikhoan { get; set; }

        public virtual Taikhoan Taikhoan1 { get; set; }
    }
}
