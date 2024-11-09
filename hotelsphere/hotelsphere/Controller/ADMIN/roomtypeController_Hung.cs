using hotelsphere.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelsphere.UserControls.ADMIN;

namespace hotelsphere.Controller.ADMIN
{
    public class roomtypeController_Hung
    {
        private DB_Chien db;

        public roomtypeController_Hung()
        {
            db = new DB_Chien();
        }

        public void AddRoomType_Hung(RoomTypeModel_Hung roomType)
        {
            string query = "INSERT INTO loaiphong (tenloaiphong, giaphongmotngay, mota) VALUES (@tenloai, @giatien, @mota)";

            SqlParameter[] parameters = {
                new SqlParameter("@tenloai", roomType.NameRoomType_Hung),
                new SqlParameter("@giatien", roomType.PricePerDay_Hung ),
                new SqlParameter("@mota", roomType.Description_Hung),
            };

            db.ExecuteNonQuery(query, parameters);
        }


        public void UpdateRoomType_Hung(RoomTypeModel_Hung roomType)
        {
            string query = "UPDATE loaiphong SET tenloaiphong = @tenloai, giaphongmotngay = @giatien, mota = @mota WHERE id_loaiphong = @id";

            SqlParameter[] parameters = {
                new SqlParameter("@tenloai", roomType.NameRoomType_Hung),
                new SqlParameter("@giatien", roomType.PricePerDay_Hung),
                new SqlParameter("@mota", roomType.Description_Hung ?? (object)DBNull.Value),
                new SqlParameter("@id", roomType.IdRoomType_Hung),
            };

            db.ExecuteNonQuery(query, parameters);
        }

        public void RemoveRoomType_Hung(RoomTypeModel_Hung roomType)
        {
            if (roomType == null)
            {
                throw new ArgumentException("Loại phòng không hợp lệ.");
            }

            // Xóa các hóa đơn có liên kết với phòng thuộc loại phòng này
            string delHoaDon = "DELETE FROM hoadon WHERE id_room IN (SELECT id_room FROM phong WHERE id_loaiphong = @id)";
            SqlParameter[] hoaDonParams = {
                new SqlParameter("@id", roomType.IdRoomType_Hung)
            };
            db.ExecuteNonQuery(delHoaDon, hoaDonParams);

            // Xóa các phòng có liên kết với loại phòng này
            string delPhong = "DELETE FROM phong WHERE id_loaiphong = @id";
            SqlParameter[] phongParams = {
                new SqlParameter("@id", roomType.IdRoomType_Hung)
            };
            db.ExecuteNonQuery(delPhong, phongParams);

            // Xóa loại phòng
            string delLoaiPhong = "DELETE FROM loaiphong WHERE id_loaiphong = @id";
            SqlParameter[] loaiPhongParams = {
                new SqlParameter("@id", roomType.IdRoomType_Hung)
            };
            db.ExecuteNonQuery(delLoaiPhong, loaiPhongParams);
        }



        public DataTable LayDataLoaiPhong()
        {
            string query = "SELECT * FROM loaiphong ORDER BY id_loaiphong DESC";
            return db.ExecuteQuery(query);
        }

        public DataTable TimKiemLoaiPhong(string tim)
        {
            string query = @"
                            SELECT * FROM loaiphong
                            WHERE tenloaiphong LIKE @tim OR id_loaiphong LIKE @tim
                            ORDER BY id_loaiphong DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@tim", "%" + tim + "%")
            };

            return db.ExecuteQuery(query, parameters);
        }
    }
}
