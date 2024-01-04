﻿using BUS;
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
    public partial class FormColors : Form
    {
        private readonly MauSacService mauSacService = new MauSacService();

        public FormColors()
        {
            InitializeComponent();
        }

        private void BindGrid(List<MauSac> list)
        {
            dgvMauSac.Rows.Clear();
            foreach (var x in list)
            {
                if (x.ACTIVE == true)
                {
                    int index = dgvMauSac.Rows.Add();
                    dgvMauSac.Rows[index].Cells[0].Value = x.IDMAU;
                    dgvMauSac.Rows[index].Cells[1].Value = x.TENMAU;
                }

            }
        }

        private void reset()
        {
            txtID.Text = mauSacService.IDTuDong();
            txtTenMau.Text = "";
            txtTenMau.Focus();
        }

        private bool rangbuoc()
        {
            Model1 context = new Model1();
            if (txtID.Text == "" || txtTenMau.Text == "" )
            {
                MessageBox.Show("Ban Can nhap Day Du thong Tin", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            var find = context.MauSacs.FirstOrDefault(p => p.IDMAU == txtID.Text.Trim());
            if (find != null)
            {
                MessageBox.Show("Ma Phieu Nhap Da Co Trong CSDL !!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void FormColors_Load(object sender, EventArgs e)
        {
            BindGrid(mauSacService.GetAll());
            txtID.Text = mauSacService.IDTuDong();
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
                var tmp = mauSacService.ThemMau(txtID.Text.Trim(), txtTenMau.Text.Trim());
                if (tmp == 0)
                {
                    MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("add new color successfully", "Update", MessageBoxButtons.OK);
                }
                BindGrid(mauSacService.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Model1 context = new Model1();
            var find = context.MauSacs.FirstOrDefault(p => p.IDMAU == txtID.Text);
            if (find != null)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Delete", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    find.ACTIVE = false;
                    context.SaveChanges();
                    MessageBox.Show("Deleted successfully", "Delete", MessageBoxButtons.OK);
                    BindGrid(context.MauSacs.ToList());
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
                row = dgvMauSac.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtTenMau.Text = row.Cells[1].Value.ToString();
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
