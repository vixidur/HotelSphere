using hotelsphere.Models;
using hotelsphere.Models.ADMIN;
using hotelsphere.UserControls.ADMIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.Controller.ADMIN
{
    public class roomController_Hung
    {
        private DB_Chien db;

        public roomController_Hung()
        {
            db = new DB_Chien();
        }
        public List<string> LayPhongChuaTonTai()
        {
            List<string> danhSachGoiY = new List<string>();
            for (int i = 100; i <= 400; i++)
            {
                danhSachGoiY.Add("Room " + i);
            }

            string query = "SELECT tenphong FROM phong";
            DataTable dt = db.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                string tenPhongTonTai = row["tenphong"].ToString();
                danhSachGoiY.Remove(tenPhongTonTai);
            }

            return danhSachGoiY;
        }

        public bool KiemTraTrungTenPhong(string tenPhong)
        {
            string query = "SELECT COUNT(*) FROM phong WHERE tenphong = @tenphong";
            SqlParameter[] parameters = { new SqlParameter("@tenphong", tenPhong) };

            object result = db.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }
        public void AddRoom_Khanh(RoomModel_Hung room, string roomTypeName_Chien)
        {
            try
            {
                // Kiểm tra tên phòng đã tồn tại
                if (KiemTraTrungTenPhong(room.TenPhong_Hung))
                {
                    throw new Exception("Tên phòng đã tồn tại. Vui lòng chọn tên khác.");
                }

                // Lấy ID loại phòng từ tên loại phòng
                room.IdLoaiPhong_Hung = LayLPTheoID(roomTypeName_Chien);

                // Câu lệnh thêm mới phòng
                string query = "INSERT INTO phong (tenphong, id_loaiphong, tinhtrang) VALUES (@tenphong, @idloaiphong, @tinhtrang)";
                SqlParameter[] parameters = {
                    new SqlParameter("@tenphong", room.TenPhong_Hung),
                    new SqlParameter("@idloaiphong", room.IdLoaiPhong_Hung),
                    new SqlParameter("@tinhtrang", room.TinhTrangPhong_Hung)
                };

                db.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public int LayLPTheoID(string roomTypeName_Chien)
        {
            string query = "SELECT id_loaiphong FROM loaiphong WHERE tenloaiphong = @RoomTypeName";
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@RoomTypeName", roomTypeName_Chien) };

            object result = db.ExecuteScalar(query, parameters);
            if (result != null)
            {
                return Convert.ToInt32(result);
            }
            else
            {
                throw new Exception("Loại phòng không tồn tại.");
            }
        }


        public void UpdateRoom_Khanh(RoomModel_Hung room, string roomNameType_Chien)
        {
            room.IdLoaiPhong_Hung = LayLPTheoID(roomNameType_Chien);
            string query = "UPDATE phong SET tenphong = @tenphong, id_loaiphong = @idloaiphong, tinhtrang = @tinhtrang WHERE id_room = @id";

            SqlParameter[] parameters = {
                new SqlParameter("@tenphong", room.TenPhong_Hung),
                new SqlParameter("@idloaiphong", room.IdLoaiPhong_Hung),
                new SqlParameter("@tinhtrang", room.TinhTrangPhong_Hung ?? (object)DBNull.Value),
                new SqlParameter("@id", room.IdRoom_Hung),
            };

            db.ExecuteNonQuery(query, parameters);
        }

        public void RemoveRoom_Khanh(RoomModel_Hung room)
        {
            if (room == null)
            {
                throw new ArgumentException("Phòng không hợp lệ.");
            }
            string xoaRoom = @"
                            DELETE FROM cthoadon 
                            WHERE id_hoadon IN (SELECT id_hoadon FROM hoadon WHERE id_room = @id)
                            DELETE FROM hoadon WHERE id_room = @id
                            DELETE FROM phong WHERE id_room = @id
                            ";
            SqlParameter[] invoiceParams = {
                new SqlParameter("@id", room.IdRoom_Hung)
            };
            db.ExecuteNonQuery(xoaRoom, invoiceParams);
        }



        public DataTable LayDataPhong_Khanh()
        {
            string query = @"select id_room, tenphong, loaiphong.tenloaiphong,
                            loaiphong.giaphongmotngay, tinhtrang, loaiphong.mota
                            from phong 
                            inner join loaiphong
                            on phong.id_loaiphong = loaiphong.id_loaiphong 
                            order by id_room desc";
            return db.ExecuteQuery(query);
        }

        public DataTable TimKiemPhong(string tim)
        {
            string query = @"
                            SELECT id_room, tenphong, loaiphong.tenloaiphong,
                            loaiphong.giaphongmotngay, tinhtrang, loaiphong.mota
                            FROM phong 
                            INNER JOIN loaiphong
                            ON phong.id_loaiphong = loaiphong.id_loaiphong
                            WHERE tenphong LIKE @tim OR id_room LIKE @tim
                            ORDER BY id_room DESC
                            ";

            SqlParameter[] parameters = {
                new SqlParameter("@tim", "%" + tim + "%")
            };

            return db.ExecuteQuery(query, parameters);
        }

        public List<string> LoaiPhong()
        {
            string query = "SELECT tenloaiphong FROM loaiphong";
            DataTable kq = db.ExecuteQuery(query, null);

            List<string> loaiPhong = new List<string>();
            foreach (DataRow row in kq.Rows)
            {
                loaiPhong.Add(row["tenloaiphong"].ToString());
            }

            return loaiPhong;
        }
    }
}
