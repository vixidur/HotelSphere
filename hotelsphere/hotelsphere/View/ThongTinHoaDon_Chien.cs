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

        public ThongTinHoaDon_Chien()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        UC_Room_Chien uC_Room_Chien = new UC_Room_Chien();
        public string CustomerName_Chien { get; set; }
        private void ThongTinHoaDon_Chien_Load(object sender, EventArgs e)
        {
            lblNameCustomer_Chien.Text = CustomerName_Chien;
            lblDateRent_Chien.Text = DateTime.Now.ToShortDateString();
        }
    }
}
