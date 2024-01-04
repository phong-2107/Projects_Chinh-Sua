using BUS;
using DAL.Entities;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.Html.Internal;
using DevExpress.XtraRichEdit.Painters;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraTreeList;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class FormThemHang : Form
    {
        #region #KHAI BAO GIA TRI
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

        string pathImage = "";
        List<string> paths = new List<string>();

        string pathImageCT = "";
        List<string> pathCTs = new List<string>();

        List<CT_AnhXe> ListCT  = new List<CT_AnhXe>();

        private readonly MauXeService mauXeService = new MauXeService();
        private readonly HangSXService hangSXService = new HangSXService();
        private readonly MauSacService mauSacService = new MauSacService();

        #endregion

        #region #MAIN
        public FormThemHang()
        {
            InitializeComponent();
            if(cmbHangXe.Items.Count == 0)
            {
                FillHangXe(hangSXService.GetAll());
            }
        }
        private void FormThemHang_Load(object sender, EventArgs e)
        {
            txtID.Text = mauXeService.IDTuDong();
            txtTenXe.Focus();
        }
        #endregion

        #region #SU LY LOGIC
        private void ShowImg(string ImageName, GunaPictureBox picMotor)
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

        public void SaveManyImage(List<string> images)
        {
            if(btnAnh1.Image != null && btnAnh2.Image != null && btnAnh3.Image != null)
            {
                SaveImage(images[0], btnAnh1);
                SaveImage(images[1], btnAnh2);
                SaveImage(images[2], btnAnh3);
            }
            else if (btnAnh1.Image == null)
            {
                SaveImage(images[0], btnAnh2);
                SaveImage(images[1], btnAnh3);

            }
            else if (btnAnh2.Image == null)
            {
                SaveImage(images[0], btnAnh1);
                SaveImage(images[1], btnAnh3);
            }
            else if (btnAnh3.Image == null)
            {
                SaveImage(images[0], btnAnh1);
                SaveImage(images[1], btnAnh2);
            }
        }

        private void FillHangXe(List<HangSX> list)
        {
            try
            {
               foreach(HangSX hangSX in list)
               {
                    cmbHangXe.Items.Add(hangSX.TENHSX);
               }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        private void FillColors(List<MauSac> list)
        {
            try
            {
                foreach (MauSac m in list)
                {
                    cmbColors.Items.Add(m.TENMAU);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void showAnhCT(GunaPictureBox btn)
        {
            try
            {
                common2.handle = ShowProgressPanel(this, options);
                ShowImg img = new ShowImg();
                img.Path = btn;
                img.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddAnh(string pathImage)
        {
            if (paths.Count == 0)
            {
                String imageLocation = "";
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "chon hinh anh Xe";
                fileOpen.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                fileOpen.Multiselect = true;
                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    foreach (string path in fileOpen.FileNames)
                    {
                        imageLocation = path;
                        showMultyImg(path);
                        pathImage = imageLocation.Substring(imageLocation.LastIndexOf("\\"));
                        pathImage = pathImage.Remove(0, 1);
                        var time = DateTime.Now.Ticks.ToString();
                        pathImage = time + "-" + pathImage;
                        paths.Add(pathImage);
                    }

                }
            }
            else
            {
                paths.Clear();
                removeImg();
                String imageLocation = "";
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "chon hinh anh Xe";
                fileOpen.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                fileOpen.Multiselect = true;
                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                    foreach (string path in fileOpen.FileNames)
                    {
                        imageLocation = path;
                        showMultyImg(path);
                        pathImage = imageLocation.Substring(imageLocation.LastIndexOf("\\"));
                        pathImage = pathImage.Remove(0, 1);
                        var time = DateTime.Now.Ticks.ToString();
                        pathImage = time + "-" + pathImage;
                        paths.Add(pathImage);
                    }

                }
            }
        }



        private string btnAddAnhCT(string pathImage)
        {
                String imageLocation = "";
                OpenFileDialog fileOpen = new OpenFileDialog();
                fileOpen.Title = "chon hinh anh Xe";
                fileOpen.Filter = "Hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                if (fileOpen.ShowDialog() == DialogResult.OK)
                {
                        imageLocation = fileOpen.FileName;
                        picCTXe.Image = Image.FromFile(fileOpen.FileName);
                        pathImage = imageLocation.Substring(imageLocation.LastIndexOf("\\"));
                        pathImage = pathImage.Remove(0, 1);
                        var time = DateTime.Now.Ticks.ToString();
                        pathImage = time + "-" + pathImage;
                        pathCTs.Add(pathImage);
                }
                return pathImage;
        }

        private void showMultyImg(string path)
        {
            if (btnAnh1.Image == null)
            {
                btnAnh1.Image = Image.FromFile(path);
            }
            else
            {
                if (btnAnh2.Image == null)
                {
                    btnAnh2.Image = Image.FromFile(path);
                }
                else
                {
                    if (btnAnh3.Image == null)
                    {
                        btnAnh3.Image = Image.FromFile(path);
                    }
                    else
                    {
                        btnAnh3.Image = Image.FromFile(path);
                    }
                }
            }
        }

        private void removeImg()
        {
            btnAnh1.Image = null;
            btnAnh2.Image = null;
            btnAnh3.Image = null;
            
        }

        private void resetCT()
        {
            picCTXe.Image = null;
            cmbColors.Text = "";
            cmbColors.Focus();
            pathImageCT = "";
        }

        private bool RangBuocCT()
        {
            if (cmbColors.Text == "" || txtMaXe.Text == "" || picCTXe.Image == null)
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var findcolor= mauSacService.findIdByName(cmbColors.Text);
            var find = ListCT.FirstOrDefault(p => p.IDMAU.Equals(findcolor));
            if (find != null)
            {
                MessageBox.Show("Chi tiết màu này đã có sẵn!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool RangBuoc()
        {
            if (txtTenXe.Text == "" || txtGiaNhap.Text == "" || txtGiaBan.Text == "" || cmbHangXe.Text == "" || cmbLoaiCon.Text == "" || cmbPhanKhoi.Text == "" || cmbNCC.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var isGN = int.TryParse(txtGiaNhap.Text.Trim(), out int n);
            if(isGN == false) {
                MessageBox.Show("Giá nhập phải là số!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaNhap.Focus();
                return false;
            }

            var isGB = int.TryParse(txtGiaBan.Text.Trim(), out int a);
            if (isGB == false)
            {
                MessageBox.Show("Giá bán phải là số!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaBan.Focus();
                return false;
            }
            return true;
        }

        private bool CheckSoAm(Guna2TextBox txt, string n)
        {
            if( n.Equals("-") ) { 
                MessageBox.Show("Giá bán phải là số!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Text = "";
                txt.BorderColor = Color.Red;
                txt.HoverState.BorderColor = Color.Red;
                txt.Focus();
                return false;
            }
            else
            {
                txt.BorderColor = Color.FromArgb(213, 218, 223);
                txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            }
            return true;
        }

        private void BindGrid(List<CT_AnhXe> list)
        {
            dgvCTAnhXe.Rows.Clear();
            foreach (var x in list)
            {
                if (x.ACTIVE == true)
                {
                    int index = dgvCTAnhXe.Rows.Add();
                    dgvCTAnhXe.Rows[index].Cells[0].Value = mauSacService.findNameById(x.IDMAU).ToString();
                    //((DataGridViewImageCell)dgvCTAnhXe.Rows[index].Cells[1]).Value = Image.FromFile(x.ANHCT);
                }

            }
        }
        private void saveCT()
        {
            CT_AnhXe ct = new CT_AnhXe();
            ct.IDMAUXE = txtMaXe.Text;
            ct.IDMAU = mauSacService.findIdByName(cmbColors.Text);
            ct.ANHCT = pathImageCT;
            ct.ACTIVE = true;
            ListCT.Add(ct);
            BindGrid(ListCT);
        }
        private string listToString(List<string> list)
        {
            string[] the_array = paths.Select(i => i.ToString()).ToArray();
            var arr = string.Join(",", the_array);
            return arr;
        }
        #endregion


        /* =============================================================================== GIAO DIEN =========================================================================================*/

        #region #GIAO DIEN
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            
            SplashScreenManager.CloseOverlayForm(Commons.handle);
        }

        private void btnCT_Click(object sender, EventArgs e)
        {
            try
            {
                common2.handle = ShowProgressPanel(this, options);
                FormThemChiTietXe ThemCT = new FormThemChiTietXe();
                ThemCT.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnAnhXe.SendToBack();
        }

        private void btnAddCTAnhXe_Click(object sender, EventArgs e)
        {
            pnAnhXe.BringToFront();
            txtMaXe.Text = txtID.Text;
            if(cmbColors.Items.Count == 0) {
                FillColors(mauSacService.GetAll());
            }
            
        }

        private void btnAnh1_Click(object sender, EventArgs e)
        {
            showAnhCT(btnAnh1);
        }

        private void btnAnh2_Click(object sender, EventArgs e)
        {
            showAnhCT(btnAnh2);
        }
       
        
        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            try
            {
                btnAddAnh(pathImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnh3_Click_1(object sender, EventArgs e)
        {
            showAnhCT(btnAnh3);
        }


        private void btnAddColor_Click(object sender, EventArgs e)
        {
            try
            {
                common2.handle = ShowProgressPanel(this, options);
                FormColors color = new FormColors();
                color.ShowDialog();
                cmbColors.Items.Clear();
                FillColors(mauSacService.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.Close();

            SplashScreenManager.CloseOverlayForm(Commons.handle);
        }
        #endregion

        private void saveImgCT()
        {
            foreach(var i in pathCTs)
            {
                GunaPictureBox btn = new GunaPictureBox();
                btn.Image = Image.FromFile(i);
                SaveImage(i, btn);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (RangBuoc() == false) return;
            Model1 context = new Model1();

            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    MauXe mx = new MauXe();
                    mx.IDMAUXE = txtID.Text;
                    mx.TENMAUXE = txtTenXe.Text;
                    mx.SOLUONG = 0;
                    mx.GIANHAP = double.Parse(txtGiaNhap.Text.Trim().ToString());
                    mx.GIABAN = double.Parse(txtGiaBan.Text.Trim().ToString());
                    mx.IDHANGSX = hangSXService.FindId(cmbHangXe.Text).ToString();
                    mx.LOAICON = cmbLoaiCon.Text.ToString();
                    mx.PHANKHOI = int.Parse(cmbPhanKhoi.Text.Trim().ToString());
                    mx.IDNCC = cmbNCC.Text.ToString();
                    mx.ANHTQ = listToString(paths);
                    mx.ACTIVE = true;
                    SaveManyImage(paths);
                    context.MauXes.Add(mx);
                    context.SaveChanges();
                    MessageBox.Show("Thêm mẫu xe thành công!!", "Create Motor", MessageBoxButtons.OK);

                    if(ListCT.Count > 0)
                    {
                        foreach(var s in ListCT)
                        {
                            context.CT_AnhXe.Add(s);
                            context.SaveChanges();
                        }
                        saveImgCT();
                        MessageBox.Show("CT Thanh Cong!!", "Create Motor", MessageBoxButtons.OK);
                    }
                    transaction.Commit();
                    MessageBox.Show("Update thành công!!", "Create Motor", MessageBoxButtons.OK);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }
        
        

        private void btnSaveCT_Click(object sender, EventArgs e)
        {
            if (RangBuocCT() == false) return;
            saveCT();
            resetCT();
        }

        private void picCTXe_Click(object sender, EventArgs e)
        {
            pathImageCT = btnAddAnhCT(pathImageCT);
            MessageBox.Show(pathImageCT);
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            if (CheckSoAm(txtGiaNhap, txtGiaNhap.Text) == false) return;
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            if (CheckSoAm(txtGiaBan, txtGiaBan.Text) == false) return;
        }
    }
}
