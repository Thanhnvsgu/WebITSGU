namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChitietLoaiBaiDang")]
    public partial class ChitietLoaiBaiDang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MaCTLoaiBD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TagID { get; set; }

        public bool? Flag { get; set; }

        public virtual Loaibaidang Loaibaidang { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
