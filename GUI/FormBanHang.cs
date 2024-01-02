using BUS;
using DAL.Entities;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace GUI
{
    public partial class FormBanHang : DevExpress.XtraEditors.XtraForm
    {

        #region #KHAI BAO GIA TRI
        private readonly MauXeService mauXeService = new MauXeService();
        private NhanVien dn = new NhanVien();
        public NhanVien Dn { get => dn; set => dn = value; }
        public KhachHang Kh { get => kh; set => kh = value; }

        private KhachHang kh = new KhachHang();
        
        string pathImage = "";
        #endregion

        #region #MAIN
        public FormBanHang()
        {
            InitializeComponent();
        }
        #endregion

        #region #SU LY LOGIC
        OverlayWindowOptions options = new OverlayWindowOptions(
        backColor: Color.Black,
        opacity: 0.5,
        fadeIn: false,
        fadeOut: false
        );
        IOverlaySplashScreenHandle ShowProgressPanel(Control control, OverlayWindowOptions options)
        {
            return SplashScreenManager.ShowOverlayForm(control, options);
        }


        private void ShowAvatar(string ImageName, GunaPictureBox picMotor)
        {
            try
            {
                if (string.IsNullOrEmpty(ImageName))
                {
                    picMotor.Image = null;
                }
                else
                {
                    string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string imagePath = Path.Combine(parentDirectory, "Images", ImageName);
                    picMotor.Image = Image.FromFile(imagePath);
                    picMotor.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void SaveImage(string path, GunaPictureBox picMotor)
        {
            var folder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string imagePath = Path.Combine(folder, "Images");
            var img = imagePath + @"\" + path;
            picMotor.Image.Save(img, ImageFormat.Png);
        }
        private void loadDetails()
        {
            foreach (MauXe x in MauXeService.listXe)
            {
                searchResultControl res = new searchResultControl();
                res.details(x);
                resultContainer.Controls.Add(res);
            }
        }
        #endregion

        #region #GIAO DIEN
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu.Show(btnMenu, btnMenu.Location.X - 210, btnMenu.Height);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Commons.handle = ShowProgressPanel(this, options);
                FormThemKhachHang ThemHang = new FormThemKhachHang();
                ThemHang.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };

        }
        private void showInforKhachHang(KhachHang kh)
        {
           
            txtMaKH.Text = kh.IDKH.ToString();
            txtTenKh.Text = kh.TENKH.ToString();
            txtSDT.Text = kh.SDT.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Đăng xuất", "Bạn có muốn đăng xuất?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    FormDangNhap home = new FormDangNhap();
                    home.Closed += (s, args) => this.Close();
                    home.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormHome home = new FormHome();
                home.Dn = Dn;
                home.Closed += (s, args) => this.Close();
                home.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion




        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length >= 1)
            {
                resultContainer.Controls.Clear();
                searchResultControl res = new searchResultControl();
                res.searchResult(txtSearch.Text);
                loadDetails();
                resultContainer.Height = resultContainer.Controls.Count * 60;
                pnMainContainer.Height = resultContainer.Controls.Count * 60;
            }
            else
            {
                resultContainer.Height = 0;
            }
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void gunaPanel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(searchResultControl.clicked == true)
            {
                var i = mauXeService.getSelected(searchResultControl.id);
                if(product1.Visible == false)
                {
                    product1.Visible = true;
                    lbId1.Text = i.IDMAUXE;
                    lbName1.Text = i.TENMAUXE;
                    lbSl1.Text = i.SOLUONG.ToString() + " Chiếc";
                    lbGia1.Text = i.GIABAN.ToString() + " VND";
                    resultContainer.Height = 0;
                    searchResultControl.clicked = false;
                }
            }
        }

        private void gunaLabel28_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel13_Click(object sender, EventArgs e)
        {

        }

        private void gunaRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}