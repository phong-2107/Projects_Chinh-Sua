using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MauXeService
    {
        public static List<MauXe> listXe = new List<MauXe> ();
        Model1 context = new Model1 ();
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

        public List<MauXe> getHangconhang(string hang)
        {
            var list = GetAll();
            List<MauXe> lmx = new List<MauXe>();
            foreach(MauXe mx in list) 
            {
                if(mx.HangSX.TENHSX.Equals(hang) && mx.SOLUONG >0)
                    lmx.Add(mx);
            }
            return lmx;
        }
        public List<MauXe> tonkho()
        {
            var list = GetAll();
            List<MauXe> lmx = new List<MauXe>();
            foreach( MauXe mx in list)
            {
                if (mx.SOLUONG > 0)
                    lmx.Add(mx);
            }
            return lmx;
        }
        public List<MauXe> getHanghethang(string hang)
        {
            var list = GetAll();
            List<MauXe> lmx = new List<MauXe>();
            foreach (MauXe mx in list)
            {
                if (mx.HangSX.TENHSX.Equals(hang) && mx.SOLUONG ==0)
                    lmx.Add(mx);
            }
            return lmx;
        }
        public List<MauXe> getHang(string hang)
        {
            var list = GetAll();
            List<MauXe> lmx = new List<MauXe>();
            foreach (MauXe mx in list)
            {
                if (mx.HangSX.TENHSX.Equals(hang))
                    lmx.Add(mx);
            }
            return lmx;
        }
    }
}
