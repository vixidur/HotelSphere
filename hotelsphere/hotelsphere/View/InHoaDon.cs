using hotelsphere.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.View
{
    public partial class InHoaDon : Form
    {
        public string CustomerName { get; set; }
        public int InvoiceNumber { get; set; }
        public string RoomName { get; set; }
        public int TotalDays { get; set; }
        public string RoomType { get; set; }
        public string StaffName { get; set; }
        public decimal TotalRoomPrice { get; set; }
        public decimal TotalServicePrice { get; set; }
        servicesController serviceController;
        public InHoaDon()
        {
            serviceController = new servicesController();
            InitializeComponent();
        }

        public void HienthiHoaDonChiTiet()
        {
            lblCustomerName_Chien.Text = CustomerName;
            lblNgayLapHoaDon_Khanh.Text = "Ngày lập hoá đơn: " + DateTime.Now.ToString();
            lblSoHoaDon_Hung.Text = "Số hoá đơn: " + InvoiceNumber.ToString();
            lblTenPhong_TAnh.Text = "Số phòng: " + RoomName;
            lblSoNgayThue_Chien.Text = "Số ngày " + TotalDays.ToString();
            lblLoaiPhong_Chien.Text = "Loại phòng: " + RoomType;
            lblNameStaff_Chien.Text = "Nhân viên: " + StaffName;
            lblTongTienThuePhong.Text = TotalRoomPrice.ToString("N0");
            lblTongGiaDichVu.Text = TotalServicePrice.ToString("N0");

            // Hiển thị dịch vụ sử dụng trong bảng
            DataTable serviceDetails = serviceController.LayDataService_Chien(); // Lấy dữ liệu dịch vụ
            dgvDichVuHoaDon_Chien.DataSource = serviceDetails;

            // Hiển thị tổng tiền
            lblTongTien.Text = (TotalRoomPrice + TotalServicePrice).ToString("N0") + " VNĐ";
        }

        //private void panel3_Paint(object sender, PaintEventArgs e)
        //{

        //}
    }
}
