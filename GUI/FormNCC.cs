using BUS;
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
    public partial class FormNCC : Form
    {
        public FormNCC()
        {
            InitializeComponent();
        }
        private readonly NCCService nCCService = new NCCService();


        private void BindGrid(List<NhaCungCap> list)
        {
            dgvNCC.Rows.Clear();
            foreach (var x in list)
            {
                if (x.ACTIVE == true)
                {
                    int index = dgvNCC.Rows.Add();
                    dgvNCC.Rows[index].Cells[0].Value = x.IDNCC;
                    dgvNCC.Rows[index].Cells[1].Value = x.TENNCC;
                }

            }
        }

        private void reset()
        {
            txtID.Text = nCCService.IDTuDong();
            txtTenNCC.Text = "";
            txtTenNCC.Focus();
        }

        private bool rangbuoc()
        {
            Model1 context = new Model1();
            if (txtID.Text == "" || txtTenNCC.Text == "")
            {
                MessageBox.Show("Ban Can nhap Day Du thong Tin", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var find = context.NhaCungCaps.FirstOrDefault(p => p.IDNCC == txtID.Text.Trim());
            if (find != null)
            {
                MessageBox.Show("Ma Phieu Nhap Da Co Trong CSDL !!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void FormNCC_Load(object sender, EventArgs e)
        {
            BindGrid(nCCService.GetAll());
            txtID.Text = nCCService.IDTuDong();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (common2.handle != null)
            {
                SplashScreenManager.CloseOverlayForm(common2.handle);
            }
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (rangbuoc() == false) return;
                var tmp = nCCService.ThemNCC(txtID.Text.Trim(), txtTenNCC.Text.Trim());
                if (tmp == 0)
                {
                    MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("add new color successfully", "Update", MessageBoxButtons.OK);
                }
                BindGrid(nCCService.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var find = context.NhaCungCaps.FirstOrDefault(p => p.IDNCC == txtID.Text);
            if (find != null)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    find.ACTIVE = false;
                    context.SaveChanges();
                    MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK);
                    BindGrid(context.NhaCungCaps.ToList());
                }
            }
            else
            {
                MessageBox.Show("Not Found!!", "Delete", MessageBoxButtons.OK);
            }
        }

        private void dgvMauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNCC.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTenNCC.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
