using hotelsphere.Controller;
using hotelsphere.Models;
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
        invoiceController hoadonController;
        private int? currentCustomerId; 
        private int? currentRoomId;
        private string TenNhanVien { get; set; }
        public string CustomerName_Chien { get => lblNameCustomer_Chien.Text; set => lblNameCustomer_Chien.Text = value; }
        public string RoomType_Chien { get => lblRoomType_Chien.Text; set => lblRoomType_Chien.Text = value; }
        public string StatusRoom_Chien { get => lblStatusRoom_Chien.Text; set => lblStatusRoom_Chien.Text = value; }
        public DateTime RentDate_Chien { get; set; }
        public DateTime ReturnDate_Chien { get; set; }
        public string TenPhong { get => lblTenPhong_Chien.Text; set => lblTenPhong_Chien.Text = value; }
        private decimal priceRoom;
        //public int? IdStaff { get; set; }
        //// phương thức để thiết lập idStaff khi mở form
        //public void SetIdStaff(int? idStaff)
        //{
        //    this.IdStaff = idStaff;
        //}
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
                int songaythue = (ReturnDate_Chien - RentDate_Chien).Days + 1;
                lblSoNgayThue_Chien.Text = songaythue > 0 ? "Số ngày thuê: " + songaythue.ToString() : "Vui lòng chọn lại!";
            }
        }
        public ThongTinHoaDon_Chien(roomController controller, UC_Room_Chien ucRoomChien, customerModel_Chien customer, int? idStaff, string tenNhanVien)
        {
            InitializeComponent();
            lblNameCustomer_Chien.Text = ucRoomChien.TenKhachHang;
            currentCustomerId = customer.Id_Customer;
            lblDateRent_Chien.Text = DateTime.Now.ToShortDateString();
            RoundPanel(panel_Chien, 20);

            this.roomController = controller; 
            this.ucRoomChien = new UC_Room_Chien(customer, idStaff, TenNhanVien); 

            RentDate_Chien = DateTime.Now;
            dtpNgayTraPhong.Value = RentDate_Chien.AddDays(1);
            ReturnDate_Chien = dtpNgayTraPhong.Value;
            TinhSoNgayThue();

            dtpNgayTraPhong.ValueChanged += (s, e) =>
            {
                ReturnDate_Chien = dtpNgayTraPhong.Value;
                TinhSoNgayThue();
            };

            hoadonController = new invoiceController();
            ucRoomChien.IdStaff = idStaff;
            TenNhanVien = tenNhanVien;
        }
        private void CapNhatTongTien_Chien()
        {
            decimal total = serviceController.TinhTongDichVu();
            lblCalcService_Chien.Text = total.ToString("N2") + " VND";
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongTinHoaDon_Chien_Load(object sender, EventArgs e)
        {
            lblNameCustomer_Chien.Text = ucRoomChien.LoadDataService_Chien();
            lblDateRent_Chien.Text = DateTime.Now.ToShortDateString();
            cbNameService_Chien.DataSource = serviceController.GetTenDichVu_Chien();
            lblTenNhanVien_Chien.Text = TenNhanVien;
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
        private UC_Room_Chien ucRoomChien;
        private roomController roomController;

        private List<DichVuModel> dsDichVu(DataTable dt)
        {
            List<DichVuModel> list = new List<DichVuModel>();

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu dịch vụ để xử lý.");
                return list;
            }

            // Kiểm tra cột trước khi đọc dữ liệu
            if (!dt.Columns.Contains("id_dichvu") || !dt.Columns.Contains("dongia"))
            {
                MessageBox.Show("Thiếu cột 'id_dichvu' hoặc 'dongia' trong dữ liệu dịch vụ.");
                return list;
            }

            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    DichVuModel model = new DichVuModel()
                    {
                        IdDichVu = Convert.ToInt32(row["id_dichvu"]),
                        DonGia = Convert.ToDecimal(row["dongia"])
                    };
                    list.Add(model);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xử lý dữ liệu dịch vụ: " + ex.Message);
                }
            }

            return list;
        }


        //iStaff_Chien staffModel_Chien;
        private void btnComfirmRent_Chien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CustomerName_Chien: " + CustomerName_Chien);
            if (string.IsNullOrEmpty(TenPhong) || string.IsNullOrEmpty(CustomerName_Chien))
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin đặt phòng.");
                return;
            }

            bool success = roomController.CapNhatTrangThaiPhong_Chien(TenPhong, "Đang thuê");
            if (success)
            {
                Xacnhanthuephong();
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái phòng không thành công.");
            }
        }

        private void Xacnhanthuephong()
        {
            currentRoomId = roomController.GetRoomIdByName(TenPhong);
            int totalDays = (ReturnDate_Chien - RentDate_Chien).Days + 1;

            decimal totalRoomPrice = PriceRoom_Chien * totalDays;
            decimal totalServicePrice = serviceController.TinhTongDichVu();
            decimal totalInvoiceAmount = totalRoomPrice + totalServicePrice;

            int invoiceId = hoadonController.ThemHoaDon(
                currentCustomerId,
                ucRoomChien.IdStaff,
                currentRoomId,
                PriceRoom_Chien,
                RentDate_Chien,
                ReturnDate_Chien,
                totalInvoiceAmount
            );

            //HTHoaDonCT(invoiceId, totalRoomPrice, totalServicePrice);
            if (invoiceId > 0)
            {
                //LuuCTDichVu(invoiceId);
                // Hiển thị hóa đơn
                InHoaDon inHoaDonForm = new InHoaDon
                {
                    CustomerName = CustomerName_Chien,
                    InvoiceNumber = invoiceId,
                    RoomName = TenPhong,
                    TotalDays = totalDays,
                    RoomType = RoomType_Chien,
                    StaffName = TenNhanVien,
                    TotalRoomPrice = totalRoomPrice,
                    TotalServicePrice = totalServicePrice
                };
                MessageBox.Show($"Ten Khach Hang: {CustomerName_Chien}"
                    +$"\nSo hoa don: {invoiceId}"
                    +$"\nTen phong: {TenPhong}"
                    +$"\nso ngay thue {totalDays}"
                    +$"\nloai phong: {RoomType_Chien}"
                    +$"\nten nhan vien: {TenNhanVien}"
                    +$"\nTien  thue phong: {totalRoomPrice}"
                    +$"\ntien dich vu: {totalServicePrice}");
                inHoaDonForm.HienthiHoaDonChiTiet();
                inHoaDonForm.ShowDialog();


                ucRoomChien.LoadRooms(); 
                MessageBox.Show("Đặt phòng thành công!");
                Close();
            }
            else
            {
                MessageBox.Show("Đặt phòng không thành công. Vui lòng thử lại.");
            }

        }

        private void LuuCTDichVu(int invoiceId)
        {
            var dataTable = serviceController.LayDataService_Chien();
            List<DichVuModel> serviceList = new List<DichVuModel>();

            foreach (DataRow row in dataTable.Rows)
            {
                var service = new DichVuModel
                {
                    IdDichVu = Convert.ToInt32(row["id_dichvu"]),
                    TenDichVu = row["tendichvu"].ToString(),
                    DonGia = Convert.ToDecimal(row["dongia"]),
                    SoLuongSuDung = Convert.ToInt32(row["soluong"]),
                };
                serviceList.Add(service);
            }

            foreach (var service in serviceList)
            {
                hoadonController.ThemCTHoaDon(service.IdDichVu, invoiceId, service.DonGia, service.SoLuongSuDung);
            }
        }

        private void HTHoaDonCT(int invoiceId, decimal totalRoomPrice, decimal totalServicePrice)
        {
            MessageBox.Show($"idHoaDon: {invoiceId}\n" +
                             $"currentCustomerId: {currentCustomerId}\n" +
                             $"idStaff: {ucRoomChien.IdStaff}\n" +
                             $"currentRoomId: {currentRoomId}\n" +
                             $"Giá phòng 1 ngày: {PriceRoom_Chien}\n" +
                             $"Ngày thuê phòng: {RentDate_Chien}\n" +
                             $"Ngày trả phòng: {ReturnDate_Chien}\n" +
                             $"Thành tiền: {totalRoomPrice + totalServicePrice}\n" +
                             $"Tổng tiền thuê phòng: {totalRoomPrice}\n" +
                             $"Tổng tiền dịch vụ: {totalServicePrice}");
        }
    }
}
