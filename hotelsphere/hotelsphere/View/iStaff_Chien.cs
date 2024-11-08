using hotelsphere.Models;
using hotelsphere.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.View
{
    public partial class iStaff_Chien : Form
    {
        public int? IdStaff { get; set; }
        staffModel_Chien staffModel_Chien;

        public iStaff_Chien(int? idStaff)
        {
            InitializeComponent();
            timer1.Start();
            UC_Home_Chien uC_Home_Chien = new UC_Home_Chien();
            panelHistory = new Stack<UserControl>();
            ThemUserControl(uC_Home_Chien);
            notify_Chien.Visible = false;
            RoundPanel(notify_Chien, 20);
            staffModel_Chien = new staffModel_Chien();
            IdStaff = idStaff;
        }

        private Stack<UserControl> panelHistory;

        private void timer1_Tick(object sender, EventArgs e)
        {

        }


        public void ThemUserControl(UserControl user)
        {
            if (panelContainer.Controls.Count > 0)
            {
                UserControl currentControl = panelContainer.Controls[0] as UserControl;
                panelHistory.Push(currentControl);
            }

            panelContainer.Controls.Clear();
            user.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(user);
            user.BringToFront();
        }

        public void BackToPreviousControl()
        {
            if (panelHistory.Count > 0)
            {
                UserControl previousControl = panelHistory.Pop();
                panelContainer.Controls.Clear();
                panelContainer.Controls.Add(previousControl);
                previousControl.BringToFront();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Customer_Chien uC_Customer_Chien = new UC_Customer_Chien(this, IdStaff);
            ThemUserControl(uC_Customer_Chien);
        }
        public string TenNhanVien { get; set; }
        public customerModel_Chien customerModel;
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            customerModel = new customerModel_Chien
            {
                Id_Customer = 1,
                SoCCCD = "Chưa rõ",
                NameCustomer = "Chưa rõ",
                QuocTich = "Chưa rõ"
            };
            UC_Room_Chien uC_Room_Chien = new UC_Room_Chien(customerModel, IdStaff, TenNhanVien);
            ThemUserControl(uC_Room_Chien);
        }

        private void iStaff_Chien_Load(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_Home_Chien uC_Home_Chien = new UC_Home_Chien();
            ThemUserControl(uC_Home_Chien);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            UC_Home_Chien uC_Home_Chien = new UC_Home_Chien();
            ThemUserControl(uC_Home_Chien);
        }


        private void guna2CirclePictureBox3_Click(object sender, EventArgs e)
        {
            if (!notify_Chien.Visible)
            {
                notify_Chien.Visible = true;
                notify_Chien.Height = 0;
                notify_Chien.BringToFront();
                notify_Chien.Width = 258;

                Timer timer = new Timer();
                timer.Interval = 10;
                timer.Tick += (s, args) =>
                {
                    if (notify_Chien.Height < 119)
                    {
                        notify_Chien.Height += 50;
                    }
                    else
                    {
                        timer.Stop();
                    }
                };
                timer.Start();
            }
            else
            {
                Timer timer = new Timer();
                timer.Interval = 10;
                timer.Tick += (s, args) =>
                {
                    if (notify_Chien.Height > 0)
                    {
                        notify_Chien.Height -= 50;
                    }
                    else
                    {
                        notify_Chien.Visible = false;
                        timer.Stop();
                    }
                };
                timer.Start();
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

        public void SetStaffInfo(string nameStaff, int? idStaff)
        {
            IdStaff = idStaff;
            label2.Text = "Xin chào, " + nameStaff;
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            UC_Setting_Chien uC_Setting_Chien = new UC_Setting_Chien();
            ThemUserControl(uC_Setting_Chien);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
