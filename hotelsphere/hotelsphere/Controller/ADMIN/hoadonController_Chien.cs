using hotelsphere.Models;
using hotelsphere.Models.ADMIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelsphere.Controller.ADMIN
{
    public class hoadonController_Chien
    {
        public DB_Chien db; 
        public hoadonController_Chien()
        {
            db = new DB_Chien();
        }


        public DataTable LayDataHoaDon_Chien()
        {
            string query = @"SELECT DISTINCT 
                                h.id_hoadon AS MaHoaDon,
                                s.hoten AS NhanVienLap,
                                c.tenkhachhang AS TenKhachHang,
	                            c.so_cmt AS SoCCCD,
                                h.ngaythuephong AS NgayLap,
                                h.thanhtien AS ThanhTien
                            FROM 
                                cthoadon cthd
                            JOIN 
                                hoadon h ON h.id_hoadon = cthd.id_hoadon
                            JOIN 
                                customer c ON c.id_customer = h.id_customer
                            JOIN 
                                staff s ON s.id_staff = h.id_staff
                            JOIN 
                                dichvu d ON d.id_dichvu = cthd.id_dichvu
                            JOIN 
                                phong p ON h.id_room = p.id_room
                            JOIN 
                                loaiphong lp ON lp.id_loaiphong = p.id_loaiphong;";
            return db.ExecuteQuery(query);
        }


        public DataTable TimKiemHoaDon(string tim)
        {
            string query = @"SELECT DISTINCT 
                                    h.id_hoadon AS MaHoaDon,
                                    s.hoten AS NhanVienLap,
                                    c.tenkhachhang AS TenKhachHang,
                                    c.so_cmt AS SoCCCD,
                                    h.ngaythuephong AS NgayLap,
                                    h.thanhtien AS ThanhTien
                                FROM 
                                    cthoadon cthd
                                JOIN 
                                    hoadon h ON h.id_hoadon = cthd.id_hoadon
                                JOIN 
                                    customer c ON c.id_customer = h.id_customer
                                JOIN 
                                    staff s ON s.id_staff = h.id_staff
                                JOIN 
                                    dichvu d ON d.id_dichvu = cthd.id_dichvu
                                JOIN 
                                    phong p ON h.id_room = p.id_room
                                JOIN 
                                    loaiphong lp ON lp.id_loaiphong = p.id_loaiphong
                                WHERE 
                                    h.id_hoadon LIKE @tim 
                                    OR c.tenkhachhang LIKE @tim 
                                    OR c.so_cmt LIKE @tim";

            SqlParameter[] parameters = {
                new SqlParameter("@tim", "%" + tim + "%")
            };

            return db.ExecuteQuery(query, parameters);
        }

        public void XoaHoaDon_Chien(int idHoaDon)
        {

            string deleteCTHoaDon = "delete from cthoadon where id_hoadon = @id";
            SqlParameter[] hoadonCT = {
                new SqlParameter("@id", idHoaDon)
            };
            db.ExecuteNonQuery(deleteCTHoaDon, hoadonCT);


            string deleteHoaDon = "delete from hoadon where id_hoadon = @id";
            SqlParameter[] hoaDon = {
                new SqlParameter("@id", idHoaDon)
            };
            db.ExecuteNonQuery(deleteHoaDon, hoaDon);
        }

    }
}
