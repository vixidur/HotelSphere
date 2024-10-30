﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotelsphere.Models;
namespace hotelsphere.Controller
{
    public class dvucustomerController
    {
        private DB_Chien db;

        public dvucustomerController()
        {
            db = new DB_Chien();
        }

        public void AddCustomer(customerModel_Chien customer)
        {
            string query = "INSERT INTO customer (tenkhachhang, so_cmt, quoctich, gioitinh, sdt) VALUES (@name, @socmt, @quoctich, @gioitinh, @sdt)";

            SqlParameter[] parameters = {
                new SqlParameter("@name", customer.NameCustomer),
                new SqlParameter("@socmt", customer.SoCCCD),
                new SqlParameter("@quoctich", customer.QuocTich ?? (object)DBNull.Value),
                new SqlParameter("@gioitinh", customer.Gioitinh ?? (object)DBNull.Value),
                new SqlParameter("@sdt", customer.SDT ?? (object)DBNull.Value)
            };

            db.ExecuteNonQuery(query, parameters);
        }


        public void UpdateCustomer(customerModel_Chien customer)
        {
            string query = "UPDATE customer SET tenkhachhang = @name, so_cmt = @socmt, quoctich = @quoctich, gioitinh = @gioitinh, sdt = @sdt WHERE Id_Customer = @id";

            SqlParameter[] parameters = {
                new SqlParameter("@name", customer.NameCustomer),
                new SqlParameter("@socmt", customer.SoCCCD),
                new SqlParameter("@quoctich", customer.QuocTich ?? (object)DBNull.Value),
                new SqlParameter("@gioitinh", customer.Gioitinh ?? (object)DBNull.Value),
                new SqlParameter("@sdt", customer.SDT ?? (object)DBNull.Value),
                new SqlParameter("@id", customer.Id_Customer) // Tham số Id để xác định bản ghi
            };

            db.ExecuteNonQuery(query, parameters);
        }

        public void RemoveCustomer(customerModel_Chien customer)
        {
            if (customer == null || customer.Id_Customer == null)
            {
                throw new ArgumentException("Khách hàng không hợp lệ.");
            }
            string query = "DELETE FROM customer WHERE id_customer = @id";
            SqlParameter[] parameters = {
                new SqlParameter("@id", customer.Id_Customer)
            };
            db.ExecuteNonQuery(query, parameters);
        }

        public DataTable GetCustomers()
        {
            string query = "SELECT id_customer AS 'ID', tenkhachhang AS 'Họ Tên', so_cmt AS 'Số CCCD', quoctich AS 'Quốc Tịch', gioitinh AS 'Giới Tính', sdt AS 'SĐT' FROM customer ORDER BY id_customer DESC";
            return db.ExecuteQuery(query);
        }
    }
}