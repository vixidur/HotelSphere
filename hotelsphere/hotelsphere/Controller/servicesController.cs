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
    public class servicesController
    {
        public DB_Chien db;
        public servicesController()
        {
            db = new DB_Chien();    
        }


        public List<string> GetTenDichVu_Chien()
        {
            List<string> serviceNames = new List<string>();
            string query = "SELECT tendichvu FROM dichvu";

            DataTable result = db.ExecuteQuery(query);

            foreach (DataRow row in result.Rows)
            {
                serviceNames.Add(row["tendichvu"].ToString());
            }

            return serviceNames;
        }

        public decimal GetGiaDichVu_Chien(string serviceName)
        {
            string query = "SELECT giadichvu FROM dichvu WHERE tendichvu = @serviceName";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@serviceName", serviceName)
            };

            DataTable result = db.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                return Convert.ToDecimal(result.Rows[0]["giadichvu"]);
            }
            return 0;
        }

        public int LayIDServiceTheoTen(string serviceName)
        {
            string query = "SELECT id_dichvu FROM dichvu WHERE tendichvu = @serviceName";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@serviceName", serviceName)
            };

            DataTable result = db.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["id_dichvu"]);
            }
            return 0;
        }

        public void ThemCTDichVu(int idDichVu, string tenDichVu, decimal giaDichVu, int soLuong)
        {
            decimal thanhTien = giaDichVu * soLuong;
            string query = "INSERT INTO ct_dichvu VALUES (@id_dichvu, @tendichvu, @giadichvu, @soluong, @thanhtien)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id_dichvu", idDichVu),
                new SqlParameter("@tendichvu", tenDichVu),
                new SqlParameter("@giadichvu", giaDichVu),
                new SqlParameter("@soluong", soLuong),
                new SqlParameter("@thanhtien", thanhTien)
            };

            db.ExecuteNonQuery(query, parameters);
        }

        public DataTable LayDataService_Chien()
        {
            string query = "SELECT id_dichvu, tendichvu, giatien, soluong, thanhtien FROM ct_dichvu";
            return db.ExecuteQuery(query);
        }

        public void XoaDichVu_Chien(int idDichVu)
        {
            string query = "DELETE FROM ct_dichvu WHERE id_dichvu = @idDichVu";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@idDichVu", idDichVu)
            };
            db.ExecuteNonQuery(query, parameters);
        }

        public void XoaAll_Chien()
        {
            string query = "DELETE FROM ct_dichvu";
            db.ExecuteNonQuery(query);
        }

        public decimal TinhTongThanhTien()
        {
            string query = "SELECT SUM(thanhtien) AS Total FROM ct_dichvu";
            DataTable result = db.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                if (result.Rows[0]["Total"] != DBNull.Value)
                {
                    return Convert.ToDecimal(result.Rows[0]["Total"]);
                }
            }
            return 0; 
        }

    }
}
