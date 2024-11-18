using hotelsphere.UserControls;
using hotelsphere.UserControls.ADMIN;
using hotelsphere.UserControls.ADMIN.REPORTS;
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
    public partial class iAdmin_Chien : Form
    {
        public iAdmin_Chien()
        {
            InitializeComponent();
            panelHistory = new Stack<UserControl>();
            UC_Home_Chien uC_Home_Chien = new UC_Home_Chien();
            ThemUserControl(uC_Home_Chien);
        }
        private Stack<UserControl> panelHistory;

        public void ThemUserControl(UserControl user)
        {
            if (panlContainer_Chien.Controls.Count > 0)
            {
                UserControl currentControl = panlContainer_Chien.Controls[0] as UserControl;
                panelHistory.Push(currentControl);
            }

            panlContainer_Chien.Controls.Clear();
            user.Dock = DockStyle.Fill;
            panlContainer_Chien.Controls.Add(user);
            user.BringToFront();
        }

        private void btnTrangChu_Hung_Click(object sender, EventArgs e)
        {
            UC_Home_Chien uC_Home_Chien = new UC_Home_Chien();
            ThemUserControl(uC_Home_Chien);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_Home_Chien uC_Home_Chien = new UC_Home_Chien();
            ThemUserControl(uC_Home_Chien);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin_Chien loginForm = new frmLogin_Chien();
                loginForm.Show();
                this.Close();
            }
        }

        public void SetAdminInfo_Chien(string nameAdmin)
        {
            label2.Text = "Xin chào, " + nameAdmin;
        }

        private void btnLoaiPhong_Hung_Click(object sender, EventArgs e)
        {
            UC_RoomType_Admin_Chien roomtype = new UC_RoomType_Admin_Chien();
            ThemUserControl(roomtype);
        }

        private void btnPhong_Hung_Click(object sender, EventArgs e)
        {
            UC_Room_Admin_Chien room = new UC_Room_Admin_Chien();
            ThemUserControl(room);
        }

        private void btnDichVu_Hung_Click(object sender, EventArgs e)
        {
            UC_Services_Admin_Khanh services = new UC_Services_Admin_Khanh();
            ThemUserControl(services);
        }

        private void btnStaff_Hung_Click(object sender, EventArgs e)
        {
            UC_Staff_Admin_Chien staff = new UC_Staff_Admin_Chien();
            ThemUserControl(staff);
        }

        private void btnHoaDon_Hung_Click(object sender, EventArgs e)
        {
            UC_HoaDon_Hung hoadon = new UC_HoaDon_Hung();
            ThemUserControl(hoadon);
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            UC_Setting_Chien uC_Setting_Chien = new UC_Setting_Chien();
            ThemUserControl(uC_Setting_Chien);
        }


        bool morong = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(morong == false)
            {
                panel6.Height += 15;
                if(panel6.Height >= panel6.MaximumSize.Height)
                {
                    timer1.Stop();
                    morong = true;
                }
            }
            else
            {
                panel6.Height -= 15;
                if(panel6.Height <= panel6.MinimumSize.Height)
                {
                    timer1.Stop();
                    morong = false;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            UC_Reports_Chien reports = new UC_Reports_Chien();
            ThemUserControl(reports);
        }

        private void btnTkCustomer_Chien_Click(object sender, EventArgs e)
        {
            UC_Reports_Customer_Chien reportsCus = new UC_Reports_Customer_Chien();
            ThemUserControl(reportsCus);
        }
    }
}
