using hotelsphere.Models;
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

        public List<RoomModel_Chien> GetRoomsByType(int? roomTypeId = null)
        {
            List<RoomModel_Chien> rooms = new List<RoomModel_Chien>();

            string query = @"
                SELECT lp.tenloaiphong, p.tenphong, p.tinhtrang 
                FROM phong p 
                JOIN loaiphong lp ON p.id_loaiphong = lp.id_loaiphong 
                WHERE (@RoomType IS NULL OR lp.id_loaiphong = @RoomType)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@RoomType", roomTypeId ?? (object)DBNull.Value)
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


        public List<RoomModel_Chien> GetRoomsByEmptyOrRenting(string status)
        {
            List<RoomModel_Chien> rooms = new List<RoomModel_Chien>();

            string query = @"SELECT lp.tenloaiphong, p.tenphong, p.tinhtrang 
                            FROM phong p 
                            JOIN loaiphong lp ON p.id_loaiphong = lp.id_loaiphong 
                            WHERE p.tinhtrang LIKE N'%' + @status + '%'";
            //MessageBox.Show("Check query: " + query);
            SqlParameter[] parameters =
            {
                new SqlParameter("@status", status)
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
    }
}
