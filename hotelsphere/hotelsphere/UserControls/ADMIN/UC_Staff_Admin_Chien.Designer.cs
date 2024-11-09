namespace hotelsphere.UserControls.ADMIN
{
    partial class UC_Staff_Admin_Chien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTim = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoa_Chien = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd_Chien = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit_Chien = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabStaff_Chien = new MetroFramework.Controls.MetroTabControl();
            this.tabDanhSach = new MetroFramework.Controls.MetroTabPage();
            this.dgvStaff_Chien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabChucNang = new MetroFramework.Controls.MetroTabPage();
            this.cbVaiTro_Chien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpNgaySinh_Chien = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.rdBoy_Chien = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdGirl_Chien = new Guna.UI2.WinForms.Guna2RadioButton();
            this.btnCancel_Chien = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave_Chien = new Guna.UI2.WinForms.Guna2Button();
            this.MatKhau_Chien = new Guna.UI2.WinForms.Guna2TextBox();
            this.HoTen_Chien = new Guna.UI2.WinForms.Guna2TextBox();
            this.TaiKhoan_Chien = new Guna.UI2.WinForms.Guna2TextBox();
            this.IdStaff_Chien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabStaff_Chien.SuspendLayout();
            this.tabDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff_Chien)).BeginInit();
            this.tabChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Controls.Add(this.btnXoa_Chien);
            this.panel1.Controls.Add(this.btnAdd_Chien);
            this.panel1.Controls.Add(this.btnEdit_Chien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 64);
            this.panel1.TabIndex = 5;
            // 
            // txtTim
            // 
            this.txtTim.AutoRoundedCorners = true;
            this.txtTim.BorderRadius = 17;
            this.txtTim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim.DefaultText = "";
            this.txtTim.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTim.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim.Location = new System.Drawing.Point(4, 14);
            this.txtTim.Name = "txtTim";
            this.txtTim.PasswordChar = '\0';
            this.txtTim.PlaceholderText = "Nhập mã hoặc tên nhân viên...";
            this.txtTim.SelectedText = "";
            this.txtTim.Size = new System.Drawing.Size(489, 36);
            this.txtTim.TabIndex = 1;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btnXoa_Chien
            // 
            this.btnXoa_Chien.AutoRoundedCorners = true;
            this.btnXoa_Chien.BorderRadius = 17;
            this.btnXoa_Chien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa_Chien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa_Chien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_Chien.ForeColor = System.Drawing.Color.White;
            this.btnXoa_Chien.Location = new System.Drawing.Point(668, 14);
            this.btnXoa_Chien.Name = "btnXoa_Chien";
            this.btnXoa_Chien.Size = new System.Drawing.Size(60, 36);
            this.btnXoa_Chien.TabIndex = 2;
            this.btnXoa_Chien.Text = "Xoá";
            this.btnXoa_Chien.Click += new System.EventHandler(this.btnXoa_Chien_Click);
            // 
            // btnAdd_Chien
            // 
            this.btnAdd_Chien.AutoRoundedCorners = true;
            this.btnAdd_Chien.BorderRadius = 17;
            this.btnAdd_Chien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Chien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_Chien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Chien.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Chien.Location = new System.Drawing.Point(499, 15);
            this.btnAdd_Chien.Name = "btnAdd_Chien";
            this.btnAdd_Chien.Size = new System.Drawing.Size(77, 36);
            this.btnAdd_Chien.TabIndex = 2;
            this.btnAdd_Chien.Text = "Thêm";
            this.btnAdd_Chien.Click += new System.EventHandler(this.btnAdd_Chien_Click);
            // 
            // btnEdit_Chien
            // 
            this.btnEdit_Chien.AutoRoundedCorners = true;
            this.btnEdit_Chien.BorderRadius = 17;
            this.btnEdit_Chien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit_Chien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit_Chien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_Chien.ForeColor = System.Drawing.Color.White;
            this.btnEdit_Chien.Location = new System.Drawing.Point(582, 15);
            this.btnEdit_Chien.Name = "btnEdit_Chien";
            this.btnEdit_Chien.Size = new System.Drawing.Size(80, 36);
            this.btnEdit_Chien.TabIndex = 2;
            this.btnEdit_Chien.Text = "Sửa";
            this.btnEdit_Chien.Click += new System.EventHandler(this.btnEdit_Chien_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabStaff_Chien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 446);
            this.panel2.TabIndex = 6;
            // 
            // tabStaff_Chien
            // 
            this.tabStaff_Chien.Controls.Add(this.tabDanhSach);
            this.tabStaff_Chien.Controls.Add(this.tabChucNang);
            this.tabStaff_Chien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabStaff_Chien.Location = new System.Drawing.Point(0, 0);
            this.tabStaff_Chien.Name = "tabStaff_Chien";
            this.tabStaff_Chien.SelectedIndex = 1;
            this.tabStaff_Chien.Size = new System.Drawing.Size(1034, 446);
            this.tabStaff_Chien.TabIndex = 0;
            this.tabStaff_Chien.UseSelectable = true;
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Controls.Add(this.dgvStaff_Chien);
            this.tabDanhSach.HorizontalScrollbarBarColor = true;
            this.tabDanhSach.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDanhSach.HorizontalScrollbarSize = 10;
            this.tabDanhSach.Location = new System.Drawing.Point(4, 38);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.Size = new System.Drawing.Size(1026, 404);
            this.tabDanhSach.TabIndex = 0;
            this.tabDanhSach.Text = "DANH SÁCH";
            this.tabDanhSach.VerticalScrollbarBarColor = true;
            this.tabDanhSach.VerticalScrollbarHighlightOnWheel = false;
            this.tabDanhSach.VerticalScrollbarSize = 10;
            // 
            // dgvStaff_Chien
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvStaff_Chien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff_Chien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStaff_Chien.ColumnHeadersHeight = 60;
            this.dgvStaff_Chien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStaff_Chien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff_Chien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStaff_Chien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStaff_Chien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvStaff_Chien.Location = new System.Drawing.Point(0, 0);
            this.dgvStaff_Chien.Name = "dgvStaff_Chien";
            this.dgvStaff_Chien.ReadOnly = true;
            this.dgvStaff_Chien.RowHeadersVisible = false;
            this.dgvStaff_Chien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaff_Chien.RowTemplate.Height = 41;
            this.dgvStaff_Chien.Size = new System.Drawing.Size(1026, 388);
            this.dgvStaff_Chien.TabIndex = 2;
            this.dgvStaff_Chien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvStaff_Chien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvStaff_Chien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStaff_Chien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStaff_Chien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStaff_Chien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStaff_Chien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStaff_Chien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvStaff_Chien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvStaff_Chien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStaff_Chien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaff_Chien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStaff_Chien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStaff_Chien.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvStaff_Chien.ThemeStyle.ReadOnly = true;
            this.dgvStaff_Chien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvStaff_Chien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStaff_Chien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStaff_Chien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvStaff_Chien.ThemeStyle.RowsStyle.Height = 41;
            this.dgvStaff_Chien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvStaff_Chien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvStaff_Chien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_Chien_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_staff";
            this.Column1.HeaderText = "ID STAFF";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "taikhoan";
            this.Column2.HeaderText = "TÀI KHOẢN";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "hoten";
            this.Column3.HeaderText = "HỌ TÊN";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngaysinh";
            this.Column4.HeaderText = "NGÀY SINH";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "gioitinh";
            this.Column5.HeaderText = "GIỚI TÍNH";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "matkhau";
            this.Column6.HeaderText = "MẬT KHẨU";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "role";
            this.Column7.HeaderText = "VAI TRÒ";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // tabChucNang
            // 
            this.tabChucNang.Controls.Add(this.cbVaiTro_Chien);
            this.tabChucNang.Controls.Add(this.dtpNgaySinh_Chien);
            this.tabChucNang.Controls.Add(this.rdBoy_Chien);
            this.tabChucNang.Controls.Add(this.rdGirl_Chien);
            this.tabChucNang.Controls.Add(this.btnCancel_Chien);
            this.tabChucNang.Controls.Add(this.btnSave_Chien);
            this.tabChucNang.Controls.Add(this.MatKhau_Chien);
            this.tabChucNang.Controls.Add(this.HoTen_Chien);
            this.tabChucNang.Controls.Add(this.TaiKhoan_Chien);
            this.tabChucNang.Controls.Add(this.IdStaff_Chien);
            this.tabChucNang.Controls.Add(this.label4);
            this.tabChucNang.Controls.Add(this.label7);
            this.tabChucNang.Controls.Add(this.label3);
            this.tabChucNang.Controls.Add(this.label6);
            this.tabChucNang.Controls.Add(this.label2);
            this.tabChucNang.Controls.Add(this.label5);
            this.tabChucNang.Controls.Add(this.label1);
            this.tabChucNang.HorizontalScrollbarBarColor = true;
            this.tabChucNang.HorizontalScrollbarHighlightOnWheel = false;
            this.tabChucNang.HorizontalScrollbarSize = 10;
            this.tabChucNang.Location = new System.Drawing.Point(4, 38);
            this.tabChucNang.Name = "tabChucNang";
            this.tabChucNang.Size = new System.Drawing.Size(1026, 404);
            this.tabChucNang.TabIndex = 1;
            this.tabChucNang.Text = "CHỨC NĂNG";
            this.tabChucNang.VerticalScrollbarBarColor = true;
            this.tabChucNang.VerticalScrollbarHighlightOnWheel = false;
            this.tabChucNang.VerticalScrollbarSize = 10;
            // 
            // cbVaiTro_Chien
            // 
            this.cbVaiTro_Chien.AutoRoundedCorners = true;
            this.cbVaiTro_Chien.BackColor = System.Drawing.Color.Transparent;
            this.cbVaiTro_Chien.BorderColor = System.Drawing.Color.Navy;
            this.cbVaiTro_Chien.BorderRadius = 17;
            this.cbVaiTro_Chien.BorderThickness = 2;
            this.cbVaiTro_Chien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVaiTro_Chien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVaiTro_Chien.FillColor = System.Drawing.Color.Navy;
            this.cbVaiTro_Chien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVaiTro_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVaiTro_Chien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbVaiTro_Chien.ForeColor = System.Drawing.Color.AliceBlue;
            this.cbVaiTro_Chien.ItemHeight = 30;
            this.cbVaiTro_Chien.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.cbVaiTro_Chien.Location = new System.Drawing.Point(486, 180);
            this.cbVaiTro_Chien.Name = "cbVaiTro_Chien";
            this.cbVaiTro_Chien.Size = new System.Drawing.Size(200, 36);
            this.cbVaiTro_Chien.TabIndex = 27;
            // 
            // dtpNgaySinh_Chien
            // 
            this.dtpNgaySinh_Chien.Animated = true;
            this.dtpNgaySinh_Chien.AutoRoundedCorners = true;
            this.dtpNgaySinh_Chien.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgaySinh_Chien.BorderColor = System.Drawing.Color.Navy;
            this.dtpNgaySinh_Chien.BorderRadius = 17;
            this.dtpNgaySinh_Chien.Checked = true;
            this.dtpNgaySinh_Chien.FillColor = System.Drawing.Color.Navy;
            this.dtpNgaySinh_Chien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh_Chien.ForeColor = System.Drawing.Color.White;
            this.dtpNgaySinh_Chien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh_Chien.IndicateFocus = true;
            this.dtpNgaySinh_Chien.Location = new System.Drawing.Point(160, 180);
            this.dtpNgaySinh_Chien.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh_Chien.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh_Chien.Name = "dtpNgaySinh_Chien";
            this.dtpNgaySinh_Chien.Size = new System.Drawing.Size(200, 36);
            this.dtpNgaySinh_Chien.TabIndex = 26;
            this.dtpNgaySinh_Chien.UseTransparentBackground = true;
            this.dtpNgaySinh_Chien.Value = new System.DateTime(2024, 11, 9, 22, 41, 6, 592);
            // 
            // rdBoy_Chien
            // 
            this.rdBoy_Chien.AutoSize = true;
            this.rdBoy_Chien.BackColor = System.Drawing.Color.White;
            this.rdBoy_Chien.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rdBoy_Chien.CheckedState.BorderThickness = 0;
            this.rdBoy_Chien.CheckedState.FillColor = System.Drawing.Color.Navy;
            this.rdBoy_Chien.CheckedState.InnerColor = System.Drawing.Color.Navy;
            this.rdBoy_Chien.CheckedState.InnerOffset = -7;
            this.rdBoy_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdBoy_Chien.Location = new System.Drawing.Point(163, 230);
            this.rdBoy_Chien.Name = "rdBoy_Chien";
            this.rdBoy_Chien.Size = new System.Drawing.Size(60, 24);
            this.rdBoy_Chien.TabIndex = 25;
            this.rdBoy_Chien.Text = "Nam";
            this.rdBoy_Chien.UncheckedState.BorderColor = System.Drawing.Color.Navy;
            this.rdBoy_Chien.UncheckedState.BorderThickness = 2;
            this.rdBoy_Chien.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdBoy_Chien.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdBoy_Chien.UseVisualStyleBackColor = false;
            // 
            // rdGirl_Chien
            // 
            this.rdGirl_Chien.AutoSize = true;
            this.rdGirl_Chien.BackColor = System.Drawing.Color.White;
            this.rdGirl_Chien.Checked = true;
            this.rdGirl_Chien.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.rdGirl_Chien.CheckedState.BorderThickness = 0;
            this.rdGirl_Chien.CheckedState.FillColor = System.Drawing.Color.Navy;
            this.rdGirl_Chien.CheckedState.InnerColor = System.Drawing.Color.Navy;
            this.rdGirl_Chien.CheckedState.InnerOffset = -7;
            this.rdGirl_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdGirl_Chien.Location = new System.Drawing.Point(250, 230);
            this.rdGirl_Chien.Name = "rdGirl_Chien";
            this.rdGirl_Chien.Size = new System.Drawing.Size(47, 24);
            this.rdGirl_Chien.TabIndex = 25;
            this.rdGirl_Chien.TabStop = true;
            this.rdGirl_Chien.Text = "Nữ";
            this.rdGirl_Chien.UncheckedState.BorderColor = System.Drawing.Color.Navy;
            this.rdGirl_Chien.UncheckedState.BorderThickness = 2;
            this.rdGirl_Chien.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdGirl_Chien.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rdGirl_Chien.UseVisualStyleBackColor = false;
            // 
            // btnCancel_Chien
            // 
            this.btnCancel_Chien.AutoRoundedCorners = true;
            this.btnCancel_Chien.BackColor = System.Drawing.Color.White;
            this.btnCancel_Chien.BorderRadius = 17;
            this.btnCancel_Chien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel_Chien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel_Chien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.btnCancel_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_Chien.ForeColor = System.Drawing.Color.White;
            this.btnCancel_Chien.Location = new System.Drawing.Point(371, 290);
            this.btnCancel_Chien.Name = "btnCancel_Chien";
            this.btnCancel_Chien.Size = new System.Drawing.Size(115, 36);
            this.btnCancel_Chien.TabIndex = 24;
            this.btnCancel_Chien.Text = "Huỷ";
            this.btnCancel_Chien.Click += new System.EventHandler(this.btnCancel_Chien_Click);
            // 
            // btnSave_Chien
            // 
            this.btnSave_Chien.AutoRoundedCorners = true;
            this.btnSave_Chien.BackColor = System.Drawing.Color.White;
            this.btnSave_Chien.BorderRadius = 17;
            this.btnSave_Chien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave_Chien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave_Chien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.btnSave_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_Chien.ForeColor = System.Drawing.Color.White;
            this.btnSave_Chien.Location = new System.Drawing.Point(250, 290);
            this.btnSave_Chien.Name = "btnSave_Chien";
            this.btnSave_Chien.Size = new System.Drawing.Size(115, 36);
            this.btnSave_Chien.TabIndex = 22;
            this.btnSave_Chien.Text = "Cập nhật";
            this.btnSave_Chien.Click += new System.EventHandler(this.btnSave_Chien_Click);
            // 
            // MatKhau_Chien
            // 
            this.MatKhau_Chien.AutoRoundedCorners = true;
            this.MatKhau_Chien.BackColor = System.Drawing.Color.White;
            this.MatKhau_Chien.BorderRadius = 17;
            this.MatKhau_Chien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MatKhau_Chien.DefaultText = "";
            this.MatKhau_Chien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MatKhau_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MatKhau_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MatKhau_Chien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MatKhau_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MatKhau_Chien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MatKhau_Chien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MatKhau_Chien.Location = new System.Drawing.Point(486, 133);
            this.MatKhau_Chien.Name = "MatKhau_Chien";
            this.MatKhau_Chien.PasswordChar = '\0';
            this.MatKhau_Chien.PlaceholderText = "Nhập mật khẩu ...";
            this.MatKhau_Chien.SelectedText = "";
            this.MatKhau_Chien.Size = new System.Drawing.Size(200, 36);
            this.MatKhau_Chien.TabIndex = 9;
            // 
            // HoTen_Chien
            // 
            this.HoTen_Chien.AutoRoundedCorners = true;
            this.HoTen_Chien.BackColor = System.Drawing.Color.White;
            this.HoTen_Chien.BorderRadius = 17;
            this.HoTen_Chien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.HoTen_Chien.DefaultText = "";
            this.HoTen_Chien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.HoTen_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.HoTen_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HoTen_Chien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.HoTen_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HoTen_Chien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HoTen_Chien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.HoTen_Chien.Location = new System.Drawing.Point(160, 133);
            this.HoTen_Chien.Name = "HoTen_Chien";
            this.HoTen_Chien.PasswordChar = '\0';
            this.HoTen_Chien.PlaceholderText = "Nhập họ tên...";
            this.HoTen_Chien.SelectedText = "";
            this.HoTen_Chien.Size = new System.Drawing.Size(200, 36);
            this.HoTen_Chien.TabIndex = 9;
            // 
            // TaiKhoan_Chien
            // 
            this.TaiKhoan_Chien.AutoRoundedCorners = true;
            this.TaiKhoan_Chien.BackColor = System.Drawing.Color.White;
            this.TaiKhoan_Chien.BorderRadius = 17;
            this.TaiKhoan_Chien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TaiKhoan_Chien.DefaultText = "";
            this.TaiKhoan_Chien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TaiKhoan_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TaiKhoan_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TaiKhoan_Chien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TaiKhoan_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaiKhoan_Chien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TaiKhoan_Chien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaiKhoan_Chien.Location = new System.Drawing.Point(486, 83);
            this.TaiKhoan_Chien.Name = "TaiKhoan_Chien";
            this.TaiKhoan_Chien.PasswordChar = '\0';
            this.TaiKhoan_Chien.PlaceholderText = "Nhập tài khoản ...";
            this.TaiKhoan_Chien.SelectedText = "";
            this.TaiKhoan_Chien.Size = new System.Drawing.Size(200, 36);
            this.TaiKhoan_Chien.TabIndex = 7;
            // 
            // IdStaff_Chien
            // 
            this.IdStaff_Chien.AutoRoundedCorners = true;
            this.IdStaff_Chien.BackColor = System.Drawing.Color.White;
            this.IdStaff_Chien.BorderRadius = 17;
            this.IdStaff_Chien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdStaff_Chien.DefaultText = "";
            this.IdStaff_Chien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IdStaff_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdStaff_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdStaff_Chien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdStaff_Chien.Enabled = false;
            this.IdStaff_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdStaff_Chien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdStaff_Chien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdStaff_Chien.Location = new System.Drawing.Point(160, 83);
            this.IdStaff_Chien.Name = "IdStaff_Chien";
            this.IdStaff_Chien.PasswordChar = '\0';
            this.IdStaff_Chien.PlaceholderText = "ID Staff ...";
            this.IdStaff_Chien.SelectedText = "";
            this.IdStaff_Chien.Size = new System.Drawing.Size(200, 36);
            this.IdStaff_Chien.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giới Tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Vai Trò:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Họ Tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tài Khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID STAFF:";
            // 
            // UC_Staff_Admin_Chien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Staff_Admin_Chien";
            this.Size = new System.Drawing.Size(1034, 510);
            this.Load += new System.EventHandler(this.UC_Staff_Admin_Chien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabStaff_Chien.ResumeLayout(false);
            this.tabDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff_Chien)).EndInit();
            this.tabChucNang.ResumeLayout(false);
            this.tabChucNang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTim;
        private Guna.UI2.WinForms.Guna2Button btnXoa_Chien;
        private Guna.UI2.WinForms.Guna2Button btnAdd_Chien;
        private Guna.UI2.WinForms.Guna2Button btnEdit_Chien;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabControl tabStaff_Chien;
        private MetroFramework.Controls.MetroTabPage tabDanhSach;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStaff_Chien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private MetroFramework.Controls.MetroTabPage tabChucNang;
        private Guna.UI2.WinForms.Guna2Button btnCancel_Chien;
        private Guna.UI2.WinForms.Guna2Button btnSave_Chien;
        private Guna.UI2.WinForms.Guna2TextBox HoTen_Chien;
        private Guna.UI2.WinForms.Guna2TextBox IdStaff_Chien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2RadioButton rdGirl_Chien;
        private Guna.UI2.WinForms.Guna2RadioButton rdBoy_Chien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaySinh_Chien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cbVaiTro_Chien;
        private Guna.UI2.WinForms.Guna2TextBox MatKhau_Chien;
        private Guna.UI2.WinForms.Guna2TextBox TaiKhoan_Chien;
    }
}
