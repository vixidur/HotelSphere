using hotelsphere.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
