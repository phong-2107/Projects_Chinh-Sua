namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuNhap")]
    public partial class PhieuNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhap()
        {
            CT_MauXe = new HashSet<CT_MauXe>();
            CT_PNhap = new HashSet<CT_PNhap>();
        }

        [Key]
        [StringLength(10)]
        public string IDPHIEUNHAP { get; set; }

        public DateTime NGAYLAP { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNV { get; set; }

        [StringLength(10)]
        public string IDNCC { get; set; }

        public decimal? TONGHOADON { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_MauXe> CT_MauXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PNhap> CT_PNhap { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
