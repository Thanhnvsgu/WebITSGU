namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Baidang")]
    public partial class Baidang
    {
        [Key]
        [StringLength(50)]
        public string Mabaidang { get; set; }

        [StringLength(50)]
        public string Maloai { get; set; }

        [StringLength(50)]
        public string TagID { get; set; }

        [StringLength(100)]
        public string Tentaikhoan { get; set; }

        [StringLength(100)]
        public string Tieude { get; set; }

        [StringLength(500)]
        public string Noidung { get; set; }

        public DateTime? Ngaydang { get; set; }

        public DateTime? Thoigianhieuluc { get; set; }

        [StringLength(200)]
        public string Dinhkem { get; set; }

        public bool? Trangthai { get; set; }

        public bool? Flag { get; set; }

        public virtual Loaibaidang Loaibaidang { get; set; }

        public virtual Tag Tag { get; set; }

        public virtual Taikhoan Taikhoan { get; set; }
    }
}
