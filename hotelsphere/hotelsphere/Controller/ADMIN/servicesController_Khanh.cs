using hotelsphere.Models;
using hotelsphere.Models.ADMIN;
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
    public class servicesController_Khanh
    {
        public DB_Chien db;
        public servicesController_Khanh()
        {
            db = new DB_Chien();
        }
        public bool KiemTraTrungTenDichVu(string tenDichVu)
        {
            string query = "SELECT COUNT(*) FROM dichvu WHERE tendichvu = @tendichvu";
            SqlParameter[] parameters = { new SqlParameter("@tendichvu", tenDichVu) };

            object result = db.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }
        public void AddServices_TAnh(ServicesModel_TuanAnh services)
        {
            try
            {
                // Kiểm tra tên phòng đã tồn tại
                if (KiemTraTrungTenDichVu(services.TenDichVu_TA))
                {
                    throw new Exception("Tên dịch vụ đã tồn tại. Vui lòng chọn tên khác.");
                }
                // Câu lệnh thêm mới phòng
                string query = "INSERT INTO dichvu (tendichvu, giadichvu) VALUES (@tendichvu, @giadichvu)";
                SqlParameter[] parameters = {
                    new SqlParameter("@tendichvu", services.TenDichVu_TA),
                    new SqlParameter("@giadichvu", services.GiaDichVu_TA),
                };

                db.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void UpdateServices_TAnh(ServicesModel_TuanAnh services)
        {
            string query = "UPDATE dichvu SET tendichvu = @tendichvu, giadichvu = @giadichvu WHERE id_dichvu = @id";

            SqlParameter[] parameters = {
                new SqlParameter("@tendichvu", services.TenDichVu_TA),
                new SqlParameter("@giadichvu", services.GiaDichVu_TA),
                new SqlParameter("@id", services.IdServices_TA)
            };

            db.ExecuteNonQuery(query, parameters);
        }

        public void RemoveServices_TAnh(ServicesModel_TuanAnh services)
        {
            if (services == null)
            {
                throw new ArgumentException("Dịch vụ không hợp lệ.");
            }

            string deleteServices = @"
                                    DELETE FROM cthoadon WHERE id_dichvu = @id
                                    DELETE FROM ct_dichvu WHERE id_dichvu = @id
                                    DELETE FROM dichvu WHERE id_dichvu = @id";
            SqlParameter[] dichvuParams = {
                new SqlParameter("@id", services.IdServices_TA)
            };
            db.ExecuteNonQuery(deleteServices, dichvuParams);
        }


        public DataTable LayDataServices_TAnh()
        {
            string query = @"select * from dichvu order by id_dichvu desc";
            return db.ExecuteQuery(query);
        }

        public DataTable TimKiemDichVu(string tim)
        {
            string query = @"
                            SELECT * FROM dichvu
                            WHERE tendichvu LIKE @tim OR id_dichvu LIKE @tim
                            ORDER BY id_dichvu DESC
                            ";

            SqlParameter[] parameters = {
                new SqlParameter("@tim", "%" + tim + "%")
            };

            return db.ExecuteQuery(query, parameters);
        }
    }
}
