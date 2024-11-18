using ClosedXML.Excel;
using hotelsphere.Controller.ADMIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.UserControls.ADMIN.REPORTS
{
    public partial class UC_Reports_Customer_Chien : UserControl
    {

        private thongkeController_Chien thongkeController_Chien;
        public UC_Reports_Customer_Chien()
        {
            InitializeComponent();
            thongkeController_Chien = new thongkeController_Chien();
            LoadDataReportsCustomer_Chien();
        }

        public void LoadDataReportsCustomer_Chien()
        {
            var t = thongkeController_Chien.ThongKeKhachHang();
            dgvReportsCustomer_Chien.DataSource = t;
        }

        private void btnExcel_Chien_Click(object sender, EventArgs e)
        {
            if (dgvReportsCustomer_Chien.Rows.Count > 0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.Title = "Save an Excel File";
                    saveFileDialog.FileName = "ThongKeKhachHang.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (XLWorkbook wb = new XLWorkbook())
                            {
                                // Tạo một DataTable từ DataGridView
                                DataTable dt = new DataTable();
                                foreach (DataGridViewColumn column in dgvReportsCustomer_Chien.Columns)
                                {
                                    dt.Columns.Add(column.HeaderText, typeof(string));
                                }

                                foreach (DataGridViewRow row in dgvReportsCustomer_Chien.Rows)
                                {
                                    DataRow dr = dt.NewRow();
                                    foreach (DataGridViewCell cell in row.Cells)
                                    {
                                        dr[cell.ColumnIndex] = cell.Value?.ToString() ?? string.Empty;
                                    }
                                    dt.Rows.Add(dr);
                                }

                                // Thêm DataTable vào Excel
                                wb.Worksheets.Add(dt, "ThongKeKhachHang");

                                // Lưu file Excel
                                wb.SaveAs(saveFileDialog.FileName);
                            }

                            MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
