﻿namespace hotelsphere.UserControls
{
    partial class UC_Customer_Chien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl_Chien = new MetroFramework.Controls.MetroTabControl();
            this.tabDSCustomer_Chien = new MetroFramework.Controls.MetroTabPage();
            this.dgvCustomer_Chien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tabChucnang = new MetroFramework.Controls.MetroTabPage();
            this.sdtError_Chien = new System.Windows.Forms.Label();
            this.gioitinhError_Chien = new System.Windows.Forms.Label();
            this.quoctichError_Chien = new System.Windows.Forms.Label();
            this.socccdError_Chien = new System.Windows.Forms.Label();
            this.nameError_Chien = new System.Windows.Forms.Label();
            this.gioitinh_Chien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.sdt_Chien = new Guna.UI2.WinForms.Guna2TextBox();
            this.quoctich_Chien = new Guna.UI2.WinForms.Guna2TextBox();
            this.soCCCD_Chien = new Guna.UI2.WinForms.Guna2TextBox();
            this.tenCustomer_Chien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.idCustomer_Chien = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabControl_Chien.SuspendLayout();
            this.tabDSCustomer_Chien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer_Chien)).BeginInit();
            this.tabChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Chien
            // 
            this.tabControl_Chien.Controls.Add(this.tabDSCustomer_Chien);
            this.tabControl_Chien.Controls.Add(this.tabChucnang);
            this.tabControl_Chien.Location = new System.Drawing.Point(13, 60);
            this.tabControl_Chien.Name = "tabControl_Chien";
            this.tabControl_Chien.SelectedIndex = 0;
            this.tabControl_Chien.Size = new System.Drawing.Size(728, 406);
            this.tabControl_Chien.TabIndex = 0;
            this.tabControl_Chien.UseSelectable = true;
            // 
            // tabDSCustomer_Chien
            // 
            this.tabDSCustomer_Chien.Controls.Add(this.dgvCustomer_Chien);
            this.tabDSCustomer_Chien.HorizontalScrollbarBarColor = true;
            this.tabDSCustomer_Chien.HorizontalScrollbarHighlightOnWheel = false;
            this.tabDSCustomer_Chien.HorizontalScrollbarSize = 10;
            this.tabDSCustomer_Chien.Location = new System.Drawing.Point(4, 38);
            this.tabDSCustomer_Chien.Name = "tabDSCustomer_Chien";
            this.tabDSCustomer_Chien.Size = new System.Drawing.Size(720, 364);
            this.tabDSCustomer_Chien.TabIndex = 0;
            this.tabDSCustomer_Chien.Text = "Danh sách khách hàng";
            this.tabDSCustomer_Chien.VerticalScrollbarBarColor = true;
            this.tabDSCustomer_Chien.VerticalScrollbarHighlightOnWheel = false;
            this.tabDSCustomer_Chien.VerticalScrollbarSize = 10;
            // 
            // dgvCustomer_Chien
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer_Chien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomer_Chien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer_Chien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer_Chien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomer_Chien.ColumnHeadersHeight = 40;
            this.dgvCustomer_Chien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer_Chien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomer_Chien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvCustomer_Chien.Location = new System.Drawing.Point(3, 0);
            this.dgvCustomer_Chien.Name = "dgvCustomer_Chien";
            this.dgvCustomer_Chien.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer_Chien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCustomer_Chien.RowHeadersVisible = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer_Chien.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCustomer_Chien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer_Chien.RowTemplate.Height = 40;
            this.dgvCustomer_Chien.RowTemplate.ReadOnly = true;
            this.dgvCustomer_Chien.Size = new System.Drawing.Size(714, 361);
            this.dgvCustomer_Chien.TabIndex = 2;
            this.dgvCustomer_Chien.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Turquoise;
            this.dgvCustomer_Chien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvCustomer_Chien.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer_Chien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCustomer_Chien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCustomer_Chien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCustomer_Chien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomer_Chien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(179)))), ((int)(((byte)(241)))));
            this.dgvCustomer_Chien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(0)))), ((int)(((byte)(211)))));
            this.dgvCustomer_Chien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCustomer_Chien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer_Chien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomer_Chien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCustomer_Chien.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCustomer_Chien.ThemeStyle.ReadOnly = true;
            this.dgvCustomer_Chien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(245)))));
            this.dgvCustomer_Chien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomer_Chien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCustomer_Chien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer_Chien.ThemeStyle.RowsStyle.Height = 40;
            this.dgvCustomer_Chien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(85)))), ((int)(((byte)(225)))));
            this.dgvCustomer_Chien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomer_Chien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_Chien_CellClick);
            // 
            // tabChucnang
            // 
            this.tabChucnang.Controls.Add(this.sdtError_Chien);
            this.tabChucnang.Controls.Add(this.gioitinhError_Chien);
            this.tabChucnang.Controls.Add(this.quoctichError_Chien);
            this.tabChucnang.Controls.Add(this.socccdError_Chien);
            this.tabChucnang.Controls.Add(this.nameError_Chien);
            this.tabChucnang.Controls.Add(this.gioitinh_Chien);
            this.tabChucnang.Controls.Add(this.guna2Button5);
            this.tabChucnang.Controls.Add(this.guna2Button4);
            this.tabChucnang.Controls.Add(this.sdt_Chien);
            this.tabChucnang.Controls.Add(this.quoctich_Chien);
            this.tabChucnang.Controls.Add(this.soCCCD_Chien);
            this.tabChucnang.Controls.Add(this.idCustomer_Chien);
            this.tabChucnang.Controls.Add(this.tenCustomer_Chien);
            this.tabChucnang.Controls.Add(this.label5);
            this.tabChucnang.Controls.Add(this.label4);
            this.tabChucnang.Controls.Add(this.label3);
            this.tabChucnang.Controls.Add(this.label2);
            this.tabChucnang.Controls.Add(this.label1);
            this.tabChucnang.HorizontalScrollbarBarColor = true;
            this.tabChucnang.HorizontalScrollbarHighlightOnWheel = false;
            this.tabChucnang.HorizontalScrollbarSize = 10;
            this.tabChucnang.Location = new System.Drawing.Point(4, 38);
            this.tabChucnang.Name = "tabChucnang";
            this.tabChucnang.Size = new System.Drawing.Size(750, 382);
            this.tabChucnang.TabIndex = 1;
            this.tabChucnang.Text = "Chức năng";
            this.tabChucnang.VerticalScrollbarBarColor = true;
            this.tabChucnang.VerticalScrollbarHighlightOnWheel = false;
            this.tabChucnang.VerticalScrollbarSize = 10;
            // 
            // sdtError_Chien
            // 
            this.sdtError_Chien.AutoSize = true;
            this.sdtError_Chien.BackColor = System.Drawing.Color.White;
            this.sdtError_Chien.Location = new System.Drawing.Point(558, 265);
            this.sdtError_Chien.Name = "sdtError_Chien";
            this.sdtError_Chien.Size = new System.Drawing.Size(0, 13);
            this.sdtError_Chien.TabIndex = 5;
            // 
            // gioitinhError_Chien
            // 
            this.gioitinhError_Chien.AutoSize = true;
            this.gioitinhError_Chien.BackColor = System.Drawing.Color.White;
            this.gioitinhError_Chien.Location = new System.Drawing.Point(558, 214);
            this.gioitinhError_Chien.Name = "gioitinhError_Chien";
            this.gioitinhError_Chien.Size = new System.Drawing.Size(0, 13);
            this.gioitinhError_Chien.TabIndex = 5;
            // 
            // quoctichError_Chien
            // 
            this.quoctichError_Chien.AutoSize = true;
            this.quoctichError_Chien.BackColor = System.Drawing.Color.White;
            this.quoctichError_Chien.Location = new System.Drawing.Point(558, 159);
            this.quoctichError_Chien.Name = "quoctichError_Chien";
            this.quoctichError_Chien.Size = new System.Drawing.Size(0, 13);
            this.quoctichError_Chien.TabIndex = 5;
            // 
            // socccdError_Chien
            // 
            this.socccdError_Chien.AutoSize = true;
            this.socccdError_Chien.BackColor = System.Drawing.Color.White;
            this.socccdError_Chien.Location = new System.Drawing.Point(558, 98);
            this.socccdError_Chien.Name = "socccdError_Chien";
            this.socccdError_Chien.Size = new System.Drawing.Size(0, 13);
            this.socccdError_Chien.TabIndex = 5;
            // 
            // nameError_Chien
            // 
            this.nameError_Chien.AutoSize = true;
            this.nameError_Chien.BackColor = System.Drawing.Color.White;
            this.nameError_Chien.Location = new System.Drawing.Point(558, 50);
            this.nameError_Chien.Name = "nameError_Chien";
            this.nameError_Chien.Size = new System.Drawing.Size(0, 13);
            this.nameError_Chien.TabIndex = 5;
            // 
            // gioitinh_Chien
            // 
            this.gioitinh_Chien.AutoRoundedCorners = true;
            this.gioitinh_Chien.BackColor = System.Drawing.Color.Transparent;
            this.gioitinh_Chien.BorderRadius = 17;
            this.gioitinh_Chien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gioitinh_Chien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gioitinh_Chien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gioitinh_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gioitinh_Chien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gioitinh_Chien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gioitinh_Chien.ItemHeight = 30;
            this.gioitinh_Chien.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gioitinh_Chien.Location = new System.Drawing.Point(339, 202);
            this.gioitinh_Chien.Name = "gioitinh_Chien";
            this.gioitinh_Chien.Size = new System.Drawing.Size(200, 36);
            this.gioitinh_Chien.TabIndex = 3;
            // 
            // guna2Button5
            // 
            this.guna2Button5.AutoRoundedCorners = true;
            this.guna2Button5.BackColor = System.Drawing.Color.White;
            this.guna2Button5.BorderRadius = 17;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(122)))), ((int)(((byte)(83)))));
            this.guna2Button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(384, 312);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(115, 36);
            this.guna2Button5.TabIndex = 6;
            this.guna2Button5.Text = "Huỷ";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.AutoRoundedCorners = true;
            this.guna2Button4.BackColor = System.Drawing.Color.White;
            this.guna2Button4.BorderRadius = 17;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(263, 312);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(115, 36);
            this.guna2Button4.TabIndex = 5;
            this.guna2Button4.Text = "Cập nhật";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // sdt_Chien
            // 
            this.sdt_Chien.AutoRoundedCorners = true;
            this.sdt_Chien.BackColor = System.Drawing.Color.White;
            this.sdt_Chien.BorderRadius = 17;
            this.sdt_Chien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sdt_Chien.DefaultText = "";
            this.sdt_Chien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sdt_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sdt_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sdt_Chien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sdt_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sdt_Chien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sdt_Chien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sdt_Chien.Location = new System.Drawing.Point(339, 253);
            this.sdt_Chien.Name = "sdt_Chien";
            this.sdt_Chien.PasswordChar = '\0';
            this.sdt_Chien.PlaceholderText = "Nhập số điện thoại ...";
            this.sdt_Chien.SelectedText = "";
            this.sdt_Chien.Size = new System.Drawing.Size(200, 36);
            this.sdt_Chien.TabIndex = 4;
            // 
            // quoctich_Chien
            // 
            this.quoctich_Chien.AutoRoundedCorners = true;
            this.quoctich_Chien.BackColor = System.Drawing.Color.White;
            this.quoctich_Chien.BorderRadius = 17;
            this.quoctich_Chien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quoctich_Chien.DefaultText = "";
            this.quoctich_Chien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.quoctich_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.quoctich_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quoctich_Chien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.quoctich_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quoctich_Chien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quoctich_Chien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.quoctich_Chien.Location = new System.Drawing.Point(339, 146);
            this.quoctich_Chien.Name = "quoctich_Chien";
            this.quoctich_Chien.PasswordChar = '\0';
            this.quoctich_Chien.PlaceholderText = "Nhập quốc tịch ...";
            this.quoctich_Chien.SelectedText = "";
            this.quoctich_Chien.Size = new System.Drawing.Size(200, 36);
            this.quoctich_Chien.TabIndex = 2;
            // 
            // soCCCD_Chien
            // 
            this.soCCCD_Chien.AutoRoundedCorners = true;
            this.soCCCD_Chien.BackColor = System.Drawing.Color.White;
            this.soCCCD_Chien.BorderRadius = 17;
            this.soCCCD_Chien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.soCCCD_Chien.DefaultText = "";
            this.soCCCD_Chien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.soCCCD_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.soCCCD_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soCCCD_Chien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.soCCCD_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soCCCD_Chien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soCCCD_Chien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.soCCCD_Chien.Location = new System.Drawing.Point(339, 91);
            this.soCCCD_Chien.Name = "soCCCD_Chien";
            this.soCCCD_Chien.PasswordChar = '\0';
            this.soCCCD_Chien.PlaceholderText = "Nhập số CCCD ...";
            this.soCCCD_Chien.SelectedText = "";
            this.soCCCD_Chien.Size = new System.Drawing.Size(200, 36);
            this.soCCCD_Chien.TabIndex = 1;
            // 
            // tenCustomer_Chien
            // 
            this.tenCustomer_Chien.AutoRoundedCorners = true;
            this.tenCustomer_Chien.BackColor = System.Drawing.Color.White;
            this.tenCustomer_Chien.BorderRadius = 17;
            this.tenCustomer_Chien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tenCustomer_Chien.DefaultText = "";
            this.tenCustomer_Chien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tenCustomer_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tenCustomer_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tenCustomer_Chien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tenCustomer_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tenCustomer_Chien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tenCustomer_Chien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tenCustomer_Chien.Location = new System.Drawing.Point(339, 37);
            this.tenCustomer_Chien.Name = "tenCustomer_Chien";
            this.tenCustomer_Chien.PasswordChar = '\0';
            this.tenCustomer_Chien.PlaceholderText = "Nhập tên ...";
            this.tenCustomer_Chien.SelectedText = "";
            this.tenCustomer_Chien.Size = new System.Drawing.Size(200, 36);
            this.tenCustomer_Chien.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số điện thoại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quốc tịch:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số CCCD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Khách Hàng:";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.AutoRoundedCorners = true;
            this.guna2TextBox1.BorderRadius = 17;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(17, 17);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Nhập tên khách hàng để tìm kiếm ...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(489, 36);
            this.guna2TextBox1.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(512, 18);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(77, 36);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Thêm";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 17;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(595, 17);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(80, 36);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Sửa";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 17;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(681, 17);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(60, 36);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Xoá";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // idCustomer_Chien
            // 
            this.idCustomer_Chien.AutoRoundedCorners = true;
            this.idCustomer_Chien.BackColor = System.Drawing.Color.White;
            this.idCustomer_Chien.BorderRadius = 17;
            this.idCustomer_Chien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idCustomer_Chien.DefaultText = "";
            this.idCustomer_Chien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idCustomer_Chien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idCustomer_Chien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idCustomer_Chien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idCustomer_Chien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idCustomer_Chien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idCustomer_Chien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idCustomer_Chien.Location = new System.Drawing.Point(0, 312);
            this.idCustomer_Chien.Name = "idCustomer_Chien";
            this.idCustomer_Chien.PasswordChar = '\0';
            this.idCustomer_Chien.PlaceholderText = "Nhập tên ...";
            this.idCustomer_Chien.SelectedText = "";
            this.idCustomer_Chien.Size = new System.Drawing.Size(200, 36);
            this.idCustomer_Chien.TabIndex = 0;
            this.idCustomer_Chien.Visible = false;
            // 
            // UC_Customer_Chien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.tabControl_Chien);
            this.Name = "UC_Customer_Chien";
            this.Size = new System.Drawing.Size(765, 480);
            this.tabControl_Chien.ResumeLayout(false);
            this.tabDSCustomer_Chien.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer_Chien)).EndInit();
            this.tabChucnang.ResumeLayout(false);
            this.tabChucnang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl_Chien;
        private MetroFramework.Controls.MetroTabPage tabDSCustomer_Chien;
        private MetroFramework.Controls.MetroTabPage tabChucnang;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCustomer_Chien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tenCustomer_Chien;
        private Guna.UI2.WinForms.Guna2ComboBox gioitinh_Chien;
        private Guna.UI2.WinForms.Guna2TextBox quoctich_Chien;
        private Guna.UI2.WinForms.Guna2TextBox soCCCD_Chien;
        private Guna.UI2.WinForms.Guna2TextBox sdt_Chien;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Label nameError_Chien;
        private System.Windows.Forms.Label sdtError_Chien;
        private System.Windows.Forms.Label gioitinhError_Chien;
        private System.Windows.Forms.Label quoctichError_Chien;
        private System.Windows.Forms.Label socccdError_Chien;
        private Guna.UI2.WinForms.Guna2TextBox idCustomer_Chien;
    }
}