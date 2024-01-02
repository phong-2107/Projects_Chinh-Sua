namespace GUI
{
    partial class FormThemNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemNV));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnAddNewTK = new Guna.UI.WinForms.GunaCircleButton();
            this.cmbTk = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.btnNu = new Guna.UI.WinForms.GunaRadioButton();
            this.btnNam = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnBoQua = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnExit = new Guna.UI.WinForms.GunaCircleButton();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btnAddNewTK);
            this.gunaPanel1.Controls.Add(this.cmbTk);
            this.gunaPanel1.Controls.Add(this.gunaLabel10);
            this.gunaPanel1.Controls.Add(this.btnNu);
            this.gunaPanel1.Controls.Add(this.btnNam);
            this.gunaPanel1.Controls.Add(this.gunaLabel9);
            this.gunaPanel1.Controls.Add(this.txtSDT);
            this.gunaPanel1.Controls.Add(this.txtTenNV);
            this.gunaPanel1.Controls.Add(this.txtMaNV);
            this.gunaPanel1.Controls.Add(this.btnSave);
            this.gunaPanel1.Controls.Add(this.btnBoQua);
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Controls.Add(this.btnExit);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(1, 1);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(478, 418);
            this.gunaPanel1.TabIndex = 1;
            // 
            // btnAddNewTK
            // 
            this.btnAddNewTK.AnimationHoverSpeed = 0.07F;
            this.btnAddNewTK.AnimationSpeed = 0.03F;
            this.btnAddNewTK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.btnAddNewTK.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewTK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddNewTK.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddNewTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewTK.ForeColor = System.Drawing.Color.White;
            this.btnAddNewTK.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewTK.Image")));
            this.btnAddNewTK.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddNewTK.Location = new System.Drawing.Point(335, 264);
            this.btnAddNewTK.Name = "btnAddNewTK";
            this.btnAddNewTK.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnAddNewTK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddNewTK.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddNewTK.OnHoverImage = null;
            this.btnAddNewTK.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddNewTK.Size = new System.Drawing.Size(30, 30);
            this.btnAddNewTK.TabIndex = 34;
            // 
            // cmbTk
            // 
            this.cmbTk.BackColor = System.Drawing.Color.Transparent;
            this.cmbTk.BaseColor = System.Drawing.Color.White;
            this.cmbTk.BorderColor = System.Drawing.Color.Silver;
            this.cmbTk.BorderSize = 1;
            this.cmbTk.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTk.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTk.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTk.ForeColor = System.Drawing.Color.DimGray;
            this.cmbTk.FormattingEnabled = true;
            this.cmbTk.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cmbTk.Location = new System.Drawing.Point(157, 266);
            this.cmbTk.MinimumSize = new System.Drawing.Size(161, 0);
            this.cmbTk.Name = "cmbTk";
            this.cmbTk.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbTk.OnHoverItemForeColor = System.Drawing.Color.DimGray;
            this.cmbTk.Radius = 3;
            this.cmbTk.Size = new System.Drawing.Size(161, 26);
            this.cmbTk.TabIndex = 33;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel10.Location = new System.Drawing.Point(42, 270);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(70, 16);
            this.gunaLabel10.TabIndex = 32;
            this.gunaLabel10.Text = "Tài khoản";
            // 
            // btnNu
            // 
            this.btnNu.BaseColor = System.Drawing.SystemColors.Control;
            this.btnNu.CheckedOffColor = System.Drawing.Color.Gray;
            this.btnNu.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(244)))));
            this.btnNu.FillColor = System.Drawing.Color.White;
            this.btnNu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNu.Location = new System.Drawing.Point(228, 229);
            this.btnNu.Name = "btnNu";
            this.btnNu.Size = new System.Drawing.Size(49, 20);
            this.btnNu.TabIndex = 31;
            this.btnNu.Text = "Nữ";
            // 
            // btnNam
            // 
            this.btnNam.BaseColor = System.Drawing.SystemColors.Control;
            this.btnNam.CheckedOffColor = System.Drawing.Color.Gray;
            this.btnNam.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(244)))));
            this.btnNam.FillColor = System.Drawing.Color.White;
            this.btnNam.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNam.Location = new System.Drawing.Point(157, 229);
            this.btnNam.Name = "btnNam";
            this.btnNam.Size = new System.Drawing.Size(59, 20);
            this.btnNam.TabIndex = 30;
            this.btnNam.Text = "Nam";
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel9.Location = new System.Drawing.Point(39, 229);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(62, 16);
            this.gunaLabel9.TabIndex = 29;
            this.gunaLabel9.Text = "Giới tính";
            // 
            // txtSDT
            // 
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(157, 166);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.MaximumSize = new System.Drawing.Size(280, 40);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "+84 xxxx";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(280, 40);
            this.txtSDT.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSDT.TabIndex = 23;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(157, 118);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.MaximumSize = new System.Drawing.Size(280, 40);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(280, 40);
            this.txtTenNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTenNV.TabIndex = 21;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Location = new System.Drawing.Point(157, 70);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNV.MaximumSize = new System.Drawing.Size(280, 40);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMaNV.PlaceholderText = "Mã mặc định";
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.Size = new System.Drawing.Size(280, 40);
            this.txtMaNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMaNV.TabIndex = 20;
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
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(265, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 5;
            this.btnSave.Size = new System.Drawing.Size(90, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnBoQua.Location = new System.Drawing.Point(153, 330);
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
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel4.Location = new System.Drawing.Point(39, 179);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(72, 16);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Điện thoại";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel3.Location = new System.Drawing.Point(39, 132);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(98, 16);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "Tên nhân viên";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gunaLabel2.Location = new System.Drawing.Point(39, 83);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(93, 16);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Mã nhân viên";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(195)))));
            this.gunaLabel1.Location = new System.Drawing.Point(30, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(159, 22);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Thêm nhân viên";
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
            this.btnExit.Location = new System.Drawing.Point(445, 7);
            this.btnExit.Margin = new System.Windows.Forms.Padding(7);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Gainsboro;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(26, 25);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormThemNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThemNV";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhachHang";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton btnBoQua;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaCircleButton btnExit;
        private Guna.UI.WinForms.GunaComboBox cmbTk;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaRadioButton btnNu;
        private Guna.UI.WinForms.GunaRadioButton btnNam;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaCircleButton btnAddNewTK;
    }
}