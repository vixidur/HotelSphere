namespace hotelsphere.UserControls
{
    partial class UC_RoomType_Chien
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
            this.lblTenPhong_Chien = new System.Windows.Forms.Label();
            this.lblLoaiPhong_Chien = new System.Windows.Forms.Label();
            this.lblTinhTrang_Chien = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblChiTiet_Chien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenPhong_Chien
            // 
            this.lblTenPhong_Chien.AutoSize = true;
            this.lblTenPhong_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong_Chien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTenPhong_Chien.Location = new System.Drawing.Point(3, 13);
            this.lblTenPhong_Chien.Name = "lblTenPhong_Chien";
            this.lblTenPhong_Chien.Size = new System.Drawing.Size(68, 16);
            this.lblTenPhong_Chien.TabIndex = 0;
            this.lblTenPhong_Chien.Text = "Room 100";
            // 
            // lblLoaiPhong_Chien
            // 
            this.lblLoaiPhong_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong_Chien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLoaiPhong_Chien.Location = new System.Drawing.Point(86, 11);
            this.lblLoaiPhong_Chien.MaximumSize = new System.Drawing.Size(85, 35);
            this.lblLoaiPhong_Chien.Name = "lblLoaiPhong_Chien";
            this.lblLoaiPhong_Chien.Size = new System.Drawing.Size(85, 35);
            this.lblLoaiPhong_Chien.TabIndex = 0;
            this.lblLoaiPhong_Chien.Text = "Phòng cao cấp";
            // 
            // lblTinhTrang_Chien
            // 
            this.lblTinhTrang_Chien.AutoSize = true;
            this.lblTinhTrang_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang_Chien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTinhTrang_Chien.Location = new System.Drawing.Point(47, 43);
            this.lblTinhTrang_Chien.MaximumSize = new System.Drawing.Size(120, 0);
            this.lblTinhTrang_Chien.Name = "lblTinhTrang_Chien";
            this.lblTinhTrang_Chien.Size = new System.Drawing.Size(61, 24);
            this.lblTinhTrang_Chien.TabIndex = 0;
            this.lblTinhTrang_Chien.Text = "Trống";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(62)))), ((int)(((byte)(135)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTinhTrang_Chien);
            this.panel1.Controls.Add(this.lblLoaiPhong_Chien);
            this.panel1.Controls.Add(this.lblChiTiet_Chien);
            this.panel1.Controls.Add(this.lblTenPhong_Chien);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 100);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotelsphere.Properties.Resources.icon_verify1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblChiTiet_Chien
            // 
            this.lblChiTiet_Chien.AutoSize = true;
            this.lblChiTiet_Chien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTiet_Chien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChiTiet_Chien.Location = new System.Drawing.Point(81, 79);
            this.lblChiTiet_Chien.Name = "lblChiTiet_Chien";
            this.lblChiTiet_Chien.Size = new System.Drawing.Size(0, 16);
            this.lblChiTiet_Chien.TabIndex = 0;
            // 
            // UC_RoomType_Chien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_RoomType_Chien";
            this.Size = new System.Drawing.Size(180, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenPhong_Chien;
        private System.Windows.Forms.Label lblLoaiPhong_Chien;
        private System.Windows.Forms.Label lblTinhTrang_Chien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblChiTiet_Chien;
    }
}
