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
    public partial class FormTongQuan : Form
    {

        #region #KHAI BAO GIA TRI
        private readonly MauXeService mauXeService = new MauXeService();
        private readonly HopDongService hopDongService = new HopDongService();
        #endregion

        #region #MAIN
        public FormTongQuan()
        {
            InitializeComponent();
        }
        private void FormTongQuan_Load(object sender, EventArgs e)
        {
            BindGridHoaDon(hopDongService.GetAll());
            BindGridXe(mauXeService.GetAll());
        }
        private void FormTongQuan_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width <= 1345)
            {
                lbDoanhthu.Visible = false;
                lbTonkho.Visible = false;
                LbDonHang.Visible = false;
                PriceDT.Location = new Point(20, 56);
            }
            else
            {
                lbDoanhthu.Visible = true;
                lbTonkho.Visible = true;
                LbDonHang.Visible = true;
                PriceDT.Location = new Point(40, 56);
            }
        }
        #endregion

        #region #SU LY LOGIC
        private void BindGridXe(List<MauXe> list)
        {
            dgvMotorcycles.Rows.Clear();
            foreach (var x in list)
            {
                if (x.ACTIVE == true)
                {
                    int index = dgvMotorcycles.Rows.Add();
                    dgvMotorcycles.Rows[index].Cells[0].Value = x.IDMAUXE;
                    dgvMotorcycles.Rows[index].Cells[1].Value = x.TENMAUXE;
                    dgvMotorcycles.Rows[index].Cells[2].Value = x.GIABAN.ToString() + " VND";
                    dgvMotorcycles.Rows[index].Cells[2].Value = x.ANHTQ;
                }
            }
        }
        private void BindGridHoaDon(List<HopDong> list)
        {
            dgvHoaDon.Rows.Clear();
            foreach (var x in list)
            {
                    int index = dgvMotorcycles.Rows.Add();
                    dgvHoaDon.Rows[index].Cells[0].Value = x.IDHD;
                    dgvHoaDon.Rows[index].Cells[1].Value = x.NhanVien.TENNV;
                    dgvHoaDon.Rows[index].Cells[2].Value = x.TONGTT.ToString() + " VND";
                    dgvHoaDon.Rows[index].Cells[2].Value = x.NGAYLAP.ToString("dd/MM/yyyy");
            }
        }

        private void ShowInfoMotor(MauXe xe)
        {
            txt
        }

        #endregion

        #region #GIAO DIEN
        #endregion

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
