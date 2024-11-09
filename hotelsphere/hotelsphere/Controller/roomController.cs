using hotelsphere.Models;
using hotelsphere.UserControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.Controller
{
    public class roomController
    {
        public DB_Chien db;

        public roomController()
        {
            db = new DB_Chien();
        }

        public decimal LayGiaTienTheoIDRoom_Chien(int id_roomType)
        {
            string query = "SELECT giaphongmotngay FROM loaiphong WHERE id_loaiphong = @id";
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@id", id_roomType) };

            DataTable result = db.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                object priceValue = result.Rows[0]["giaphongmotngay"];
                if (priceValue != DBNull.Value && priceValue is decimal priceDecimal && priceDecimal >= 0)
                {
                    return priceDecimal;
                }
            }
            return 0; 
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


        public List<RoomModel_Chien> GetRoomsByType(int? roomTypeId = null)
        {
            string query = @"
                            SELECT lp.tenloaiphong, p.tenphong, p.tinhtrang 
                            FROM phong p 
                            JOIN loaiphong lp ON p.id_loaiphong = lp.id_loaiphong 
                            WHERE (@RoomType IS NULL OR lp.id_loaiphong = @RoomType)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@RoomType", roomTypeId ?? (object)DBNull.Value)
            };
            return GetRooms(query, parameters);
        }

        public List<RoomModel_Chien> GetRoomsByEmptyOrRenting(string status)
        {
            string query = @"SELECT lp.tenloaiphong, p.tenphong, p.tinhtrang 
                     FROM phong p 
                     JOIN loaiphong lp ON p.id_loaiphong = lp.id_loaiphong 
                     WHERE p.tinhtrang LIKE N'%' + @status + '%'";

            SqlParameter[] parameters =
            {
                new SqlParameter("@status", status)
            };

            return GetRooms(query, parameters);
        }

        private List<RoomModel_Chien> GetRooms(string query, SqlParameter[] parameters)
        {
            List<RoomModel_Chien> rooms = new List<RoomModel_Chien>();
            DataTable result = db.ExecuteQuery(query, parameters);

            foreach (DataRow row in result.Rows)
            {
                RoomModel_Chien room = new RoomModel_Chien
                {
                    LoaiPhong_Chien = row["tenloaiphong"].ToString(),
                    TenPhong_Chien = row["tenphong"].ToString(),
                    TinhTrang_Chien = row["tinhtrang"].ToString()
                };
                rooms.Add(room);
            }

            return rooms;
        }

        public List<RoomModel_Chien> LocRoom_Chien(int? roomTypeId, string status)
        {
            List<RoomModel_Chien> rooms = new List<RoomModel_Chien>();
            string query = @"
                        SELECT lp.tenloaiphong, p.tenphong, p.tinhtrang 
                        FROM phong p 
                        JOIN loaiphong lp ON p.id_loaiphong = lp.id_loaiphong 
                        WHERE 
                            (@RoomType IS NULL OR lp.id_loaiphong = @RoomType) 
                            AND (@Status IS NULL OR p.tinhtrang LIKE N'%' + @Status + '%')"; 

            SqlParameter[] parameters =
            {
                new SqlParameter("@RoomType", roomTypeId ?? (object)DBNull.Value),
                new SqlParameter("@Status", status ?? (object)DBNull.Value)
            };

            DataTable result = db.ExecuteQuery(query, parameters);

            foreach (DataRow row in result.Rows)
            {
                RoomModel_Chien room = new RoomModel_Chien
                {
                    LoaiPhong_Chien = row["tenloaiphong"].ToString(),
                    TenPhong_Chien = row["tenphong"].ToString(),
                    TinhTrang_Chien = row["tinhtrang"].ToString()
                };
                rooms.Add(room);
            }

            return rooms;
        }

        public bool CapNhatTrangThaiPhong_Chien(string roomName, string newStatus)
        {
            string query = "UPDATE phong SET tinhtrang = @NewStatus WHERE tenphong = @RoomName";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@NewStatus", newStatus),
                new SqlParameter("@RoomName", roomName)
            };

            try
            {
                int rowsAffected = db.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                return false; 
            }
        }

        public int? LayIdPhong(string roomName_Chien)
        {
            string query = "SELECT id_room FROM phong WHERE tenphong = @roomName";
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@roomName", roomName_Chien) };

            DataTable result = db.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                object roomID = result.Rows[0]["id_room"];
                if (roomID != DBNull.Value && roomID is int roomTypeId)
                {
                    return roomTypeId;
                }
            }

            return null;
        }
        public int? LayLPTheoID(string roomTypeName_Chien)
        {
            string query = "SELECT id_loaiphong FROM loaiphong WHERE tenloaiphong = @RoomTypeName";
            SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@RoomTypeName", roomTypeName_Chien) };

            DataTable result = db.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                object roomTypeIdValue = result.Rows[0]["id_loaiphong"];
                if (roomTypeIdValue != DBNull.Value && roomTypeIdValue is int roomTypeId)
                {
                    return roomTypeId; 
                }
            }

            return null; 
        }

        public string LayTenKhachHangTheoPhong(string tenPhong_Chien)
        {
            // SQL query để lấy tên khách hàng dựa trên tên phòng và trạng thái phòng là "Đang thuê"
            string query = @"SELECT kh.tenkhachhang
                            FROM hoadon hd
                            JOIN customer kh ON hd.id_customer = kh.id_customer
                            JOIN phong p ON hd.id_room = p.id_room
                            WHERE p.tenphong = @TenPhong
                              AND p.tinhtrang = N'Đang thuê';
                            ";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TenPhong", tenPhong_Chien)
            };

            DataTable result = db.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["tenkhachhang"].ToString();
            }

            return null;
        }

    }
}
