using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HangSXService
    {
        Model1 context = new Model1();
        public List<HangSX> GetAll()
        {
            return context.HangSXes.ToList();
        }

        public string FindId(string id)
        {
            var find = context.HangSXes.FirstOrDefault(p => p.TENHSX.Equals(id.Trim()));
            return find.IDHANGSX.ToString();
        }

        public string findIdByName(string name)
        {
            Model1 context = new Model1();
            var find = context.HangSXes.FirstOrDefault(p => p.TENHSX.Equals(name.Trim()));
            return find.IDHANGSX;
        }
        public string findNameById(string id)
        {
            Model1 context = new Model1();
            var find = context.HangSXes.FirstOrDefault(p => p.IDHANGSX.Equals(id.Trim()));
            return find.TENHSX;
        }
        public string IDTuDong()
        {
            Model1 context = new Model1();
            var lastRow = context.HangSXes
                    .OrderByDescending(x => x.IDHANGSX)
                    .FirstOrDefault();
            if (lastRow != null)
            {
                var lastId = lastRow.IDHANGSX;
                var prefix = lastId.Substring(0, 3);
                var numberStr = lastId.Substring(3);
                int number = int.Parse(numberStr);
                number++;
                var newId = $"{prefix}{number.ToString("D7")}";
                return newId;
            }
            else
            {
                return "HSX0000001";
            }
        }


        public int ThemHang(string Ma, string ten)
        {
            Model1 context = new Model1();

            var find = context.HangSXes.FirstOrDefault(p => p.IDHANGSX == Ma);
            if (find != null)
            {
                find.TENHSX = ten;
                context.SaveChanges();
                return 0;
            }
            else
            {
                HangSX color = new HangSX();
                color.IDHANGSX = Ma;
                color.TENHSX = ten;
                color.ACTIVE = true;
                context.HangSXes.Add(color);
                context.SaveChanges();
                return 1;
            }
        }
    }
}
