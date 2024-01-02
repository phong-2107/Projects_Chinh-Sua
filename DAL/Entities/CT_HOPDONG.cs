namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_HOPDONG
    {
        [Required]
        [StringLength(10)]
        public string IDHD { get; set; }

        [Required]
        [StringLength(17)]
        public string SOKHUNG { get; set; }

        [Key]
        [StringLength(10)]
        public string IDCTHD { get; set; }

        public virtual CT_MauXe CT_MauXe { get; set; }

        public virtual HopDong HopDong { get; set; }
    }
}
