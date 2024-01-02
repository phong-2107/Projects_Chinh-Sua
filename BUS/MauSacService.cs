using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BUS
{
    public class MauSacService
    {
        public List<MauSac> GetAll()
        {
            Model1 context = new Model1();
            return context.MauSacs.ToList();
        }
        private MauSac findById(string id)
        {
            Model1 context = new Model1();
            var find = context.MauSacs.FirstOrDefault(p => p.IDMAU == id);
            return find;
        }
        public string IDTuDong()
        {
            Model1 context = new Model1();
            var lastRow = context.MauSacs
                    .OrderByDescending(x => x.IDMAU)
                    .FirstOrDefault();
            if (lastRow != null)
            {
                var lastId = lastRow.IDMAU;
                var prefix = lastId.Substring(0, 2);
                var numberStr = lastId.Substring(2);
                int number = int.Parse(numberStr);
                number++;
                var newId = $"{prefix}{number.ToString("D2")}";
                return newId;
            }
            else
            {
                return "MS01";
            }
        }


        public int  ThemMau(string Ma, string ten, string rgb )
        {
            Model1 context = new Model1();
            
            var find = context.MauSacs.FirstOrDefault(p => p.IDMAU == Ma);
            if (find != null)
            {
                find.TENMAU = ten;
                find.MARGB = rgb;
                context.SaveChanges();
                return 0;
            }
            else
            {
                MauSac color = new MauSac();
                color.IDMAU = Ma;
                color.TENMAU = ten;
                color.MARGB = rgb;
                color.ACTIVE = true;
                context.MauSacs.Add(color);
                context.SaveChanges();
                return 1;
            }
        }
    }
}
