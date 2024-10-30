using hotelsphere.Models;
using hotelsphere.View;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace hotelsphere.Controller
{
    public class loginController
    {
        private DB_Chien db;

        public loginController()
        {
            db = new DB_Chien();
        }

        public void processLogin_Chien(staffModel_Chien staff, frmLogin_Chien currentForm)
        {
            string query = "SELECT * FROM staff WHERE taikhoan = @username AND matkhau = @matkhau";
            SqlParameter[] sp =
            {
                new SqlParameter("@username", staff.Taikhoan_Chien),
                new SqlParameter("@matkhau", staff.MatKhau_Chien),
            };
            DataTable result = db.ExecuteQuery(query, sp);
            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                string idStaff = row["id_staff"].ToString();
                string nameStaff = row["hoten"].ToString();
                string roleFromDb = row["role"].ToString();
                if (roleFromDb.Equals("staff", StringComparison.OrdinalIgnoreCase) && staff.Role_Chien.Equals("staff", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        iStaff_Chien staffForm = new iStaff_Chien();
                        staffForm.SetStaffInfo(nameStaff);
                        staffForm.Show();
                        currentForm.Hide(); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi khi mở form iStaff_Chien: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (roleFromDb.Equals("admin", StringComparison.OrdinalIgnoreCase) && staff.Role_Chien.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    iAdmin_Chien adminForm = new iAdmin_Chien();
                    adminForm.Show();
                    currentForm.Hide(); 
                }
                else
                {
                    MessageBox.Show("Vai trò không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
