namespace GUI
{
    partial class FormNhapThemXe
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapThemXe));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnAddNCC = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.btnBoQua = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.Phieu = new Guna.UI.WinForms.GunaLabel();
            this.btnExit = new Guna.UI.WinForms.GunaCircleButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.cmbNhaCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbLoaiCon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbPhanKhoi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbDate = new Guna.UI.WinForms.GunaLabel();
            this.lbIdPN = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lbNameNV = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.lbNameNV);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.lbIdPN);
            this.gunaPanel1.Controls.Add(this.lbDate);
            this.gunaPanel1.Controls.Add(this.cmbPhanKhoi);
            this.gunaPanel1.Controls.Add(this.cmbLoaiCon);
            this.gunaPanel1.Controls.Add(this.cmbNhaCC);
            this.gunaPanel1.Controls.Add(this.btnAddNCC);
            this.gunaPanel1.Controls.Add(this.gunaLabel11);
            this.gunaPanel1.Controls.Add(this.btnSave);
            this.gunaPanel1.Controls.Add(this.btnBoQua);
            this.gunaPanel1.Controls.Add(this.gunaLabel7);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.Phieu);
            this.gunaPanel1.Controls.Add(this.btnExit);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(900, 500);
            this.gunaPanel1.TabIndex = 3;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // btnAddNCC
            // 
            this.btnAddNCC.AnimationHoverSpeed = 0.07F;
            this.btnAddNCC.AnimationSpeed = 0.03F;
            this.btnAddNCC.BaseColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddNCC.BorderColor = System.Drawing.Color.Black;
            this.btnAddNCC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNCC.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNCC.ForeColor = System.Drawing.Color.White;
            this.btnAddNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNCC.Image")));
            this.btnAddNCC.ImageSize = new System.Drawing.Size(18, 18);
            this.btnAddNCC.Location = new System.Drawing.Point(262, 95);
            this.btnAddNCC.Name = "btnAddNCC";
            this.btnAddNCC.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnAddNCC.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNCC.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNCC.OnHoverImage = null;
            this.btnAddNCC.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNCC.Size = new System.Drawing.Size(30, 30);
            this.btnAddNCC.TabIndex = 37;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoSize = true;
            this.gunaLabel11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel11.Location = new System.Drawing.Point(13, 74);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(94, 16);
            this.gunaLabel11.TabIndex = 35;
            this.gunaLabel11.Text = "Nhà cung cấp";
            // 
            // btnBoQua
            // 
            this.btnBoQua.AnimationHoverSpeed = 0.07F;
            this.btnBoQua.AnimationSpeed = 0.03F;
            this.btnBoQua.BackColor = System.Drawing.Color.Transparent;
            this.btnBoQua.BaseColor = System.Drawing.Color.Transparent;
            this.btnBoQua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(244)))));
            this.btnBoQua.BorderSize = 1;
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBoQua.FocusedColor = System.Drawing.Color.Empty;
            this.btnBoQua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoQua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(244)))));
            this.btnBoQua.Image = null;
            this.btnBoQua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBoQua.Location = new System.Drawing.Point(481, 378);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.OnHoverBaseColor = System.Drawing.Color.WhiteSmoke;
            this.btnBoQua.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.btnBoQua.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.btnBoQua.OnHoverImage = null;
            this.btnBoQua.OnPressedColor = System.Drawing.Color.Black;
            this.btnBoQua.Radius = 5;
            this.btnBoQua.Size = new System.Drawing.Size(90, 35);
            this.btnBoQua.TabIndex = 16;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel7.Location = new System.Drawing.Point(514, 342);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(71, 16);
            this.gunaLabel7.TabIndex = 14;
            this.gunaLabel7.Text = "Phân khối";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel4.Location = new System.Drawing.Point(514, 292);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(62, 16);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Loại côn";
            // 
            // Phieu
            // 
            this.Phieu.AutoSize = true;
            this.Phieu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.Phieu.Location = new System.Drawing.Point(12, 10);
            this.Phieu.Name = "Phieu";
            this.Phieu.Size = new System.Drawing.Size(142, 22);
            this.Phieu.TabIndex = 1;
            this.Phieu.Text = "Phiếu nhập xe";
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.White;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(15, 15);
            this.btnExit.Location = new System.Drawing.Point(867, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(7);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(26, 25);
            this.btnExit.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(244)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(244)))));
            this.btnSave.BorderSize = 1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(596, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 5;
            this.btnSave.Size = new System.Drawing.Size(156, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu & thêm mới";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbNhaCC
            // 
            this.cmbNhaCC.BackColor = System.Drawing.Color.Transparent;
            this.cmbNhaCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNhaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhaCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNhaCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNhaCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNhaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNhaCC.ItemHeight = 30;
            this.cmbNhaCC.Location = new System.Drawing.Point(12, 93);
            this.cmbNhaCC.Name = "cmbNhaCC";
            this.cmbNhaCC.Size = new System.Drawing.Size(244, 36);
            this.cmbNhaCC.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbNhaCC.TabIndex = 38;
            // 
            // cmbLoaiCon
            // 
            this.cmbLoaiCon.BackColor = System.Drawing.Color.Transparent;
            this.cmbLoaiCon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLoaiCon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiCon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiCon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbLoaiCon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbLoaiCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbLoaiCon.ItemHeight = 30;
            this.cmbLoaiCon.Location = new System.Drawing.Point(614, 272);
            this.cmbLoaiCon.Name = "cmbLoaiCon";
            this.cmbLoaiCon.Size = new System.Drawing.Size(244, 36);
            this.cmbLoaiCon.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbLoaiCon.TabIndex = 42;
            // 
            // cmbPhanKhoi
            // 
            this.cmbPhanKhoi.BackColor = System.Drawing.Color.Transparent;
            this.cmbPhanKhoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPhanKhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhanKhoi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPhanKhoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPhanKhoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPhanKhoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPhanKhoi.ItemHeight = 30;
            this.cmbPhanKhoi.Location = new System.Drawing.Point(614, 322);
            this.cmbPhanKhoi.Name = "cmbPhanKhoi";
            this.cmbPhanKhoi.Size = new System.Drawing.Size(244, 36);
            this.cmbPhanKhoi.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbPhanKhoi.TabIndex = 44;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.DimGray;
            this.lbDate.Location = new System.Drawing.Point(672, 12);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(44, 20);
            this.lbDate.TabIndex = 64;
            this.lbDate.Text = "Date:";
            this.lbDate.Click += new System.EventHandler(this.lbDate_Click);
            // 
            // lbIdPN
            // 
            this.lbIdPN.AutoSize = true;
            this.lbIdPN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdPN.ForeColor = System.Drawing.Color.DimGray;
            this.lbIdPN.Location = new System.Drawing.Point(294, 12);
            this.lbIdPN.Name = "lbIdPN";
            this.lbIdPN.Size = new System.Drawing.Size(49, 20);
            this.lbIdPN.TabIndex = 65;
            this.lbIdPN.Text = "MaPN";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel2.Location = new System.Drawing.Point(180, 12);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(108, 20);
            this.gunaLabel2.TabIndex = 66;
            this.gunaLabel2.Text = "Phiếu nhập số: ";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel1.Location = new System.Drawing.Point(400, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(80, 20);
            this.gunaLabel1.TabIndex = 67;
            this.gunaLabel1.Text = "Nhân Viên:";
            // 
            // lbNameNV
            // 
            this.lbNameNV.AutoSize = true;
            this.lbNameNV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameNV.ForeColor = System.Drawing.Color.DimGray;
            this.lbNameNV.Location = new System.Drawing.Point(493, 12);
            this.lbNameNV.Name = "lbNameNV";
            this.lbNameNV.Size = new System.Drawing.Size(66, 20);
            this.lbNameNV.TabIndex = 68;
            this.lbNameNV.Text = "nameNV";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Gray;
            this.gunaLabel3.Location = new System.Drawing.Point(622, 12);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(44, 20);
            this.gunaLabel3.TabIndex = 69;
            this.gunaLabel3.Text = "Date:";
            // 
            // FormNhapThemXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapThemXe";
            this.Text = "FormNhapThemXe";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaCircleButton btnAddNCC;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        private Guna.UI.WinForms.GunaButton btnBoQua;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel Phieu;
        private Guna.UI.WinForms.GunaCircleButton btnExit;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPhanKhoi;
        private Guna.UI2.WinForms.Guna2ComboBox cmbLoaiCon;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNhaCC;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaLabel lbIdPN;
        private Guna.UI.WinForms.GunaLabel lbDate;
        private Guna.UI.WinForms.GunaLabel lbNameNV;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
    }
}