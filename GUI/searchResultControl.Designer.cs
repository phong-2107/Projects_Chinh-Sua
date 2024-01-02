namespace GUI
{
    partial class searchResultControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchResultControl));
            this.lbname = new Guna.UI.WinForms.GunaLabel();
            this.picSP = new System.Windows.Forms.PictureBox();
            this.lbGia = new Guna.UI.WinForms.GunaLabel();
            this.lbPhanKhoi = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(86, 9);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(94, 17);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Tên sản phâm";
            this.lbname.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // picSP
            // 
            this.picSP.Image = ((System.Drawing.Image)(resources.GetObject("picSP.Image")));
            this.picSP.Location = new System.Drawing.Point(3, 5);
            this.picSP.Name = "picSP";
            this.picSP.Size = new System.Drawing.Size(60, 50);
            this.picSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSP.TabIndex = 2;
            this.picSP.TabStop = false;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbGia.Location = new System.Drawing.Point(88, 34);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(53, 17);
            this.lbGia.TabIndex = 3;
            this.lbGia.Text = "Giá bán";
            // 
            // lbPhanKhoi
            // 
            this.lbPhanKhoi.AutoSize = true;
            this.lbPhanKhoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanKhoi.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbPhanKhoi.Location = new System.Drawing.Point(203, 9);
            this.lbPhanKhoi.Name = "lbPhanKhoi";
            this.lbPhanKhoi.Size = new System.Drawing.Size(69, 17);
            this.lbPhanKhoi.TabIndex = 4;
            this.lbPhanKhoi.Text = "Phân khối";
            // 
            // searchResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbPhanKhoi);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.picSP);
            this.Controls.Add(this.lbname);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "searchResultControl";
            this.Size = new System.Drawing.Size(300, 60);
            this.Click += new System.EventHandler(this.searchResultControl_Click);
            this.MouseLeave += new System.EventHandler(this.searchResultControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.searchResultControl_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.picSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lbname;
        private System.Windows.Forms.PictureBox picSP;
        private Guna.UI.WinForms.GunaLabel lbGia;
        private Guna.UI.WinForms.GunaLabel lbPhanKhoi;
    }
}
