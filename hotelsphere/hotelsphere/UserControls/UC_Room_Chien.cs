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
        }

        private void UC_Room_Chien_Load(object sender, EventArgs e)
        {
            LoadRooms();
        }

        private void LoadRooms(int? roomTypeId = null)
        {
            flpRooms_Chien.Controls.Clear(); 

            List<RoomModel_Chien> rooms = roomController.GetRoomsByType(roomTypeId);

            foreach (RoomModel_Chien room in rooms)
            {
                UC_RoomType_Chien roomControl = new UC_RoomType_Chien();
                roomControl.SetRoomStatus(room.TinhTrang_Chien);
                roomControl.SetRoomInfo(room.LoaiPhong_Chien, room.TenPhong_Chien, room.TinhTrang_Chien);
                flpRooms_Chien.Controls.Add(roomControl);
            }
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
                LoadRooms(null); 
            }
        }

        private void SingleRoom_Chien_CheckedChanged(object sender, EventArgs e)
        {
            if (SingleRoom_Chien.Checked)
            {
                LoadRooms(1);
            }
        }

        private void DoubleRoom_Chien_CheckedChanged(object sender, EventArgs e)
        {
            if (DoubleRoom_Chien.Checked)
            {
                LoadRooms(2);
            }
        }

        private void FamilyRoom_Chien_CheckedChanged(object sender, EventArgs e)
        {
            if (FamilyRoom_Chien.Checked)
            {
                LoadRooms(3);
            }
        }

        private void SuiteRoom_Chien_CheckedChanged(object sender, EventArgs e)
        {
            if (SuiteRoom_Chien.Checked)
            {
                LoadRooms(4);
            }
        }

        private void EmptyRoom_Chien_CheckedChanged(object sender, EventArgs e)
        {
            LoadRoomsEmptyOrRenting_Chien();
        }
    }
}
