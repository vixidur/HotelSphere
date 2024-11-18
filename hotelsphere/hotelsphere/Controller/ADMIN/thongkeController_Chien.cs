﻿using hotelsphere.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable ThongKeKhachHang()
        {
            string query = @"
                            SELECT 
                                c.id_customer AS 'ID',
                                c.tenkhachhang AS 'Họ tên',
                                c.so_cmt AS 'Số CCCD',
                                c.quoctich AS 'Quốc tịch',
                                c.gioitinh AS 'Giới tính',
                                c.sdt AS 'SĐT',
                                COUNT(hd.id_hoadon) AS 'SLHĐ',
                                SUM(hd.thanhtien) AS 'Tổng tiền'
                            FROM 
                                customer c
                            LEFT JOIN 
                                hoadon hd ON c.id_customer = hd.id_customer
                            GROUP BY 
                                c.id_customer, c.tenkhachhang, c.so_cmt, c.quoctich, c.gioitinh, c.sdt
                            ORDER BY 
                                c.id_customer;
                            ";
            return db.ExecuteQuery(query);
        }

        public DataTable ThongKeDoanhThu()
        {
            string query = @"
                            SELECT 
                                hd.id_hoadon AS MaHoaDon,
                                c.tenkhachhang AS TenKhachHang,
                                hd.ngaythuephong AS NgayThuePhong,
                                hd.ngaytraphong AS NgayTraPhong,
                                hd.giaphongmotngay AS GiaPhongMotNgay,
                                DATEDIFF(DAY, hd.ngaythuephong, hd.ngaytraphong) AS SoNgayThue,
                                (DATEDIFF(DAY, hd.ngaythuephong, hd.ngaytraphong) * hd.giaphongmotngay) AS ThanhTienPhong,
                                ISNULL(SUM(cthd.dongia * cthd.soluongsudungdichvu), 0) AS ThanhTienDichVu,
                                (DATEDIFF(DAY, hd.ngaythuephong, hd.ngaytraphong) * hd.giaphongmotngay + 
                                ISNULL(SUM(cthd.dongia * cthd.soluongsudungdichvu), 0)) AS TongDoanhThu
                            FROM 
                                hoadon hd
                            LEFT JOIN customer c ON hd.id_customer = c.id_customer
                            LEFT JOIN cthoadon cthd ON hd.id_hoadon = cthd.id_hoadon
                            GROUP BY 
                                hd.id_hoadon, 
                                c.tenkhachhang, 
                                hd.ngaythuephong, 
                                hd.ngaytraphong, 
                                hd.giaphongmotngay
                            ORDER BY 
                                hd.id_hoadon;

                            ";
            return db.ExecuteQuery(query);
        }

        public DataTable ThongKeNhanVien()
        {
            string query = @"
                            SELECT 
                                s.id_staff AS MaNhanVien,
                                s.hoten AS TenNhanVien,
                                s.taikhoan AS TaiKhoan,
                                s.ngaysinh AS NgaySinh,
                                s.gioitinh AS GioiTinh,
                                s.role AS VaiTro,
                                COUNT(hd.id_hoadon) AS SoHoaDonDaXuLy,
                                ISNULL(SUM(hd.thanhtien), 0) AS TongDoanhThuXuLy
                            FROM 
                                staff s
                            LEFT JOIN hoadon hd ON s.id_staff = hd.id_staff
                            GROUP BY 
                                s.id_staff, 
                                s.hoten, 
                                s.taikhoan, 
                                s.ngaysinh, 
                                s.gioitinh, 
                                s.role
                            ORDER BY 
                                s.id_staff;
                            ";
            return db.ExecuteQuery(query);
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
