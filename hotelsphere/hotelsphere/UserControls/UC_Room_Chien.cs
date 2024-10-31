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
namespace hotelsphere.UserControls
{
    public partial class UC_Room_Chien : UserControl
    {
        private roomController roomController;
        public UC_Room_Chien()
        {
            InitializeComponent();
            roomController = new roomController();
            //cbRoomType_Chien.SelectedItem = "1 Người";
            LoadRooms();
        }

        private void UC_Room_Chien_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void LoadRooms()
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


        private string LayStatusRoom_Chien()
        {
            if (EmptyRoom_Chien.Checked)
                return "Trống";
            else if (RentingRoom_Chien.Checked)
                return "Đang thuê";
            else
                return null; // Trường hợp tất cả phòng
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
    }
}
