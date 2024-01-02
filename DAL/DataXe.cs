using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataXe
    {
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

        public decimal GIANHAP { get; set; }

        public decimal GIABAN { get; set; }

        public int SOLUONG { get; set; }

        public string ANHTQ { get; set; }

        [Required]
        [StringLength(10)]
        public string IDNCC { get; set; }

        [Required]
        [StringLength(10)]
        public string IDHANGSX { get; set; }

        public bool ACTIVE { get; set; }



    }
}
