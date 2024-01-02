using BUS;
using DAL.Entities;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class FormThemKhachHang : Form
    {
        #region #KHAI BAO GIA TRI
        private readonly KhachHangService khachHangService = new KhachHangService();
        #endregion

        #region #MAIN
        public FormThemKhachHang()
        {
            InitializeComponent();
        }
        #endregion

        #region #SU LY LOGIC
        #endregion

        #region #GIAO DIEN
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Commons.handle != null)
            {
                SplashScreenManager.CloseOverlayForm(Commons.handle);
            }
            this.Close();
        }




        #endregion

        private void FormThemKhachHang_Load(object sender, EventArgs e)
        {
            txtMaKH.Text = khachHangService.IDTuDong();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                khachHangService.ThemKH(txtMaKH.Text, txtTenKh.Text, txtSDT.Text, txtDiaChi.Text);
                MessageBox.Show("Add successfully");
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
