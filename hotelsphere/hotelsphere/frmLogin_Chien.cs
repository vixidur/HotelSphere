using hotelsphere.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using hotelsphere.Controller;
namespace hotelsphere
{
    public partial class frmLogin_Chien : Form
    {
        public frmLogin_Chien()
        {
            InitializeComponent();
            //this.KeyDown += new KeyEventHandler(frmLogin_Chien_KeyDown);
            //this.KeyPreview = true;
            cbRole_Chien.SelectedItem = "admin";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Login_Chien()
        {
            string username = txtUserName_Chien.Text.Trim();
            string password = txtPassword_Chien.Text.Trim();
            string role = cbRole_Chien.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            staffModel_Chien staff = new staffModel_Chien
            {
                Taikhoan_Chien = username,
                MatKhau_Chien = password,
                Role_Chien = role
            };
            loginController controller = new loginController();
            controller.processLogin_Chien(staff, this);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Login_Chien();
        }

        private void frmLogin_Chien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !guna2Button1.Focused) // Chỉ gọi nếu nút không được chọn
            {
                Login_Chien();
            }
        }
    }
}
