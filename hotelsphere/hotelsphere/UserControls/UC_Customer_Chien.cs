﻿using Guna.UI2.WinForms;
using hotelsphere.Controller;
using hotelsphere.Models;
using hotelsphere.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.UserControls
{
    public partial class UC_Customer_Chien : UserControl
    {
        private iStaff_Chien IStaff_Chien;
        private dvucustomerController customerService_Chien;
        private roomController roomController;
        public int? IdStaff { get; set; }
        public string TenNhanVien { get; set; }
        private bool isFlag_Chien = false;
        public UC_Customer_Chien(iStaff_Chien ic, int? idStaff)
        {
            InitializeComponent();
            IStaff_Chien = ic;
            customerService_Chien = new dvucustomerController();
            tabControl_Chien.SelectedTab = tabDSCustomer_Chien;
            tabControl_Chien.TabPages.Remove(tabChucnang);
            dgvCustomer_Chien.AutoGenerateColumns = false;
            LoadCustomers();
            roomController = new roomController();
            IdStaff = idStaff;
        }

        private void ClearTextFields()
        {
            idCustomer_Chien.Text = string.Empty;
            tenCustomer_Chien.Text = string.Empty;
            soCCCD_Chien.Text = string.Empty;
            quoctich_Chien.Text = string.Empty;
            gioitinh_Chien.SelectedItem = null;
            sdt_Chien.Text = string.Empty;
        }


        private void clearErrorMessages()
        {
            nameError_Chien.Text = string.Empty;
            socccdError_Chien.Text = string.Empty;
            quoctichError_Chien.Text = string.Empty;
            gioitinhError_Chien.Text = string.Empty;
            sdtError_Chien.Text = string.Empty;
        }

        private void LoadCustomers()
        {
            var customers = customerService_Chien.GetCustomers();
            dgvCustomer_Chien.DataSource = customers;
        }
        private customerModel_Chien customerModel;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (IStaff_Chien != null)
            {
                if (selectedRow == null || selectedRow.Cells[0].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng trước khi tiến hành đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int idCustomer = int.Parse(selectedRow.Cells[0].Value.ToString());
                string soCCCD = selectedRow.Cells[2].Value?.ToString() ?? string.Empty;
                string tenKhachHang = selectedRow.Cells[1].Value?.ToString() ?? string.Empty;
                string quocTich = selectedRow.Cells[3].Value?.ToString() ?? string.Empty;

                // Khởi tạo đối tượng customerModel và lưu vào biến toàn cục
                customerModel = new customerModel_Chien
                {
                    Id_Customer = idCustomer,
                    SoCCCD = soCCCD,
                    NameCustomer = tenKhachHang,
                    QuocTich = quocTich
                };
                UC_Room_Chien ucRoomChien = new UC_Room_Chien(customerModel, IdStaff, TenNhanVien);
                IStaff_Chien.ThemUserControl(ucRoomChien);

                ucRoomChien.RoomSelected += (s, args) =>
                {
                    ThongTinHoaDon_Chien thongTinHoaDon = new ThongTinHoaDon_Chien(roomController, ucRoomChien, customerModel, IdStaff)
                    {
                        CustomerName_Chien = tenKhachHang,
                        RoomType_Chien = ucRoomChien.TenLoaiPhong,
                        StatusRoom_Chien = ucRoomChien.TrangThaiPhong,
                        RentDate_Chien = DateTime.Now,
                        ReturnDate_Chien = DateTime.Now.AddDays(1),
                    };
                    thongTinHoaDon.ShowDialog();
                };
            }
            else
            {
                MessageBox.Show("Không thể tiến hành đặt phòng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            tabControl_Chien.TabPages.Remove(tabChucnang);
            tabControl_Chien.TabPages.Add(tabDSCustomer_Chien);
            tabControl_Chien.SelectedTab = tabDSCustomer_Chien;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                isFlag_Chien = false; 
                if (selectedRow.Cells[0].Value != null)
                    idCustomer_Chien.Text = selectedRow.Cells[0].Value.ToString();

                if (selectedRow.Cells[1].Value != null)
                    tenCustomer_Chien.Text = selectedRow.Cells[1].Value.ToString();

                if (selectedRow.Cells[2].Value != null)
                    soCCCD_Chien.Text = selectedRow.Cells[2].Value.ToString();

                if (selectedRow.Cells[3].Value != null)
                    quoctich_Chien.Text = selectedRow.Cells[3].Value.ToString();

                if (selectedRow.Cells[4].Value != null)
                    gioitinh_Chien.Text = selectedRow.Cells[4].Value.ToString();

                if (selectedRow.Cells[5].Value != null)
                    sdt_Chien.Text = selectedRow.Cells[5].Value.ToString();

                tabControl_Chien.TabPages.Remove(tabDSCustomer_Chien);
                tabControl_Chien.TabPages.Add(tabChucnang);
                tabControl_Chien.SelectedTab = tabChucnang;
                tabChucnang.Text = "Thay đổi thông tin";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bản ghi trước khi sửa.");
            }
        }
        private DataGridViewRow selectedRow;

        private void dgvCustomer_Chien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvCustomer_Chien.Rows[e.RowIndex];

                idCustomer_Chien.Text = selectedRow.Cells[0].Value.ToString();
                tenCustomer_Chien.Text = selectedRow.Cells[1].Value.ToString();
                soCCCD_Chien.Text = selectedRow.Cells[2].Value.ToString();
                quoctich_Chien.Text = selectedRow.Cells[3].Value.ToString();
                gioitinh_Chien.Text = selectedRow.Cells[4].Value.ToString();
                sdt_Chien.Text = selectedRow.Cells[5].Value.ToString();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                var customer = new customerModel_Chien
                {
                    Id_Customer = (int?)selectedRow.Cells[0].Value
                };

                try
                {
                    customerService_Chien.RemoveCustomer(customer);
                    LoadCustomers();
                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bản ghi trước khi xóa.");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var customer = new customerModel_Chien
            {
                Id_Customer = isFlag_Chien ? null : (int?)int.Parse(idCustomer_Chien.Text), 
                NameCustomer = tenCustomer_Chien.Text,
                SoCCCD = soCCCD_Chien.Text,
                QuocTich = quoctich_Chien.Text,
                Gioitinh = gioitinh_Chien.SelectedItem?.ToString() ?? string.Empty,
                SDT = sdt_Chien.Text
            };

            var validationContext = new ValidationContext(customer);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(customer, validationContext, validationResults, true);

            clearErrorMessages();

            if (!isValid)
            {
                foreach (var validationResult in validationResults)
                {
                    switch (validationResult.MemberNames.FirstOrDefault())
                    {
                        case "NameCustomer":
                            nameError_Chien.Text = validationResult.ErrorMessage;
                            nameError_Chien.ForeColor = Color.Red;
                            break;
                        case "SoCCCD":
                            socccdError_Chien.Text = validationResult.ErrorMessage;
                            socccdError_Chien.ForeColor = Color.Red;
                            break;
                        case "QuocTich":
                            quoctichError_Chien.Text = validationResult.ErrorMessage;
                            quoctichError_Chien.ForeColor = Color.Red;
                            break;
                        case "Gioitinh":
                            gioitinhError_Chien.Text = validationResult.ErrorMessage;
                            gioitinhError_Chien.ForeColor = Color.Red;
                            break;
                        case "SDT":
                            sdtError_Chien.Text = validationResult.ErrorMessage;
                            sdtError_Chien.ForeColor = Color.Red;
                            break;
                    }
                }
                return;
            }

            try
            {
                if (isFlag_Chien)
                {
                    // Xử lý thêm khách hàng
                    customerService_Chien.AddCustomer(customer);
                    MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Xử lý cập nhật khách hàng
                    customerService_Chien.UpdateCustomer(customer);
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reset trạng thái và giao diện
                isFlag_Chien = false;
                ClearTextFields();
                LoadCustomers();
                tabControl_Chien.TabPages.Remove(tabChucnang);
                tabControl_Chien.TabPages.Add(tabDSCustomer_Chien);
                tabControl_Chien.SelectedTab = tabDSCustomer_Chien;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            isFlag_Chien = true;
            ClearTextFields(); 
            tabControl_Chien.TabPages.Remove(tabDSCustomer_Chien);
            tabControl_Chien.TabPages.Add(tabChucnang);
            tabControl_Chien.SelectedTab = tabChucnang;
        }

        private void txtSearchCustomer_Chien_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchCustomer_Chien.Text;
            DataTable searchResults = customerService_Chien.SearchCustomer(searchTerm);

            if (searchResults.Rows.Count > 0)
            {
                dgvCustomer_Chien.DataSource = searchResults;
            }
        }
    }
}
