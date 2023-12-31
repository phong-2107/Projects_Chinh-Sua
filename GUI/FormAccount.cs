using DAL.Entities;
using DevExpress.XtraSplashScreen;
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
    public partial class FormAccount : Form
    {

        #region KHAI BÁO GIÁ TRI
        private NhanVien dn = new NhanVien();
        public NhanVien Dn { get => dn; set => dn = value; }
        #endregion

        #region MAIN
        public FormAccount()
        {
            InitializeComponent();
            ShowInfo();
        }
        private void FormAccount_Load(object sender, EventArgs e)
        {
            ShowInfo();
        }
        #endregion

        #region XỬ LÝ LOGIC 
        private void ShowInfo()
        {
            txtID.Text = Dn.IDNV;
            txtName.Text = Dn.TENNV;
            txtPhone.Text = Dn.SDT;
            if(Dn.GIOITINH == false)
            {
                cmbGioiTinh.SelectedIndex = 0;
            }
            else
            {
                cmbGioiTinh.SelectedIndex = 1;
            }
        }
        #endregion

        #region GIAO DIEN
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (pnBaomat.Height <= 80 && pnBaomatLon.Height <= 110)
            {
                pnBaomat.Height = 210;
                pnBaomatLon.Height = 240;
                this.Height = 500;
                btnChinhSua.Text = "Đóng";
                btnChinhSua.Location = new Point(410, 25);
                btnLuu.Visible = true;
                btnLuu.Location = new Point(520, 25);
            }
            else if (pnBaomat.Height >= 210 && pnBaomatLon.Height >= 240)
            {
                pnBaomat.Height = 80;
                pnBaomatLon.Height = 110;
                this.Height = 380;
                btnChinhSua.Text = "Chỉnh sửa";
                btnChinhSua.Location = new Point(500, 25);
                btnLuu.Visible = false;
                btnLuu.Location = new Point(580, 25);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (Commons.handle != null)
            {
                SplashScreenManager.CloseOverlayForm(Commons.handle);
            }
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(Dn.TaiKhoanLogin.MATKHAU != txtPassOld.Text.Trim())
            {
                MessageBox.Show("Mật khẩu sai");
                txtPassOld.BorderColor = Color.Red;
                txtPassOld.Focus();
                txtPassNew.Text = "";
                txtRePassNew.Text = "";
            }
            else
            {
                if(txtPassNew.Text.Trim() == txtRePassNew.Text.Trim())
                {
                    
                }
            }
        }

        #endregion

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        
    }
}
