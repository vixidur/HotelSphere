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
    public partial class UC_HoaDon_Hung : UserControl
    {
        private hoadonController_Chien hd;
        public UC_HoaDon_Hung()
        {
            InitializeComponent();
            hd = new hoadonController_Chien();
            LoadDataHoaDon_Chien();
        }

        public void LoadDataHoaDon_Chien()
        {
            var room = hd.LayDataHoaDon_Chien();
            dgvHoaDon_Chien.DataSource = room;
        }

        private void dgvHoaDon_Chien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
