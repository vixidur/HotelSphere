using hotelsphere.Controller;
using hotelsphere.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.View
{
    public partial class ThongTinHoaDon_Chien : Form
    {
        servicesController serviceController = new servicesController();
        public string CustomerName_Chien { get => lblNameCustomer_Chien.Text; set => lblNameCustomer_Chien.Text = value; }
        public string RoomType_Chien { get => lblRoomType_Chien.Text; set => lblRoomType_Chien.Text = value; }
        public string StatusRoom_Chien { get => lblStatusRoom_Chien.Text; set => lblStatusRoom_Chien.Text = value; }
        public DateTime RentDate_Chien { get; set; }
        public DateTime ReturnDate_Chien { get; set; }
        public string TenPhong { get => lblTenPhong_Chien.Text; set => lblTenPhong_Chien.Text = value; }
        private decimal priceRoom;
        public decimal PriceRoom_Chien
        {
            get => priceRoom;
            set
            {
                priceRoom = value;
                lblPriceRoom_Chien.Text = priceRoom.ToString("N2") + " VNĐ"; 
            }
        }

        private void TinhSoNgayThue()
        {
            if (RentDate_Chien != null && ReturnDate_Chien != null)
            {
                int songaythue = (ReturnDate_Chien - RentDate_Chien).Days + 2;
                lblSoNgayThue_Chien.Text = songaythue > 0 ? "Số ngày thuê: " + songaythue.ToString() : "Vui lòng chọn lại!";
            }
        }

        public ThongTinHoaDon_Chien()
        {
            InitializeComponent();
            lblDateRent_Chien.Text = DateTime.Now.ToShortDateString();
            RoundPanel(panel_Chien, 20);

            RentDate_Chien = DateTime.Now;
            dtpNgayTraPhong.Value = RentDate_Chien.AddDays(1);
            ReturnDate_Chien = dtpNgayTraPhong.Value;
            TinhSoNgayThue();
            dtpNgayTraPhong.ValueChanged += (s, e) =>
            {
                ReturnDate_Chien = dtpNgayTraPhong.Value;
                TinhSoNgayThue();
            };
        }

        private void CapNhatTongTien_Chien()
        {
            decimal total = serviceController.TinhTongThanhTien();
            lblCalcService_Chien.Text = total.ToString("N2") + " VND";
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinHoaDon_Chien_Load(object sender, EventArgs e)
        {
            lblNameCustomer_Chien.Text = CustomerName_Chien;
            lblDateRent_Chien.Text = DateTime.Now.ToShortDateString();
            cbNameService_Chien.DataSource = serviceController.GetTenDichVu_Chien();
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "HÀNH ĐỘNG";
            imgColumn.HeaderText = "HÀNH ĐỘNG";
            imgColumn.Image = Properties.Resources.icon_remove;
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvServiceRoom_Chien.Columns.Add(imgColumn);
        }

        private void cbNameService_Chien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedServiceName = cbNameService_Chien.SelectedItem.ToString();
            decimal servicePrice = serviceController.GetGiaDichVu_Chien(selectedServiceName);
            ServicePrice_Chien.Text = servicePrice.ToString("N0");
        }

        private void btnSaveService_Chien_Click(object sender, EventArgs e)
        {
            try
            {
                string tenDichVu = cbNameService_Chien.SelectedItem.ToString();
                decimal giaDichVu = decimal.Parse(ServicePrice_Chien.Text);
                int soLuong = (int)nudSoluong.Value;
                int idDichVu = serviceController.LayIDServiceTheoTen(tenDichVu);
                serviceController.ThemCTDichVu(idDichVu, tenDichVu, giaDichVu, soLuong);
                var dataSource = serviceController.LayDataService_Chien();
                dgvServiceRoom_Chien.DataSource = dataSource;
                if (dgvServiceRoom_Chien.Columns.Contains("id_dichvu"))
                {
                    dgvServiceRoom_Chien.Columns["id_dichvu"].Visible = false;
                }
                CapNhatTongTien_Chien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void dgvServiceRoom_Chien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvServiceRoom_Chien.Columns["HÀNH ĐỘNG"].Index)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (dgvServiceRoom_Chien.Columns.Contains("id_dichvu"))
                    {
                        var cellValue = dgvServiceRoom_Chien.Rows[e.RowIndex].Cells["id_dichvu"].Value;
                        if (cellValue != null && int.TryParse(cellValue.ToString(), out int idDichVu))
                        {
                            serviceController.XoaDichVu_Chien(idDichVu);
                            dgvServiceRoom_Chien.DataSource = serviceController.LayDataService_Chien();
                            CapNhatTongTien_Chien();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xoá một hàng trống!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cột id_dichvu không tồn tại!");
                    }
                }
            }
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

        private void label2_Click(object sender, EventArgs e)
        {
            serviceController.XoaAll_Chien();
            CapNhatTongTien_Chien();
            dgvServiceRoom_Chien.DataSource = serviceController.LayDataService_Chien();
        }
    }
}
