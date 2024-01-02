using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhapService
    {
        public List<PhieuNhap> GetAll()
        {
            Model1 context = new Model1();
            return context.PhieuNhaps.ToList();
        }
        private PhieuNhap findById(string id)
        {
            Model1 context = new Model1();
            var find = context.PhieuNhaps.FirstOrDefault(p => p.IDPHIEUNHAP == id);
            return find;
        }
        public string IDTuDong()
        {
            Model1 context = new Model1();
            var lastRow = context.PhieuNhaps
                    .OrderByDescending(x => x.IDPHIEUNHAP)
                    .FirstOrDefault();
            if (lastRow != null)
            {
                var lastId = lastRow.IDPHIEUNHAP;
                var prefix = lastId.Substring(0, 2);
                var numberStr = lastId.Substring(2);
                int number = int.Parse(numberStr);
                number++;
                var newId = $"{prefix}{number.ToString("D8")}";
                return newId;
            }
            else
            {
                return "PN00000001";
            }
        }
    }
}
