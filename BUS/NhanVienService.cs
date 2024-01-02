using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienService
    {

        public List<NhanVien> GetAll()
        {
            Model1 context = new Model1();
            return context.NhanViens.ToList();
        }
        public List<NhanVien> checkform(NhanVien nv)
        {
            var context = new Model1();
            List<NhanVien> lg = context.NhanViens.ToList();
            return lg;
        }
        public string IDTuDong()
        {
            Model1 context = new Model1();
            var lastRow = context.NhanViens
                    .OrderByDescending(x => x.IDNV)
                    .FirstOrDefault();
            if (lastRow != null)
            {
                var lastId = lastRow.IDNV;
                var prefix = lastId.Substring(0, 2);
                var numberStr = lastId.Substring(2);
                int number = int.Parse(numberStr);
                number++;
                var newId = $"{prefix}{number.ToString("D8")}";
                return newId;
            }
            else
            {
                return "NV00000001";
            }
        }
    }
}
