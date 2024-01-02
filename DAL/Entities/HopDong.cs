namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HopDong")]
    public partial class HopDong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HopDong()
        {
            CT_HOPDONG = new HashSet<CT_HOPDONG>();
        }

        [Key]
        [StringLength(10)]
        public string IDHD { get; set; }

        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNV { get; set; }

        [Required]
        [StringLength(10)]
        public string IDKH { get; set; }

        [StringLength(50)]
        public string NOTE { get; set; }

        [Required]
        [StringLength(20)]
        public string PPTHANHTOAN { get; set; }

        public decimal? TONGTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_HOPDONG> CT_HOPDONG { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
