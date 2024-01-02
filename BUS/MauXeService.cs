using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MauXeService
    {
        public static List<MauXe> listXe = new List<MauXe> ();
        public List<MauXe> GetAll()
        {
            Model1 context = new Model1();
            return context.MauXes.ToList();
        }


        public MauXe findById(string ID)
        {
            Model1 context = new Model1();
            return context.MauXes.FirstOrDefault(p => p.IDMAUXE == ID);
        }
        public void findByName(string name)
        {
            Model1 context = new Model1();
            listXe.Clear();
            listXe = context.MauXes.Where(p => p.TENMAUXE.Contains(name.Trim())).ToList();
        }


        public MauXe getSelected(string id)
        {
            Model1 context = new Model1();
            return context.MauXes.FirstOrDefault(p => p.IDMAUXE.Equals(id.Trim()));
        }
    }
}
