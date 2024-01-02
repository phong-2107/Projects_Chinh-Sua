using BUS;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class searchResultControl : UserControl
    {
        private readonly MauXeService mauXeService = new MauXeService();
        public searchResultControl()
        {
            InitializeComponent();
        }
        public string tmp;
        public static string id;
        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        public void details(MauXe d)
        {
            lbname.Text = d.TENMAUXE.ToString();
            lbGia.Text = d.GIABAN.ToString() + " VND";
            lbPhanKhoi.Text = d.PHANKHOI.ToString() + " CC";
            tmp = d.IDMAUXE;
        }

        public void searchResult(String key)
        {
            mauXeService.findByName(key);
            /*
                lbname.Text = r.TENMAUXE.ToString();
                lbGia.Text = r.TENMAUXE.ToString() + " VND";
                lbPhanKhoi.Text = r.PHANKHOI.ToString() + " CC";*/
        }

        private void searchResultControl_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
        }

        private void searchResultControl_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        public static bool clicked = false;
        private void searchResultControl_Click(object sender, EventArgs e)
        {
            clicked = true;
            id = tmp;
        }
    }
}
