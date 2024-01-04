using DevExpress.XtraSplashScreen;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
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
    public partial class ShowImg : Form
    {
        public ShowImg()
        {
            InitializeComponent();
        }
        private GunaPictureBox path;

        public GunaPictureBox Path { get => path; set => path = value; }

        private void ShowImg_Load(object sender, EventArgs e)
        {
            picImg.Image = Path.Image;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (common2.handle != null)
            {
                SplashScreenManager.CloseOverlayForm(common2.handle);
            }
            this.Close();
        }

        private void picImg_Click(object sender, EventArgs e)
        {

        }
    }
}
