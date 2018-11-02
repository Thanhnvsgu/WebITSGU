namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chitietquyen")]
    public partial class Chitietquyen
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string Tentaikhoan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Maquyen { get; set; }

        public bool? Flag { get; set; }

        public virtual Phanquyen Phanquyen { get; set; }

        public virtual Taikhoan Taikhoan { get; set; }
    }
}
