using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HopDongService
    {
        Model1 context = new Model1();
        public List<HopDong> GetAll()
        {
            return context.HopDongs.ToList();
        }
    }
}
