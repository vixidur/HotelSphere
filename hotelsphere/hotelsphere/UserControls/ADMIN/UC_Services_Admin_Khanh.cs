using hotelsphere.Controller;
using hotelsphere.Controller.ADMIN;
using hotelsphere.Models.ADMIN;
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

namespace hotelsphere.UserControls.ADMIN
{
    public partial class UC_Services_Admin_Khanh : UserControl
    {

        public servicesController_Khanh services;
        public bool flag_TAnh = false;
        public UC_Services_Admin_Khanh()
        {
            InitializeComponent();
            services = new servicesController_Khanh();
            tabServices_TAnh.SelectedTab = tabDanhSach_TAnh;
            tabServices_TAnh.TabPages.Remove(tabChucNang_TAnh);
            dgvDichVu_TAnh.AutoGenerateColumns = false;
            LoadDataServices_TAnh();
        }

        public void LoadDataServices_TAnh()
        {
            var serv = services.LayDataServices_TAnh();
            dgvDichVu_TAnh.DataSource = serv;
        }

        private void txtTim_TAnh_TextChanged(object sender, EventArgs e)
        {
            string tim = txtTim_TAnh.Text;
            DataTable ketqua = services.TimKiemDichVu(tim);

            if (ketqua.Rows.Count > 0)
            {
                dgvDichVu_TAnh.DataSource = ketqua;
            }
        }

        private void btnAdd_TAnh_Click(object sender, EventArgs e)
        {
            flag_TAnh = false;
            tabServices_TAnh.TabPages.Remove(tabDanhSach_TAnh);
            tabServices_TAnh.TabPages.Add(tabChucNang_TAnh);
            tabServices_TAnh.SelectedTab = tabChucNang_TAnh;

            // Xoá thông tin cũ trên TextBox
            IdServices_TAnh.Clear();
            TenDichVu_TAnh.Clear();
            GiaTien_TAnh.Clear();
        }

        private void btnCancel_TAnh_Click(object sender, EventArgs e)
        {
            tabServices_TAnh.TabPages.Remove(tabChucNang_TAnh);
            tabServices_TAnh.TabPages.Add(tabDanhSach_TAnh);
            tabServices_TAnh.SelectedTab = tabDanhSach_TAnh;
        }

        private void btnSave_TAnh_Click(object sender, EventArgs e)
        {
            // Chuyển đổi GiaTien_TAnh.Text sang decimal an toàn hơn
            if (decimal.TryParse(GiaTien_TAnh.Text, out decimal giaDichVu))
            {
                if (giaDichVu > 99999999.99m || giaDichVu < -99999999.99m)
                {
                    MessageBox.Show("Giá dịch vụ quá dài. Vui lòng nhập lại!", "Lỗi giá trị", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng giá trị giá tiền", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ServicesModel_TuanAnh s = new ServicesModel_TuanAnh
            {
                TenDichVu_TA = TenDichVu_TAnh.Text,
                GiaDichVu_TA = giaDichVu, 
            };

            // Thêm mới hay cập nhật dựa trên trạng thái flag_Hung
            if (flag_TAnh)
            {
                // Sửa dịch vụ
                s.IdServices_TA = int.TryParse(IdServices_TAnh.Text, out int id) ? id : 0;

                var validKetqua_Chien = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(s, new ValidationContext(s), validKetqua_Chien, true);

                if (!isValid)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    foreach (var validationResult in validKetqua_Chien)
                    {
                        errorMessages.AppendLine(validationResult.ErrorMessage);
                    }
                    MessageBox.Show(errorMessages.ToString(), "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật thông tin
                services.UpdateServices_TAnh(s);
                MessageBox.Show("Dịch vụ đã được cập nhật!");
            }
            else
            {
                // Kiểm tra trùng tên dịch vụ khi thêm mới
                if (services.KiemTraTrungTenDichVu(s.TenDichVu_TA))
                {
                    MessageBox.Show("Tên dịch vụ đã tồn tại. Vui lòng chọn tên khác.", "Lỗi trùng tên dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var validKetqua_Chien = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(s, new ValidationContext(s), validKetqua_Chien, true);

                if (!isValid)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    foreach (var validationResult in validKetqua_Chien)
                    {
                        errorMessages.AppendLine(validationResult.ErrorMessage);
                    }
                    MessageBox.Show(errorMessages.ToString(), "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Thêm dịch vụ mới
                services.AddServices_TAnh(s);
                MessageBox.Show("Thêm dịch vụ thành công!");
            }

            // Quay lại tabDanhSach
            tabServices_TAnh.TabPages.Remove(tabChucNang_TAnh);
            tabServices_TAnh.TabPages.Add(tabDanhSach_TAnh);
            tabServices_TAnh.SelectedTab = tabDanhSach_TAnh;
            LoadDataServices_TAnh();
        }


        private DataGridViewRow selectedRow;
        private void btnXoa_TAnh_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                var serv_TAnh = new ServicesModel_TuanAnh
                {
                    IdServices_TA = (int)selectedRow.Cells[0].Value
                };

                try
                {
                    services.RemoveServices_TAnh(serv_TAnh);
                    LoadDataServices_TAnh();
                    MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvDichVu_TAnh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvDichVu_TAnh.Rows[e.RowIndex];

                IdServices_TAnh.Text = selectedRow.Cells[0].Value.ToString();
                TenDichVu_TAnh.Text = selectedRow.Cells[1].Value.ToString();
                GiaTien_TAnh.Text = selectedRow.Cells[2].Value.ToString();
            }
        }

        private void btnEdit_TAnh_Click(object sender, EventArgs e)
        {
            flag_TAnh = true;
            tabServices_TAnh.TabPages.Remove(tabDanhSach_TAnh);
            tabServices_TAnh.TabPages.Add(tabChucNang_TAnh);
            tabServices_TAnh.SelectedTab = tabChucNang_TAnh;
        }
    }
}
