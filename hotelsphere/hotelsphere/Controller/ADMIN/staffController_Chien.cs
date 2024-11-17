using hotelsphere.Models.ADMIN;
using hotelsphere.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.Controller.ADMIN
{
    public class staffController_Chien
    {
        public DB_Chien db;
        public staffController_Chien()
        {
            db = new DB_Chien();
        }
        public List<string> LayTaiKhoanChuaTonTai()
        {
            List<string> danhSachGoiY = new List<string>();
            string[] dsKiTu = { "nhanvien", "user", "admin", "guest", "member", "test", "s", "d", "x", "y", "z" };
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                string kitu = dsKiTu[random.Next(dsKiTu.Length)];
                int so = random.Next(1, 100);
                danhSachGoiY.Add($"{kitu}{so}");
            }

            string query = "SELECT taikhoan FROM staff";
            DataTable dt = db.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                string taiKhoanChuaTonTai = row["taikhoan"].ToString();
                if (danhSachGoiY.Contains(taiKhoanChuaTonTai))
                {
                    danhSachGoiY.Remove(taiKhoanChuaTonTai);
                }
            }

            return danhSachGoiY;
        }

        public bool KiemTraTrungTaiKhoan(string taikhoan)
        {
            string query = "SELECT COUNT(*) FROM staff WHERE taikhoan = @taikhoan";
            SqlParameter[] parameters = { new SqlParameter("@taikhoan", taikhoan) };

            object result = db.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }
        public void AddStaff_Chien(StaffModel_Chien staff)
        {
            try
            {
                // Kiểm tra tài khoản đã tồn tại hay chưa
                if (KiemTraTrungTaiKhoan(staff.TaiKhoan_Chien))
                {
                    throw new Exception("Tài khoản này đã tồn tại. Vui lòng nhập tài khoản khác.");
                }

                // Câu lệnh thêm mới nhân viên vào cơ sở dữ liệu
                string query = "INSERT INTO staff (taikhoan, hoten, ngaysinh, gioitinh, matkhau, role) VALUES (@taikhoan, @hoten, @ngaysinh, @gioitinh, @matkhau, @role)";

                // Đặt các tham số cho câu lệnh SQL
                SqlParameter[] parameters = {
                    new SqlParameter("@taikhoan", staff.TaiKhoan_Chien),
                    new SqlParameter("@hoten", staff.HoTen_Chien),
                    new SqlParameter("@ngaysinh", staff.NgaySinh_Chien),
                    new SqlParameter("@gioitinh", staff.GioiTinh_Chien),
                    new SqlParameter("@matkhau", staff.MatKhau_Chien),
                    new SqlParameter("@role", staff.Role_Chien)
                };

                // Thực thi câu lệnh SQL thêm nhân viên vào cơ sở dữ liệu
                db.ExecuteNonQuery(query, parameters);

                // Thông báo thành công
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Xử lý và hiển thị lỗi nếu có
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateStaff_Chien(StaffModel_Chien staff)
        {
            string query = "UPDATE staff " +
                        "SET taikhoan = @taikhoan, " +
                        "hoten = @hoten," +
                        " ngaysinh = @ngaysinh, " +
                        "gioitinh = @gioitinh, " +
                        "matkhau = @matkhau, " +
                        "role = @role" +
                        " WHERE id_staff = @id";

            SqlParameter[] parameters = {
                    new SqlParameter("@taikhoan", staff.TaiKhoan_Chien),
                    new SqlParameter("@hoten", staff.HoTen_Chien),
                    new SqlParameter("@ngaysinh", staff.NgaySinh_Chien),
                    new SqlParameter("@gioitinh", staff.GioiTinh_Chien),
                    new SqlParameter("@matkhau", staff.MatKhau_Chien),
                    new SqlParameter("@role", staff.Role_Chien),
                    new SqlParameter("@id", staff.IdStaff_Chien),
            };

            db.ExecuteNonQuery(query, parameters);
        }

        public void RemoveStaff_Chien(StaffModel_Chien staff)
        {
            if (staff == null)
            {
                throw new ArgumentException("Nhân viên không hợp lệ.");
            }

            string xoa = @"
                UPDATE phong SET tinhtrang = N'Trống'
                DELETE FROM cthoadon 
                WHERE id_hoadon IN (SELECT id_hoadon FROM hoadon WHERE id_staff = @id)
                DELETE FROM hoadon WHERE id_staff = @id
                DELETE FROM staff WHERE id_staff = @id
                ";
            SqlParameter[] xoaParam = {
                new SqlParameter("@id", staff.IdStaff_Chien)
            };
            db.ExecuteNonQuery(xoa, xoaParam);

        }



        public DataTable LayDataStaff_Chien()
        {
            string query = @"SELECT * FROM staff ORDER BY id_staff DESC";
            return db.ExecuteQuery(query);
        }

        public DataTable TimKimNhanVien(string tim)
        {
            string query = @"
                            SELECT * FROM staff
                            WHERE hoten LIKE @tim OR id_staff LIKE @tim
                            ORDER BY id_staff DESC
                            ";

            SqlParameter[] parameters = {
                new SqlParameter("@tim", "%" + tim + "%")
            };

            return db.ExecuteQuery(query, parameters);
        }
    }
}
