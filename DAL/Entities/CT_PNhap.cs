namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PNhap
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IDMAUXE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string IDPHIEUNHAP { get; set; }

        public int SOLUONG { get; set; }

        public decimal TONGGT { get; set; }

        public virtual MauXe MauXe { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
