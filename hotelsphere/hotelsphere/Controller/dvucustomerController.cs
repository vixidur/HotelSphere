using System;
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
            string deleteInvoiceQuery = "DELETE FROM hoadon WHERE id_customer = @id";
            SqlParameter[] invoiceParams = {
                new SqlParameter("@id", customer.Id_Customer)
            };
            db.ExecuteNonQuery(deleteInvoiceQuery, invoiceParams);
            string deleteCustomerQuery = "DELETE FROM customer WHERE id_customer = @id";
            SqlParameter[] customerParams = {
                new SqlParameter("@id", customer.Id_Customer)
            };
            db.ExecuteNonQuery(deleteCustomerQuery, customerParams);
        }


        public DataTable GetCustomers()
        {
            string query = "SELECT * FROM customer ORDER BY id_customer DESC";
            return db.ExecuteQuery(query);
        }

        public DataTable SearchCustomer(string searchTerm)
        {
            string query = @"
        SELECT * FROM customer
        WHERE tenkhachhang LIKE @searchTerm OR so_cmt LIKE @searchTerm
        ORDER BY id_customer DESC";

            SqlParameter[] parameters = {
                new SqlParameter("@searchTerm", "%" + searchTerm + "%")
            };

            return db.ExecuteQuery(query, parameters);
        }

    }
}
