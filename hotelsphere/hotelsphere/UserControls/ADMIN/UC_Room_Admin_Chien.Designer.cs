namespace hotelsphere.UserControls.ADMIN
{
    partial class UC_Room_Admin_Chien
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
            this.txtTim_Khanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoa_Khanh = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd_Khanh = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit_Khanh = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabRoom_Khanh = new MetroFramework.Controls.MetroTabControl();
            this.tabDanhSach_Khanh = new MetroFramework.Controls.MetroTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvRoom_Khanh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabChucNang_Khanh = new MetroFramework.Controls.MetroTabPage();
            this.cbTrangThai_Khanh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbLoaiPhong_Khanh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancel_Khanh = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave_Khanh = new Guna.UI2.WinForms.Guna2Button();
            this.TenPhong_Khanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDPhong_Khanh = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabRoom_Khanh.SuspendLayout();
            this.tabDanhSach_Khanh.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom_Khanh)).BeginInit();
            this.tabChucNang_Khanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTim_Khanh);
            this.panel1.Controls.Add(this.btnXoa_Khanh);
            this.panel1.Controls.Add(this.btnAdd_Khanh);
            this.panel1.Controls.Add(this.btnEdit_Khanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 64);
            this.panel1.TabIndex = 5;
            // 
            // txtTim_Khanh
            // 
            this.txtTim_Khanh.AutoRoundedCorners = true;
            this.txtTim_Khanh.BorderRadius = 17;
            this.txtTim_Khanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTim_Khanh.DefaultText = "";
            this.txtTim_Khanh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTim_Khanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTim_Khanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim_Khanh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTim_Khanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim_Khanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTim_Khanh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTim_Khanh.Location = new System.Drawing.Point(4, 14);
            this.txtTim_Khanh.Name = "txtTim_Khanh";
            this.txtTim_Khanh.PasswordChar = '\0';
            this.txtTim_Khanh.PlaceholderText = "Nhập mã hoặc tên phòng...";
            this.txtTim_Khanh.SelectedText = "";
            this.txtTim_Khanh.Size = new System.Drawing.Size(489, 36);
            this.txtTim_Khanh.TabIndex = 1;
            this.txtTim_Khanh.TextChanged += new System.EventHandler(this.txtTim_Khanh_TextChanged);
            // 
            // btnXoa_Khanh
            // 
            this.btnXoa_Khanh.AutoRoundedCorners = true;
            this.btnXoa_Khanh.BorderRadius = 17;
            this.btnXoa_Khanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa_Khanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa_Khanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa_Khanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa_Khanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa_Khanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_Khanh.ForeColor = System.Drawing.Color.White;
            this.btnXoa_Khanh.Location = new System.Drawing.Point(668, 14);
            this.btnXoa_Khanh.Name = "btnXoa_Khanh";
            this.btnXoa_Khanh.Size = new System.Drawing.Size(60, 36);
            this.btnXoa_Khanh.TabIndex = 2;
            this.btnXoa_Khanh.Text = "Xoá";
            this.btnXoa_Khanh.Click += new System.EventHandler(this.btnXoa_Khanh_Click);
            // 
            // btnAdd_Khanh
            // 
            this.btnAdd_Khanh.AutoRoundedCorners = true;
            this.btnAdd_Khanh.BorderRadius = 17;
            this.btnAdd_Khanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Khanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd_Khanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd_Khanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd_Khanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd_Khanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Khanh.ForeColor = System.Drawing.Color.White;
            this.btnAdd_Khanh.Location = new System.Drawing.Point(499, 15);
            this.btnAdd_Khanh.Name = "btnAdd_Khanh";
            this.btnAdd_Khanh.Size = new System.Drawing.Size(77, 36);
            this.btnAdd_Khanh.TabIndex = 2;
            this.btnAdd_Khanh.Text = "Thêm";
            this.btnAdd_Khanh.Click += new System.EventHandler(this.btnAdd_Khanh_Click);
            // 
            // btnEdit_Khanh
            // 
            this.btnEdit_Khanh.AutoRoundedCorners = true;
            this.btnEdit_Khanh.BorderRadius = 17;
            this.btnEdit_Khanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit_Khanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit_Khanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit_Khanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit_Khanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEdit_Khanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_Khanh.ForeColor = System.Drawing.Color.White;
            this.btnEdit_Khanh.Location = new System.Drawing.Point(582, 15);
            this.btnEdit_Khanh.Name = "btnEdit_Khanh";
            this.btnEdit_Khanh.Size = new System.Drawing.Size(80, 36);
            this.btnEdit_Khanh.TabIndex = 2;
            this.btnEdit_Khanh.Text = "Sửa";
            this.btnEdit_Khanh.Click += new System.EventHandler(this.btnEdit_Khanh_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabRoom_Khanh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 446);
            this.panel2.TabIndex = 6;
            // 
            // tabRoom_Khanh
            // 
            this.tabRoom_Khanh.Controls.Add(this.tabDanhSach_Khanh);
            this.tabRoom_Khanh.Controls.Add(this.tabChucNang_Khanh);
            this.tabRoom_Khanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRoom_Khanh.Location = new System.Drawing.Point(0, 0);
            this.tabRoom_Khanh.Name = "tabRoom_Khanh";
            this.tabRoom_Khanh.SelectedIndex = 0;
            this.tabRoom_Khanh.Size = new System.Drawing.Size(1012, 446);
            this.tabRoom_Khanh.TabIndex = 0;
            this.tabRoom_Khanh.UseSelectable = true;
            // 
            // tabDanhSach_Khanh
            // 
            this.tabDanhSach_Khanh.Controls.Add(this.panel3);
            this.tabDanhSach_Khanh.HorizontalScrollbarBarColor = true;
            this.tabDanhSach_Khanh.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDanhSach_Khanh.HorizontalScrollbarSize = 10;
            this.tabDanhSach_Khanh.Location = new System.Drawing.Point(4, 38);
            this.tabDanhSach_Khanh.Name = "tabDanhSach_Khanh";
            this.tabDanhSach_Khanh.Size = new System.Drawing.Size(1004, 404);
            this.tabDanhSach_Khanh.TabIndex = 0;
            this.tabDanhSach_Khanh.Text = "DANH SÁCH";
            this.tabDanhSach_Khanh.VerticalScrollbarBarColor = true;
            this.tabDanhSach_Khanh.VerticalScrollbarHighlightOnWheel = false;
            this.tabDanhSach_Khanh.VerticalScrollbarSize = 10;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvRoom_Khanh);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1005, 404);
            this.panel3.TabIndex = 5;
            // 
            // dgvRoom_Khanh
            // 
            this.dgvRoom_Khanh.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvRoom_Khanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoom_Khanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoom_Khanh.ColumnHeadersHeight = 60;
            this.dgvRoom_Khanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRoom_Khanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoom_Khanh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoom_Khanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoom_Khanh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvRoom_Khanh.Location = new System.Drawing.Point(0, 0);
            this.dgvRoom_Khanh.Name = "dgvRoom_Khanh";
            this.dgvRoom_Khanh.ReadOnly = true;
            this.dgvRoom_Khanh.RowHeadersVisible = false;
            this.dgvRoom_Khanh.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRoom_Khanh.RowTemplate.Height = 41;
            this.dgvRoom_Khanh.Size = new System.Drawing.Size(1005, 404);
            this.dgvRoom_Khanh.TabIndex = 4;
            this.dgvRoom_Khanh.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.dgvRoom_Khanh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.dgvRoom_Khanh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRoom_Khanh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRoom_Khanh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRoom_Khanh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRoom_Khanh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRoom_Khanh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.dgvRoom_Khanh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dgvRoom_Khanh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRoom_Khanh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRoom_Khanh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRoom_Khanh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRoom_Khanh.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvRoom_Khanh.ThemeStyle.ReadOnly = true;
            this.dgvRoom_Khanh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.dgvRoom_Khanh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRoom_Khanh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRoom_Khanh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRoom_Khanh.ThemeStyle.RowsStyle.Height = 41;
            this.dgvRoom_Khanh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.dgvRoom_Khanh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvRoom_Khanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_Khanh_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_room";
            this.Column1.HeaderText = "ID PHÒNG";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenphong";
            this.Column2.HeaderText = "TÊN PHÒNG";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tenloaiphong";
            this.Column3.HeaderText = "LOẠI PHÒNG";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "giaphongmotngay";
            this.Column4.HeaderText = "GIÁ TIỀN";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tinhtrang";
            this.Column5.HeaderText = "TÌNH TRẠNG";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "mota";
            this.Column6.HeaderText = "MÔ TẢ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // tabChucNang_Khanh
            // 
            this.tabChucNang_Khanh.Controls.Add(this.cbTrangThai_Khanh);
            this.tabChucNang_Khanh.Controls.Add(this.cbLoaiPhong_Khanh);
            this.tabChucNang_Khanh.Controls.Add(this.btnCancel_Khanh);
            this.tabChucNang_Khanh.Controls.Add(this.btnSave_Khanh);
            this.tabChucNang_Khanh.Controls.Add(this.TenPhong_Khanh);
            this.tabChucNang_Khanh.Controls.Add(this.IDPhong_Khanh);
            this.tabChucNang_Khanh.Controls.Add(this.label4);
            this.tabChucNang_Khanh.Controls.Add(this.label3);
            this.tabChucNang_Khanh.Controls.Add(this.label2);
            this.tabChucNang_Khanh.Controls.Add(this.label1);
            this.tabChucNang_Khanh.HorizontalScrollbarBarColor = true;
            this.tabChucNang_Khanh.HorizontalScrollbarHighlightOnWheel = false;
            this.tabChucNang_Khanh.HorizontalScrollbarSize = 10;
            this.tabChucNang_Khanh.Location = new System.Drawing.Point(4, 38);
            this.tabChucNang_Khanh.Name = "tabChucNang_Khanh";
            this.tabChucNang_Khanh.Size = new System.Drawing.Size(1004, 404);
            this.tabChucNang_Khanh.TabIndex = 1;
            this.tabChucNang_Khanh.Text = "CHỨC NĂNG";
            this.tabChucNang_Khanh.VerticalScrollbarBarColor = true;
            this.tabChucNang_Khanh.VerticalScrollbarHighlightOnWheel = false;
            this.tabChucNang_Khanh.VerticalScrollbarSize = 10;
            // 
            // cbTrangThai_Khanh
            // 
            this.cbTrangThai_Khanh.AutoRoundedCorners = true;
            this.cbTrangThai_Khanh.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangThai_Khanh.BorderRadius = 17;
            this.cbTrangThai_Khanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrangThai_Khanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai_Khanh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai_Khanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai_Khanh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTrangThai_Khanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTrangThai_Khanh.ItemHeight = 30;
            this.cbTrangThai_Khanh.Items.AddRange(new object[] {
            "Trống",
            "Đang thuê"});
            this.cbTrangThai_Khanh.Location = new System.Drawing.Point(349, 235);
            this.cbTrangThai_Khanh.Name = "cbTrangThai_Khanh";
            this.cbTrangThai_Khanh.Size = new System.Drawing.Size(200, 36);
            this.cbTrangThai_Khanh.TabIndex = 35;
            // 
            // cbLoaiPhong_Khanh
            // 
            this.cbLoaiPhong_Khanh.AutoRoundedCorners = true;
            this.cbLoaiPhong_Khanh.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiPhong_Khanh.BorderRadius = 17;
            this.cbLoaiPhong_Khanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiPhong_Khanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong_Khanh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiPhong_Khanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiPhong_Khanh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiPhong_Khanh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoaiPhong_Khanh.ItemHeight = 30;
            this.cbLoaiPhong_Khanh.Location = new System.Drawing.Point(349, 178);
            this.cbLoaiPhong_Khanh.Name = "cbLoaiPhong_Khanh";
            this.cbLoaiPhong_Khanh.Size = new System.Drawing.Size(200, 36);
            this.cbLoaiPhong_Khanh.TabIndex = 35;
            // 
            // btnCancel_Khanh
            // 
            this.btnCancel_Khanh.AutoRoundedCorners = true;
            this.btnCancel_Khanh.BackColor = System.Drawing.Color.White;
            this.btnCancel_Khanh.BorderRadius = 17;
            this.btnCancel_Khanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel_Khanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel_Khanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel_Khanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel_Khanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.btnCancel_Khanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel_Khanh.ForeColor = System.Drawing.Color.White;
            this.btnCancel_Khanh.Location = new System.Drawing.Point(435, 290);
            this.btnCancel_Khanh.Name = "btnCancel_Khanh";
            this.btnCancel_Khanh.Size = new System.Drawing.Size(115, 36);
            this.btnCancel_Khanh.TabIndex = 34;
            this.btnCancel_Khanh.Text = "Huỷ";
            this.btnCancel_Khanh.Click += new System.EventHandler(this.btnCancel_Khanh_Click);
            // 
            // btnSave_Khanh
            // 
            this.btnSave_Khanh.AutoRoundedCorners = true;
            this.btnSave_Khanh.BackColor = System.Drawing.Color.White;
            this.btnSave_Khanh.BorderRadius = 17;
            this.btnSave_Khanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave_Khanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave_Khanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave_Khanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave_Khanh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.btnSave_Khanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_Khanh.ForeColor = System.Drawing.Color.White;
            this.btnSave_Khanh.Location = new System.Drawing.Point(314, 290);
            this.btnSave_Khanh.Name = "btnSave_Khanh";
            this.btnSave_Khanh.Size = new System.Drawing.Size(115, 36);
            this.btnSave_Khanh.TabIndex = 33;
            this.btnSave_Khanh.Text = "Cập nhật";
            this.btnSave_Khanh.Click += new System.EventHandler(this.btnSave_Khanh_Click);
            // 
            // TenPhong_Khanh
            // 
            this.TenPhong_Khanh.AutoRoundedCorners = true;
            this.TenPhong_Khanh.BackColor = System.Drawing.Color.White;
            this.TenPhong_Khanh.BorderRadius = 17;
            this.TenPhong_Khanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenPhong_Khanh.DefaultText = "";
            this.TenPhong_Khanh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TenPhong_Khanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TenPhong_Khanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenPhong_Khanh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenPhong_Khanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenPhong_Khanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TenPhong_Khanh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenPhong_Khanh.Location = new System.Drawing.Point(349, 123);
            this.TenPhong_Khanh.Name = "TenPhong_Khanh";
            this.TenPhong_Khanh.PasswordChar = '\0';
            this.TenPhong_Khanh.PlaceholderText = "Nhập tên phòng ...";
            this.TenPhong_Khanh.SelectedText = "";
            this.TenPhong_Khanh.Size = new System.Drawing.Size(200, 36);
            this.TenPhong_Khanh.TabIndex = 26;
            // 
            // IDPhong_Khanh
            // 
            this.IDPhong_Khanh.AutoRoundedCorners = true;
            this.IDPhong_Khanh.BackColor = System.Drawing.Color.White;
            this.IDPhong_Khanh.BorderRadius = 17;
            this.IDPhong_Khanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDPhong_Khanh.DefaultText = "";
            this.IDPhong_Khanh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDPhong_Khanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDPhong_Khanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDPhong_Khanh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDPhong_Khanh.Enabled = false;
            this.IDPhong_Khanh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDPhong_Khanh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDPhong_Khanh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDPhong_Khanh.Location = new System.Drawing.Point(349, 73);
            this.IDPhong_Khanh.Name = "IDPhong_Khanh";
            this.IDPhong_Khanh.PasswordChar = '\0';
            this.IDPhong_Khanh.PlaceholderText = "ID Phòng ...";
            this.IDPhong_Khanh.SelectedText = "";
            this.IDPhong_Khanh.Size = new System.Drawing.Size(200, 36);
            this.IDPhong_Khanh.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Loại Phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Phòng:";
            // 
            // UC_Room_Admin_Chien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Room_Admin_Chien";
            this.Size = new System.Drawing.Size(1012, 510);
            this.Load += new System.EventHandler(this.UC_Room_Admin_Chien_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabRoom_Khanh.ResumeLayout(false);
            this.tabDanhSach_Khanh.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom_Khanh)).EndInit();
            this.tabChucNang_Khanh.ResumeLayout(false);
            this.tabChucNang_Khanh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTim_Khanh;
        private Guna.UI2.WinForms.Guna2Button btnXoa_Khanh;
        private Guna.UI2.WinForms.Guna2Button btnAdd_Khanh;
        private Guna.UI2.WinForms.Guna2Button btnEdit_Khanh;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabControl tabRoom_Khanh;
        private MetroFramework.Controls.MetroTabPage tabDanhSach_Khanh;
        private MetroFramework.Controls.MetroTabPage tabChucNang_Khanh;
        private Guna.UI2.WinForms.Guna2Button btnCancel_Khanh;
        private Guna.UI2.WinForms.Guna2Button btnSave_Khanh;
        private Guna.UI2.WinForms.Guna2TextBox TenPhong_Khanh;
        private Guna.UI2.WinForms.Guna2TextBox IDPhong_Khanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiPhong_Khanh;
        private Guna.UI2.WinForms.Guna2ComboBox cbTrangThai_Khanh;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRoom_Khanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
