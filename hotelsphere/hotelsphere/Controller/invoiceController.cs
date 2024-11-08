using hotelsphere.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelsphere.Controller
{
    public class invoiceController
    {
        public DB_Chien db;
        public invoiceController()
        {
            db = new DB_Chien();
        }

        public int ThemHoaDon(int? idCustomer, int? idStaff, int? idRoom, decimal giaPhongMotNgay, DateTime ngayThuePhong, DateTime ngayTraPhong, decimal? thanhtien)
        {
            string query = "INSERT INTO hoadon (id_customer, id_staff, giaphongmotngay, id_room, ngaythuephong, ngaytraphong, thanhtien) " +
                           "OUTPUT INSERTED.id_hoadon " +
                           "VALUES (@id_customer, @id_staff, @giaphongmotngay, @id_room, @ngaythuephong, @ngaytraphong, @thanhtien);";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id_customer", idCustomer ?? (object)DBNull.Value),
                new SqlParameter("@id_staff", idStaff ?? (object)DBNull.Value),
                new SqlParameter("@giaphongmotngay", giaPhongMotNgay),
                new SqlParameter("@id_room", idRoom ?? (object)DBNull.Value),
                new SqlParameter("@ngaythuephong", ngayThuePhong),
                new SqlParameter("@ngaytraphong", ngayTraPhong),
                new SqlParameter("@thanhtien", thanhtien ?? (object)DBNull.Value)
            };

            DataTable result = db.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["id_hoadon"]); // Trả về ID của hóa đơn mới được thêm
            }
            return -1; // Nếu không có kết quả, trả về -1
        }


        public void ThemCTHoaDon(int idHoaDon, int idDichVu, decimal donGia, int soLuongSuDung)
        {
            string query = "INSERT INTO cthoadon (id_hoadon, id_dichvu, dongia, soluongsudungdichvu) VALUES (@id_hoadon, @id_dichvu, @dongia, @soluongsudungdichvu)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id_hoadon", idHoaDon),
                new SqlParameter("@id_dichvu", idDichVu),
                new SqlParameter("@dongia", donGia),
                new SqlParameter("@soluongsudungdichvu", soLuongSuDung)
            };

            db.ExecuteNonQuery(query, parameters);
        }

        public int DemSoLuongDichVu()
        {
            string query = "SELECT COUNT(*) AS SoLuongDichVu FROM ct_dichvu";
            DataTable result = db.ExecuteQuery(query);

            if (result.Rows.Count > 0 && result.Rows[0]["SoLuongDichVu"] != DBNull.Value)
            {
                return Convert.ToInt32(result.Rows[0]["SoLuongDichVu"]);
            }

            return 0;
        }

        public string LayTenNhanVien(int? idStaff)
        {
            string query = "SELECT hoten FROM staff WHERE id_staff = @id_staff";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id_staff", idStaff)
            };

            DataTable result = db.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0 && result.Rows[0]["hoten"] != DBNull.Value)
            {
                return result.Rows[0]["hoten"].ToString();
            }
            return null; 
        }
    }
}
