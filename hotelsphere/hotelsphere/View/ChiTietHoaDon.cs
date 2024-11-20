using hotelsphere.Controller.ADMIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.View
{
    public partial class ChiTietHoaDon : Form
    {
        private Timer fadeInTimer;
        private double opacityIncrement = 0.05;
        private hoadonController_Chien hd; 
        public ChiTietHoaDon(int mahoadon)
        {
            //MessageBox.Show("check ma: " + mahoadon);
            InitializeComponent();
            hd = new hoadonController_Chien();
            lblMaHoaDon.Text = "Số hoá đơn: " + mahoadon.ToString();
            try
            {
                lblTenPhong_Chien.Text = "Tên phòng: " + hd.LayTenPhongTheoIdHoaDon(mahoadon);
                lblLoaiPhong.Text = "Loại phòng: " + hd.LayLoaiPhongTheoIdHoaDon(mahoadon);
                lblGiaPhong.Text = "Giá phòng/ngày: " + hd.LayGiaPhongTheoIdHoaDon(mahoadon) + " VNĐ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadAllDichVu_Chien(mahoadon);

            this.Opacity = 0;
            fadeInTimer = new Timer();
            fadeInTimer.Interval = 10;
            fadeInTimer.Tick += new EventHandler(FadeInTimer_Tick);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fadeInTimer.Start();
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += opacityIncrement;
            }
            else
            {
                fadeInTimer.Stop();
            }
        }

        public void LoadAllDichVu_Chien(int mahoadon)
        {
            var dt = hd.LayDataDichVuTheoIdHoaDon_Chien(mahoadon);
            dgvChiTietHoaDon_Chien.DataSource = dt;
        }

    }
}
