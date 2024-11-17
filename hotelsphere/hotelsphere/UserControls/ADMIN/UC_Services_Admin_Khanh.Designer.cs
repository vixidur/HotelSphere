namespace hotelsphere.UserControls.ADMIN
{
    partial class UC_Services_Admin_Khanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTim_TAnh = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoa_TAnh = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd_TAnh = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit_TAnh = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabServices_TAnh = new MetroFramework.Controls.MetroTabControl();
            this.tabDanhSach_TAnh = new MetroFramework.Controls.MetroTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDichVu_TAnh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabChucNang_TAnh = new MetroFramework.Controls.MetroTabPage();
            this.btnCancel_TAnh = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave_TAnh = new Guna.UI2.WinForms.Guna2Button();
            this.GiaTien_TAnh = new Guna.UI2.WinForms.Guna2TextBox();
            this.TenDichVu_TAnh = new Guna.UI2.WinForms.Guna2TextBox();
            this.IdServices_TAnh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabServices_TAnh.SuspendLayout();
            this.tabDanhSach_TAnh.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu_TAnh)).BeginInit();
            this.tabChucNang_TAnh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTim_TAnh);
            this.panel1.Controls.Add(this.btnXoa_TAnh);
            this.panel1.Controls.Add(this.btnAdd_TAnh);
            this.panel1.Controls.Add(this.btnEdit_TAnh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 64);
            this.panel1.TabIndex = 6;
            // 
            // txtTim_TAnh
            // 
            this.txtTim_TAnh.AutoRoundedCorners = true;
            this.txtTim_TAnh.BorderRadius = 17;
            this.txtTim_TAnh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim_TAnh.DefaultText = "";
            this.txtTim_TAnh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTim_TAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTim_TAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim_TAnh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim_TAnh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim_TAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTim_TAnh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim_TAnh.Location = new System.Drawing.Point(4, 14);
            this.txtTim_TAnh.Name = "txtTim_TAnh";
            this.txtTim_TAnh.PasswordChar = '\0';
            this.txtTim_TAnh.PlaceholderText = "Nhập mã hoặc tên dịch vụ...";
            this.txtTim_TAnh.SelectedText = "";
            this.txtTim_TAnh.Size = new System.Drawing.Size(489, 36);
            this.txtTim_TAnh.TabIndex = 1;
            this.txtTim_TAnh.TextChanged += new System.EventHandler(this.txtTim_TAnh_TextChanged);
            // 
            // btnXoa_TAnh
            // 
            this.btnXoa_TAnh.AutoRoundedCorners = true;
            this.btnXoa_TAnh.BorderRadius = 17;
            this.btnXoa_TAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa_TAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa_TAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa_TAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa_TAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa_TAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_TAnh.ForeColor = System.Drawing.Color.White;
            this.btnXoa_TAnh.Location = new System.Drawing.Point(668, 14);
            this.btnXoa_TAnh.Name = "btnXoa_TAnh";
            this.btnXoa_TAnh.Size = new System.Drawing.Size(60, 36);
            this.btnXoa_TAnh.TabIndex = 2;
            this.btnXoa_TAnh.Text = "Xoá";
            this.btnXoa_TAnh.Click += new System.EventHandler(this.btnXoa_TAnh_Click);
            // 
            // btnAdd_TAnh
            // 
            this.btnAdd_TAnh.AutoRoundedCorners = true;
            this.btnAdd_TAnh.BorderRadius = 17;
            this.btnAdd_TAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_TAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_TAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_TAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_TAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd_TAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_TAnh.ForeColor = System.Drawing.Color.White;
            this.btnAdd_TAnh.Location = new System.Drawing.Point(499, 15);
            this.btnAdd_TAnh.Name = "btnAdd_TAnh";
            this.btnAdd_TAnh.Size = new System.Drawing.Size(77, 36);
            this.btnAdd_TAnh.TabIndex = 2;
            this.btnAdd_TAnh.Text = "Thêm";
            this.btnAdd_TAnh.Click += new System.EventHandler(this.btnAdd_TAnh_Click);
            // 
            // btnEdit_TAnh
            // 
            this.btnEdit_TAnh.AutoRoundedCorners = true;
            this.btnEdit_TAnh.BorderRadius = 17;
            this.btnEdit_TAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit_TAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit_TAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit_TAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit_TAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit_TAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_TAnh.ForeColor = System.Drawing.Color.White;
            this.btnEdit_TAnh.Location = new System.Drawing.Point(582, 15);
            this.btnEdit_TAnh.Name = "btnEdit_TAnh";
            this.btnEdit_TAnh.Size = new System.Drawing.Size(80, 36);
            this.btnEdit_TAnh.TabIndex = 2;
            this.btnEdit_TAnh.Text = "Sửa";
            this.btnEdit_TAnh.Click += new System.EventHandler(this.btnEdit_TAnh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabServices_TAnh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1034, 446);
            this.panel2.TabIndex = 7;
            // 
            // tabServices_TAnh
            // 
            this.tabServices_TAnh.Controls.Add(this.tabDanhSach_TAnh);
            this.tabServices_TAnh.Controls.Add(this.tabChucNang_TAnh);
            this.tabServices_TAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabServices_TAnh.Location = new System.Drawing.Point(0, 0);
            this.tabServices_TAnh.Name = "tabServices_TAnh";
            this.tabServices_TAnh.SelectedIndex = 0;
            this.tabServices_TAnh.Size = new System.Drawing.Size(1034, 446);
            this.tabServices_TAnh.TabIndex = 0;
            this.tabServices_TAnh.UseSelectable = true;
            // 
            // tabDanhSach_TAnh
            // 
            this.tabDanhSach_TAnh.Controls.Add(this.panel3);
            this.tabDanhSach_TAnh.HorizontalScrollbarBarColor = true;
            this.tabDanhSach_TAnh.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDanhSach_TAnh.HorizontalScrollbarSize = 10;
            this.tabDanhSach_TAnh.Location = new System.Drawing.Point(4, 38);
            this.tabDanhSach_TAnh.Name = "tabDanhSach_TAnh";
            this.tabDanhSach_TAnh.Size = new System.Drawing.Size(1026, 404);
            this.tabDanhSach_TAnh.TabIndex = 0;
            this.tabDanhSach_TAnh.Text = "DANH SÁCH";
            this.tabDanhSach_TAnh.VerticalScrollbarBarColor = true;
            this.tabDanhSach_TAnh.VerticalScrollbarHighlightOnWheel = false;
            this.tabDanhSach_TAnh.VerticalScrollbarSize = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvDichVu_TAnh);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1026, 404);
            this.panel3.TabIndex = 5;
            // 
            // dgvDichVu_TAnh
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvDichVu_TAnh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDichVu_TAnh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDichVu_TAnh.ColumnHeadersHeight = 60;
            this.dgvDichVu_TAnh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDichVu_TAnh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDichVu_TAnh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDichVu_TAnh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDichVu_TAnh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvDichVu_TAnh.Location = new System.Drawing.Point(0, 0);
            this.dgvDichVu_TAnh.Name = "dgvDichVu_TAnh";
            this.dgvDichVu_TAnh.ReadOnly = true;
            this.dgvDichVu_TAnh.RowHeadersVisible = false;
            this.dgvDichVu_TAnh.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDichVu_TAnh.RowTemplate.Height = 41;
            this.dgvDichVu_TAnh.Size = new System.Drawing.Size(1026, 404);
            this.dgvDichVu_TAnh.TabIndex = 4;
            this.dgvDichVu_TAnh.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvDichVu_TAnh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvDichVu_TAnh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDichVu_TAnh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDichVu_TAnh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDichVu_TAnh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDichVu_TAnh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDichVu_TAnh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvDichVu_TAnh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvDichVu_TAnh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDichVu_TAnh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDichVu_TAnh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDichVu_TAnh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDichVu_TAnh.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvDichVu_TAnh.ThemeStyle.ReadOnly = true;
            this.dgvDichVu_TAnh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvDichVu_TAnh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDichVu_TAnh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDichVu_TAnh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDichVu_TAnh.ThemeStyle.RowsStyle.Height = 41;
            this.dgvDichVu_TAnh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvDichVu_TAnh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDichVu_TAnh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_TAnh_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_dichvu";
            this.Column1.HeaderText = "ID DỊCH VỤ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tendichvu";
            this.Column2.HeaderText = "TÊN DỊCH VỤ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "giadichvu";
            this.Column3.HeaderText = "GIÁ TIỀN";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabChucNang_TAnh
            // 
            this.tabChucNang_TAnh.Controls.Add(this.btnCancel_TAnh);
            this.tabChucNang_TAnh.Controls.Add(this.btnSave_TAnh);
            this.tabChucNang_TAnh.Controls.Add(this.GiaTien_TAnh);
            this.tabChucNang_TAnh.Controls.Add(this.TenDichVu_TAnh);
            this.tabChucNang_TAnh.Controls.Add(this.IdServices_TAnh);
            this.tabChucNang_TAnh.Controls.Add(this.label3);
            this.tabChucNang_TAnh.Controls.Add(this.label2);
            this.tabChucNang_TAnh.Controls.Add(this.label1);
            this.tabChucNang_TAnh.HorizontalScrollbarBarColor = true;
            this.tabChucNang_TAnh.HorizontalScrollbarHighlightOnWheel = false;
            this.tabChucNang_TAnh.HorizontalScrollbarSize = 10;
            this.tabChucNang_TAnh.Location = new System.Drawing.Point(4, 38);
            this.tabChucNang_TAnh.Name = "tabChucNang_TAnh";
            this.tabChucNang_TAnh.Size = new System.Drawing.Size(1026, 404);
            this.tabChucNang_TAnh.TabIndex = 1;
            this.tabChucNang_TAnh.Text = "CHỨC NĂNG";
            this.tabChucNang_TAnh.VerticalScrollbarBarColor = true;
            this.tabChucNang_TAnh.VerticalScrollbarHighlightOnWheel = false;
            this.tabChucNang_TAnh.VerticalScrollbarSize = 10;
            // 
            // btnCancel_TAnh
            // 
            this.btnCancel_TAnh.AutoRoundedCorners = true;
            this.btnCancel_TAnh.BackColor = System.Drawing.Color.White;
            this.btnCancel_TAnh.BorderRadius = 17;
            this.btnCancel_TAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel_TAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel_TAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel_TAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel_TAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.btnCancel_TAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_TAnh.ForeColor = System.Drawing.Color.White;
            this.btnCancel_TAnh.Location = new System.Drawing.Point(437, 233);
            this.btnCancel_TAnh.Name = "btnCancel_TAnh";
            this.btnCancel_TAnh.Size = new System.Drawing.Size(115, 36);
            this.btnCancel_TAnh.TabIndex = 34;
            this.btnCancel_TAnh.Text = "Huỷ";
            this.btnCancel_TAnh.Click += new System.EventHandler(this.btnCancel_TAnh_Click);
            // 
            // btnSave_TAnh
            // 
            this.btnSave_TAnh.AutoRoundedCorners = true;
            this.btnSave_TAnh.BackColor = System.Drawing.Color.White;
            this.btnSave_TAnh.BorderRadius = 17;
            this.btnSave_TAnh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave_TAnh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave_TAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave_TAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave_TAnh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.btnSave_TAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_TAnh.ForeColor = System.Drawing.Color.White;
            this.btnSave_TAnh.Location = new System.Drawing.Point(316, 233);
            this.btnSave_TAnh.Name = "btnSave_TAnh";
            this.btnSave_TAnh.Size = new System.Drawing.Size(115, 36);
            this.btnSave_TAnh.TabIndex = 33;
            this.btnSave_TAnh.Text = "Cập nhật";
            this.btnSave_TAnh.Click += new System.EventHandler(this.btnSave_TAnh_Click);
            // 
            // GiaTien_TAnh
            // 
            this.GiaTien_TAnh.AutoRoundedCorners = true;
            this.GiaTien_TAnh.BackColor = System.Drawing.Color.White;
            this.GiaTien_TAnh.BorderRadius = 17;
            this.GiaTien_TAnh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GiaTien_TAnh.DefaultText = "";
            this.GiaTien_TAnh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GiaTien_TAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GiaTien_TAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GiaTien_TAnh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GiaTien_TAnh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GiaTien_TAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GiaTien_TAnh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GiaTien_TAnh.Location = new System.Drawing.Point(350, 180);
            this.GiaTien_TAnh.Name = "GiaTien_TAnh";
            this.GiaTien_TAnh.PasswordChar = '\0';
            this.GiaTien_TAnh.PlaceholderText = "Nhập giá tiền ...";
            this.GiaTien_TAnh.SelectedText = "";
            this.GiaTien_TAnh.Size = new System.Drawing.Size(200, 36);
            this.GiaTien_TAnh.TabIndex = 26;
            // 
            // TenDichVu_TAnh
            // 
            this.TenDichVu_TAnh.AutoRoundedCorners = true;
            this.TenDichVu_TAnh.BackColor = System.Drawing.Color.White;
            this.TenDichVu_TAnh.BorderRadius = 17;
            this.TenDichVu_TAnh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenDichVu_TAnh.DefaultText = "";
            this.TenDichVu_TAnh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TenDichVu_TAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TenDichVu_TAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenDichVu_TAnh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenDichVu_TAnh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenDichVu_TAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TenDichVu_TAnh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenDichVu_TAnh.Location = new System.Drawing.Point(349, 123);
            this.TenDichVu_TAnh.Name = "TenDichVu_TAnh";
            this.TenDichVu_TAnh.PasswordChar = '\0';
            this.TenDichVu_TAnh.PlaceholderText = "Nhập tên dịch vụ ...";
            this.TenDichVu_TAnh.SelectedText = "";
            this.TenDichVu_TAnh.Size = new System.Drawing.Size(200, 36);
            this.TenDichVu_TAnh.TabIndex = 26;
            // 
            // IdServices_TAnh
            // 
            this.IdServices_TAnh.AutoRoundedCorners = true;
            this.IdServices_TAnh.BackColor = System.Drawing.Color.White;
            this.IdServices_TAnh.BorderRadius = 17;
            this.IdServices_TAnh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdServices_TAnh.DefaultText = "";
            this.IdServices_TAnh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IdServices_TAnh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IdServices_TAnh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdServices_TAnh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IdServices_TAnh.Enabled = false;
            this.IdServices_TAnh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdServices_TAnh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdServices_TAnh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IdServices_TAnh.Location = new System.Drawing.Point(349, 73);
            this.IdServices_TAnh.Name = "IdServices_TAnh";
            this.IdServices_TAnh.PasswordChar = '\0';
            this.IdServices_TAnh.PlaceholderText = "ID Dịch vụ ...";
            this.IdServices_TAnh.SelectedText = "";
            this.IdServices_TAnh.Size = new System.Drawing.Size(200, 36);
            this.IdServices_TAnh.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Giá Tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Dịch Vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Dịch Vụ:";
            // 
            // UC_Services_Admin_Khanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Services_Admin_Khanh";
            this.Size = new System.Drawing.Size(1034, 510);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabServices_TAnh.ResumeLayout(false);
            this.tabDanhSach_TAnh.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu_TAnh)).EndInit();
            this.tabChucNang_TAnh.ResumeLayout(false);
            this.tabChucNang_TAnh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTim_TAnh;
        private Guna.UI2.WinForms.Guna2Button btnXoa_TAnh;
        private Guna.UI2.WinForms.Guna2Button btnAdd_TAnh;
        private Guna.UI2.WinForms.Guna2Button btnEdit_TAnh;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabControl tabServices_TAnh;
        private MetroFramework.Controls.MetroTabPage tabDanhSach_TAnh;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDichVu_TAnh;
        private MetroFramework.Controls.MetroTabPage tabChucNang_TAnh;
        private Guna.UI2.WinForms.Guna2Button btnCancel_TAnh;
        private Guna.UI2.WinForms.Guna2Button btnSave_TAnh;
        private Guna.UI2.WinForms.Guna2TextBox TenDichVu_TAnh;
        private Guna.UI2.WinForms.Guna2TextBox IdServices_TAnh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox GiaTien_TAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
