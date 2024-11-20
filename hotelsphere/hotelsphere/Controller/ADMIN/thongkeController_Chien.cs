using hotelsphere.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelsphere.Controller.ADMIN
{
    public class thongkeController_Chien
    {
        public DB_Chien db;
        public thongkeController_Chien()
        {
            db = new DB_Chien();
        }

        public decimal LayTongDoanhThu_Chien()
        {
            string query = "SELECT SUM(thanhtien) FROM hoadon";
            try
            {
                object result = db.ExecuteScalar(query);
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính tổng doanh thu: " + ex.Message);
            }
        }

        public int LaySLKhachHang_Chien()
        {
            string query = "SELECT COUNT(*) FROM customer";
            try
            {
                object result = db.ExecuteScalar(query);
                return result != DBNull.Value ? int.Parse(result.ToString()) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính toán số lượng khách hàng: " + ex.Message);
            }
        }

        public int LaySLNhanVien_Chien()
        {
            string query = "SELECT COUNT(*) FROM staff";
            try
            {
                object result = db.ExecuteScalar(query);
                return result != DBNull.Value ? int.Parse(result.ToString()) : 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi tính toán số lượng nhân viên: " + ex.Message);
            }
        }

        public DataTable LayChartDataDoanhThuTheoNgay()
        {
            string query = @"
                            SELECT 
                                FORMAT(CAST(ngaythuephong AS DATE), 'dd/MM/yyyy') AS Ngay, 
                                SUM(thanhtien) AS TongDoanhThu
                            FROM cthoadon
                            JOIN hoadon h ON cthoadon.id_hoadon = h.id_hoadon
                            GROUP BY CAST(ngaythuephong AS DATE)
                            ORDER BY Ngay";

            return db.ExecuteQuery(query);
        }

        public DataTable LayChartDataSoLuongPhongTheoLoai()
        {
            string query = @"
                            SELECT 
                                lp.tenloaiphong AS LoaiPhong, 
                                COUNT(p.id_room) AS SoLuongPhong
                            FROM 
                                phong p
                            JOIN 
                                loaiphong lp ON p.id_loaiphong = lp.id_loaiphong
                            GROUP BY 
                                lp.tenloaiphong
                            ORDER BY 
                                SoLuongPhong DESC";

            return db.ExecuteQuery(query);
        }

        public DataTable ThongKeDichVu()
        {
            string query = @"
                            SELECT 
                                id_dichvu AS 'Mã Dịch Vụ',
                                tendichvu AS 'Tên Dịch Vụ',
                                giadichvu AS 'Giá Dịch Vụ'
                            FROM dichvu;
                            ";
            return db.ExecuteQuery(query);
        }

        public DataTable ThongKeDoanhThuTungPhong()
        {
            string query = @"
                            SELECT 
                                phong.tenphong AS 'Tên Phòng',
                                SUM(hoadon.thanhtien) AS 'Tổng Doanh Thu'
                            FROM hoadon
                            JOIN phong ON hoadon.id_room = phong.id_room
                            GROUP BY phong.tenphong
                            ORDER BY SUM(hoadon.thanhtien) DESC;
                            ";
            return db.ExecuteQuery(query);
        }

        public DataTable ThongKeDoanhThuThangTheoNam(int year)
        {
            string query = @"
                            SELECT 
                                MONTH(hoadon.ngaythuephong) AS 'Tháng',
                                SUM(hoadon.thanhtien) AS 'Doanh Thu'
                            FROM hoadon
                            WHERE YEAR(hoadon.ngaythuephong) = @year
                            GROUP BY MONTH(hoadon.ngaythuephong)
                            ORDER BY MONTH(hoadon.ngaythuephong);
                            ";
            SqlParameter[] doanhthutheonam =
            {
                new SqlParameter("@year", year),
            };
            return db.ExecuteQuery(query, doanhthutheonam);
        }
        public DataTable LayThongKeDichVuKhachHang()
        {
            string query = @"
                            SELECT 
                                c.tenkhachhang AS TenKhachHang,
                                COUNT(ctd.id_dichvu) AS SoLuongDichVu,
                                SUM(ctd.soluongsudungdichvu * ctd.dongia) AS TongTienDichVu
                            FROM 
                                cthoadon ctd
                            JOIN 
                                hoadon h ON h.id_hoadon = ctd.id_hoadon
                            JOIN 
                                customer c ON c.id_customer = h.id_customer
                            GROUP BY 
                                c.tenkhachhang
                            ORDER BY 
                                TongTienDichVu DESC;
                            ";

            return db.ExecuteQuery(query);
        }
    }
}
