namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Thongtinnguoidung")]
    public partial class Thongtinnguoidung
    {
        [Key]
        public int STT { get; set; }

        [StringLength(100)]
        public string Tentaikhoan { get; set; }

        [StringLength(100)]
        public string Hoten { get; set; }

        public DateTime? Namsinh { get; set; }

        [StringLength(100)]
        public string Diachimail { get; set; }

        [StringLength(15)]
        public string Sodienthoai { get; set; }

        [StringLength(100)]
        public string Quequan { get; set; }

        public bool? Flag { get; set; }

        public virtual Taikhoan Taikhoan { get; set; }
    }
}
