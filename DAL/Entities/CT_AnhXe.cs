namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_AnhXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CT_AnhXe()
        {
            CT_MauXe = new HashSet<CT_MauXe>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IDMAUXE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string IDMAU { get; set; }

        public string ANHCT { get; set; }

        public bool ACTIVE { get; set; }

        public virtual MauSac MauSac { get; set; }

        public virtual MauXe MauXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_MauXe> CT_MauXe { get; set; }
    }
}
