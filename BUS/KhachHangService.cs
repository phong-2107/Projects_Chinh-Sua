using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangService
    {
        public List<KhachHang> GetAll()
        {
            Model1 context = new Model1();
            return context.KhachHangs.ToList();
        }
        public List<KhachHang> checkform(KhachHang nv)
        {
            var context = new Model1();
            List<KhachHang> lg = context.KhachHangs.ToList();
            return lg;
        }
        
        public string IDTuDong()
        {
            Model1 context = new Model1();
            var lastRow = context.KhachHangs
                    .OrderByDescending(x => x.IDKH)
                    .FirstOrDefault();
            if (lastRow != null)
            {
                var lastId = lastRow.IDKH;
                var prefix = lastId.Substring(0, 2);
                var numberStr = lastId.Substring(2);
                int number = int.Parse(numberStr);
                number++;
                var newId = $"{prefix}{number.ToString("D8")}";
                return newId;
            }
            else
            {
                return "KH00000001";
            }
        }

        public void ThemKH(string Ma, string ten, string sdt, string Diachi)
        {
            Model1 context = new Model1();
            KhachHang x = new KhachHang();
            x.IDKH = Ma;
            x.TENKH = ten;
            x.SDT = sdt;
            x.DIACHI = Diachi;
            x.ACTIVE = true;
            context.KhachHangs.Add(x);
            context.SaveChanges();
        }
    }
}
