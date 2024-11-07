using hotelsphere.Models;
using hotelsphere.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.UserControls
{
    public partial class UC_RoomType_Chien : UserControl
    {
        public event EventHandler<string> RoomSelected;
        public string TenPhong { get => lblTenPhong_Chien.Text; set => lblTenPhong_Chien.Text = value; }
        public int? IdStaff { get; private set; }
        public UC_RoomType_Chien(int? idStaff)
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.LightGray;
            this.Width = 175;
            this.Height = 100;
            RoundPanel(panel1, 20);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            this.BorderStyle = BorderStyle.None;
            IdStaff = idStaff;
        }
        private void RoundPanel(Panel panel, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            panel.Region = new Region(path);
        }
        public void SetRoomInfo(string roomType, string roomName, string status, string customerName = null)
        {
            lblLoaiPhong_Chien.Text = roomType;
            lblTenPhong_Chien.Text = roomName;

            // Nếu phòng đang thuê, hiển thị tên khách hàng
            if (status == "Đang thuê" && !string.IsNullOrEmpty(customerName))
            {
                lblTinhTrang_Chien.Text = customerName;
            }
            else
            {
                lblTinhTrang_Chien.Text = status;  // Nếu không thì hiển thị trạng thái phòng
            }

            // Gọi SetRoomStatus để cập nhật màu sắc
            SetRoomStatus(status);
        }

        public void SetRoomStatus(string status)
        {
            // Kiểm tra trạng thái phòng và áp dụng màu sắc và icon phù hợp
            if (status == "Trống")
            {
                panel1.BackColor = ColorTranslator.FromHtml("#2A73CC");  // Xanh dương cho phòng trống
                pictureBox1.Image = Properties.Resources.icon_verify;
            }
            else if (status == "Đang thuê")
            {
                panel1.BackColor = ColorTranslator.FromHtml("#FFA726");  // Vàng cho phòng đang thuê
                pictureBox1.Image = Properties.Resources.icon_customer;
            }
            else
            {
                panel1.BackColor = ColorTranslator.FromHtml("#D32F2F");  // Đỏ cho trạng thái khác
                pictureBox1.Image = Properties.Resources.icon_customer;
            }
        }


        private void panel1_Click(object sender, EventArgs e)
        {
            if (lblTinhTrang_Chien.Text == "Trống")
            {
                RoomSelected?.Invoke(this, lblTenPhong_Chien.Text);
            }
            else if (lblTinhTrang_Chien.Text == "Đang thuê")
            {
                MessageBox.Show("Phòng hiện đang được thuê. Vui lòng chọn phòng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
