using hotelsphere.Controller.ADMIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.UserControls.ADMIN
{
    public partial class UC_RoomType_Admin_Chien : UserControl
    {

        public roomtypeController_Hung rTc; 
        public UC_RoomType_Admin_Chien()
        {
            InitializeComponent();
            rTc = new roomtypeController_Hung();
            tabRoomType.SelectedTab = tabDanhSach;
            tabRoomType.TabPages.Remove(tabChucNang);
            dgvRoomType_Hung.AutoGenerateColumns = false;
            LoadAllRoomType_Hung();
        }

        public void LoadAllRoomType_Hung()
        {
            var customers = rTc.LayDataLoaiPhong();
            dgvRoomType_Hung.DataSource = customers;
        }

        private void txtSearchRoomType_Chien_TextChanged(object sender, EventArgs e)
        {
            string tim = txtSearchRoomType_Chien.Text;
            DataTable ketqua = rTc.TimKiemLoaiPhong(tim);

            if (ketqua.Rows.Count > 0)
            {
                dgvRoomType_Hung.DataSource = ketqua;
            }
        }
    }
}
