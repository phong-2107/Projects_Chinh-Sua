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
    public partial class FormThemKhachHang : Form
    {
        #region #KHAI BAO GIA TRI
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
    }
}
