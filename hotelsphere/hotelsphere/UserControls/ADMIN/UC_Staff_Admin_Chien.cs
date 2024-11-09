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
    public partial class UC_Staff_Admin_Chien : UserControl
    {
        private staffController_Chien staff;
        private bool flag_Chien = false; 
        public UC_Staff_Admin_Chien()
        {
            InitializeComponent();
            staff = new staffController_Chien();
            tabStaff_Chien.SelectedTab = tabDanhSach;
            tabStaff_Chien.TabPages.Remove(tabChucNang);
            dgvStaff_Chien.AutoGenerateColumns = false;
            LoadDataStaff_Chien();
        }

        public void LoadDataStaff_Chien()
        {
            var staffs = staff.LayDataStaff_Chien();
            dgvStaff_Chien.DataSource = staffs;
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            string tim = txtTim.Text;
            DataTable ketqua = staff.TimKimNhanVien(tim);

            if (ketqua.Rows.Count > 0)
            {
                dgvStaff_Chien.DataSource = ketqua;
            }
        }
        private DataGridViewRow selectedRow;

        private void dgvStaff_Chien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvStaff_Chien.Rows[e.RowIndex];

                IdStaff_Chien.Text = selectedRow.Cells[0].Value.ToString();
                TaiKhoan_Chien.Text = selectedRow.Cells[1].Value.ToString();
                HoTen_Chien.Text = selectedRow.Cells[2].Value.ToString();
                dtpNgaySinh_Chien.Value = (DateTime)selectedRow.Cells[3].Value;
                MatKhau_Chien.Text = selectedRow.Cells[5].Value.ToString();
                cbVaiTro_Chien.Text = selectedRow.Cells[6].Value.ToString();

                string gioiTinh = selectedRow.Cells[4].Value.ToString();
                if (gioiTinh == "Nam")
                {
                    rdBoy_Chien.Checked = true;
                    rdGirl_Chien.Checked = false;
                }
                else if (gioiTinh == "Nữ")
                {
                    rdBoy_Chien.Checked = false;
                    rdGirl_Chien.Checked = true;
                }
            }
        }

        private void btnAdd_Chien_Click(object sender, EventArgs e)
        {
            flag_Chien = false;
            tabStaff_Chien.TabPages.Remove(tabDanhSach);
            tabStaff_Chien.TabPages.Add(tabChucNang);
            tabStaff_Chien.SelectedTab = tabChucNang;

            // Xoá thông tin cũ trên TextBox, DateTime, ComboBox, Radio
            IdStaff_Chien.Clear();
            HoTen_Chien.Clear();
            TaiKhoan_Chien.Clear();
            MatKhau_Chien.Clear();

            rdBoy_Chien.Checked = false;
            rdGirl_Chien.Checked = false;
            dtpNgaySinh_Chien.Value = DateTime.Now;
            cbVaiTro_Chien.SelectedIndex = -1;

        }

        private void btnEdit_Chien_Click(object sender, EventArgs e)
        {
            flag_Chien = true;
            tabStaff_Chien.TabPages.Remove(tabDanhSach);
            tabStaff_Chien.TabPages.Add(tabChucNang);
            tabStaff_Chien.SelectedTab = tabChucNang;
        }

        private void btnXoa_Chien_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                var staffModel = new StaffModel_Chien
                {
                    IdStaff_Chien = (int)selectedRow.Cells[0].Value
                };

                try
                {
                    staff.RemoveStaff_Chien(staffModel);
                    LoadDataStaff_Chien();
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancel_Chien_Click(object sender, EventArgs e)
        {
            tabStaff_Chien.TabPages.Remove(tabChucNang);
            tabStaff_Chien.TabPages.Add(tabDanhSach);
            tabStaff_Chien.SelectedTab = tabDanhSach;
        }

        private void btnSave_Chien_Click(object sender, EventArgs e)
        {
            string gioitinh = rdBoy_Chien.Checked ? "Nam" : (rdGirl_Chien.Checked ? "Nữ" : "");

            // Tạo đối tượng StaffModel_Chien từ dữ liệu đầu vào
            StaffModel_Chien staffs = new StaffModel_Chien
            {
                HoTen_Chien = HoTen_Chien.Text.Trim(),
                TaiKhoan_Chien = TaiKhoan_Chien.Text.Trim(),
                MatKhau_Chien = MatKhau_Chien.Text.Trim(),
                Role_Chien = cbVaiTro_Chien.Text.Trim(),
                NgaySinh_Chien = dtpNgaySinh_Chien.Value,
                GioiTinh_Chien = gioitinh
            };
            // Kiểm tra tính hợp lệ của dữ liệu
            var validKetqua_Chien = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(staffs, new ValidationContext(staffs), validKetqua_Chien, true);

            if (!isValid)
            {
                // Nếu dữ liệu không hợp lệ, hiển thị lỗi
                StringBuilder errorMessages = new StringBuilder();
                foreach (var validationResult in validKetqua_Chien)
                {
                    errorMessages.AppendLine(validationResult.ErrorMessage);
                }
                MessageBox.Show(errorMessages.ToString(), "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực hiện thêm mới nhân viên
            try
            {
                if (flag_Chien)
                {
                    // Cập nhật nhân viên
                    staffs.IdStaff_Chien = int.TryParse(IdStaff_Chien.Text, out int id) ? id : 0;
                    staff.UpdateStaff_Chien(staffs);
                    MessageBox.Show("Nhân viên đã được cập nhật!");
                }
                else
                {
                    // Kiểm tra tài khoản đã tồn tại chưa ngay lập tức
                    if (staff.KiemTraTrungTaiKhoan(staffs.TaiKhoan_Chien))
                    {
                        // Nếu tài khoản đã tồn tại, hiển thị thông báo lỗi và dừng lại
                        MessageBox.Show("Tài khoản này đã tồn tại. Vui lòng nhập tài khoản khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;  // Dừng lại và không tiếp tục thêm nhân viên
                    }

                    // Thêm mới nhân viên
                    staff.AddStaff_Chien(staffs);
                    //MessageBox.Show("Thêm nhân viên thành công!");
                }

                // Quay lại tabDanhSach
                tabStaff_Chien.TabPages.Remove(tabChucNang);
                tabStaff_Chien.TabPages.Add(tabDanhSach);
                tabStaff_Chien.SelectedTab = tabDanhSach;

                // Nạp lại dữ liệu nhân viên
                LoadDataStaff_Chien();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi trong quá trình thêm hoặc cập nhật
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_Staff_Admin_Chien_Load(object sender, EventArgs e)
        {
            staff = new staffController_Chien();
            List<string> ListStaffChuaTonTai = staff.LayTaiKhoanChuaTonTai();

            TaiKhoan_Chien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TaiKhoan_Chien.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(ListStaffChuaTonTai.ToArray());
            TaiKhoan_Chien.AutoCompleteCustomSource = collection;
        }
    }
}
