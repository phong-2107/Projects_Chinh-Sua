namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MauXe")]
    public partial class MauXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MauXe()
        {
            CT_AnhXe = new HashSet<CT_AnhXe>();
            CT_PNhap = new HashSet<CT_PNhap>();
        }

        [Key]
        [StringLength(10)]
        public string IDMAUXE { get; set; }

        [Required]
        [StringLength(50)]
        public string TENMAUXE { get; set; }

        public int PHANKHOI { get; set; }

        [Required]
        [StringLength(20)]
        public string LOAICON { get; set; }

        public double GIANHAP { get; set; }

        public double GIABAN { get; set; }

        public int SOLUONG { get; set; }

        public string ANHTQ { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNCC { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHANGSX { get; set; }

        public bool ACTIVE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_AnhXe> CT_AnhXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PNhap> CT_PNhap { get; set; }

        public virtual HangSX HangSX { get; set; }
    }
}
