using hotelsphere.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotelsphere.Models;
using Guna.UI2.AnimatorNS;
using hotelsphere.View;
namespace hotelsphere.UserControls
{
    public partial class UC_Room_Chien : UserControl
    {
        public event EventHandler RoomSelected;
        private roomController roomController;
        private customerModel_Chien customerModel;
        public UC_Room_Chien(customerModel_Chien customer)
        {
            InitializeComponent();
            roomController = new roomController();
            customerModel = customer; // Gán customerModel trước
            LoadCustomerData(); // Gọi LoadCustomerData() sau khi customerModel đã được gán
            LoadRooms();
        }

        private void UC_Room_Chien_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        public void LoadRooms()
        {
            flpRooms_Chien.Controls.Clear();
            int? roomTypeId = LayIDRoomType_Chien();
            string status = LayStatusRoom_Chien();
            List<RoomModel_Chien> rooms = roomController.LocRoom_Chien(roomTypeId, status);

            foreach (RoomModel_Chien room in rooms)
            {
                UC_RoomType_Chien roomControl = new UC_RoomType_Chien();
                roomControl.SetRoomStatus(room.TinhTrang_Chien);
                roomControl.SetRoomInfo(room.LoaiPhong_Chien, room.TenPhong_Chien, room.TinhTrang_Chien);
                roomControl.RoomSelected += (s, roomName) =>
                {
                    if (roomTypeId.HasValue && roomTypeId.Value > 0)
                    {
                        decimal roomPrice = roomController.LayGiaTienTheoIDRoom_Chien(roomTypeId.Value);
                        ThongTinHoaDon_Chien thongTinHoaDon = new ThongTinHoaDon_Chien(this.roomController, this, customerModel)
                        {
                            CustomerName_Chien = TenKhachHang,
                            RoomType_Chien = room.LoaiPhong_Chien,
                            StatusRoom_Chien = room.TinhTrang_Chien,
                            RentDate_Chien = DateTime.Now,
                            ReturnDate_Chien = DateTime.Now.AddDays(1),
                            PriceRoom_Chien = roomPrice,
                            TenPhong = roomName 
                        };
                        thongTinHoaDon.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Loại phòng không hợp lệ hoặc giá phòng không xác định.");
                    }
                };
                flpRooms_Chien.Controls.Add(roomControl);
            }
        }

        private int? LayIDRoomType_Chien()
        {
            switch (cbRoomType_Chien.SelectedItem?.ToString())
            {
                case "1 Người":
                    return 1;
                case "2 Người":
                    return 2;
                case "Gia đình":
                    return 3;
                case "Phòng Cao Cấp":
                    return 4;
                case "Tất cả":
                    return null;
                default:
                    return null;
            }
        }

        public int? LoaiPhong
        {
            get { return LayIDRoomType_Chien(); }
        }

        public string TrangThaiPhong
        {
            get { return LayStatusRoom_Chien(); }
        }

        public string TenLoaiPhong
        {
            get { return cbRoomType_Chien.SelectedItem?.ToString(); }
        }

        private string LayStatusRoom_Chien()
        {
            if (EmptyRoom_Chien.Checked)
                return "Trống";
            else if (RentingRoom_Chien.Checked)
                return "Đang thuê";
            else
                return null; 
        }
        private void LoadRoomsEmptyOrRenting_Chien()
        {
            flpRooms_Chien.Controls.Clear(); 

            if (EmptyRoom_Chien.Checked) 
            {
                List<RoomModel_Chien> emptyRooms = roomController.GetRoomsByEmptyOrRenting("Trống");

                foreach (RoomModel_Chien room in emptyRooms)
                {
                    UC_RoomType_Chien roomControl = new UC_RoomType_Chien();
                    roomControl.SetRoomStatus(room.TinhTrang_Chien);
                    roomControl.SetRoomInfo(room.LoaiPhong_Chien, room.TenPhong_Chien, room.TinhTrang_Chien);
                    flpRooms_Chien.Controls.Add(roomControl);
                }
            }
            else if (RentingRoom_Chien.Checked)
            {
                List<RoomModel_Chien> rentingRooms = roomController.GetRoomsByEmptyOrRenting("Đang thuê");

                foreach (RoomModel_Chien room in rentingRooms)
                {
                    UC_RoomType_Chien roomControl = new UC_RoomType_Chien();
                    roomControl.SetRoomStatus(room.TinhTrang_Chien);
                    roomControl.SetRoomInfo(room.LoaiPhong_Chien, room.TenPhong_Chien, room.TinhTrang_Chien);
                    flpRooms_Chien.Controls.Add(roomControl);
                }
            }
        }


        private void allRoom_Chien_CheckedChanged(object sender, EventArgs e)
        {
            if (allRoom_Chien.Checked)
            {
                LoadRooms(); 
            }
        }

        private void EmptyRoom_Chien_CheckedChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void RentingRoom_Chien_CheckedChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void cbRoomType_Chien_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRooms();
        }

        public string TenKhachHang { get; set; }
        public void LoadCustomerData()
        {
            if (customerModel != null) // Kiểm tra xem customerModel có khác null không
            {
                lblSoCCCD_Chien.Text = customerModel.SoCCCD;
                lblTenCustomer_Chien.Text = customerModel.NameCustomer;
                lblQuocTich_Chien.Text = customerModel.QuocTich;
            }
            else
            {
                MessageBox.Show("Thông tin khách hàng không có sẵn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string LoadDataService_Chien()
        {
            return TenKhachHang = customerModel.NameCustomer;
        }
    }
}
