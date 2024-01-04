using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NCCService
    {
        Model1 context = new Model1();
        public List<NhaCungCap> GetAll()
        {
            return context.NhaCungCaps.ToList();
        }

        public string FindId(string id)
        {
            var find = context.NhaCungCaps.FirstOrDefault(p => p.TENNCC.Equals(id.Trim()));
            return find.IDNCC.ToString();
        }

        public string findIdByName(string name)
        {
            Model1 context = new Model1();
            var find = context.NhaCungCaps.FirstOrDefault(p => p.TENNCC.Equals(name.Trim()));
            return find.IDNCC;
        }
        public string findNameById(string id)
        {
            Model1 context = new Model1();
            var find = context.NhaCungCaps.FirstOrDefault(p => p.IDNCC.Equals(id.Trim()));
            return find.TENNCC;
        }
        public string IDTuDong()
        {
            Model1 context = new Model1();
            var lastRow = context.NhaCungCaps
                    .OrderByDescending(x => x.IDNCC)
                    .FirstOrDefault();
            if (lastRow != null)
            {
                var lastId = lastRow.IDNCC;
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


        public int ThemNCC(string Ma, string ten)
        {
            Model1 context = new Model1();

            var find = context.NhaCungCaps.FirstOrDefault(p => p.IDNCC == Ma);
            if (find != null)
            {
                find.TENNCC = ten;
                context.SaveChanges();
                return 0;
            }
            else
            {
                NhaCungCap color = new NhaCungCap();
                color.IDNCC = Ma;
                color.TENNCC = ten;
                color.ACTIVE = true;
                context.NhaCungCaps.Add(color);
                context.SaveChanges();
                return 1;
            }
        }
    }
}
