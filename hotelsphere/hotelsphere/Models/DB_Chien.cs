using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace hotelsphere.Models
{

    public class DB_Chien
    {
        private SqlConnection conn;

        public DB_Chien()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ketnoi"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        // Mở kết nối
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // Đóng kết nối
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // Phương thức thực thi câu lệnh SQL không trả về giá trị (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                int rowsAffected = cmd.ExecuteNonQuery();
                Close();
                return rowsAffected;
            }
        }

        // Phương thức thực thi câu lệnh SQL trả về giá trị (SELECT)
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable result = new DataTable();
                    adapter.Fill(result);
                    return result;
                }
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                object result = cmd.ExecuteScalar();
                Close();
                return result;
            }
        }

    }
}
