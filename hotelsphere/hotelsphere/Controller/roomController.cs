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
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@id", id_roomType)
            };

            DataTable result = db.ExecuteQuery(query, parameters);
            if (result.Rows.Count > 0)
            {
                object priceValue = result.Rows[0]["giaphongmotngay"];
                if (priceValue != DBNull.Value)
                {
                    if (priceValue is decimal priceDecimal)
                    {
                        return priceDecimal;
                    }
                    else if (priceValue is string priceString)
                    {
                        if (decimal.TryParse(priceString, out decimal parsedPrice))
                        {
                            return parsedPrice;
                        }
                        else
                        {
                            throw new FormatException("Price value is not in a correct decimal format.");
                        }
                    }
                    else
                    {
                        throw new InvalidCastException("Price value is not a valid type.");
                    }
                }
            }
            return 0; 
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

    }
}
