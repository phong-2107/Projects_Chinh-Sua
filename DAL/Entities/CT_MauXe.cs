namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_MauXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_MauXe()
        {
            CT_HOPDONG = new HashSet<CT_HOPDONG>();
        }

        [Key]
        [StringLength(17)]
        public string SOKHUNG { get; set; }

        [Required]
        [StringLength(15)]
        public string SOMAY { get; set; }

        [Required]
        [StringLength(10)]
        public string IDMAUXE { get; set; }

        [Required]
        [StringLength(10)]
        public string IDPHIEUNHAP { get; set; }

        [Required]
        [StringLength(4)]
        public string IDMAU { get; set; }

        public bool ACTIVE { get; set; }

        public virtual CT_AnhXe CT_AnhXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOPDONG> CT_HOPDONG { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
