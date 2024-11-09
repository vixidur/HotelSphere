using hotelsphere.Controller.ADMIN;
using hotelsphere.Models;
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
    public partial class UC_RoomType_Admin_Chien : UserControl
    {

        public roomtypeController_Hung rTc;
        private bool flag_Hung = false;
        public UC_RoomType_Admin_Chien()
        {
            InitializeComponent();
            rTc = new roomtypeController_Hung();
            tabRoomType.SelectedTab = tabDanhSach;
            tabRoomType.TabPages.Remove(tabChucNang);
            dgvRoomType_Hung.AutoGenerateColumns = false;
            LoadAllRoomType_Hung();
        }

        public void LoadAllRoomType_Hung()
        {
            var roomType_Hung = rTc.LayDataLoaiPhong();
            dgvRoomType_Hung.DataSource = roomType_Hung;
        }

        private void txtSearchRoomType_Chien_TextChanged(object sender, EventArgs e)
        {
            string tim = txtSearchRoomType_Chien.Text;
            DataTable ketqua = rTc.TimKiemLoaiPhong(tim);

            if (ketqua.Rows.Count > 0)
            {
                dgvRoomType_Hung.DataSource = ketqua;
            }
        }

        private void btnAdd_Hung_Click(object sender, EventArgs e)
        {
            flag_Hung = false; 
            tabRoomType.TabPages.Remove(tabDanhSach);
            tabRoomType.TabPages.Add(tabChucNang);
            tabRoomType.SelectedTab = tabChucNang;

            // Xoá thông tin cũ trên TextBox
            IdLoaiPhong_Hung.Clear();
            TenLoaiPhong_Hung.Clear();
            GiaTien_Hung.Clear();
            MoTa_Hung.Clear();
        }

        private void btnEdit_Hung_Click(object sender, EventArgs e)
        {
            flag_Hung = true;
            tabRoomType.TabPages.Remove(tabDanhSach);
            tabRoomType.TabPages.Add(tabChucNang);
            tabRoomType.SelectedTab = tabChucNang;
        }
        private DataGridViewRow selectedRow;
        private void dgvRoomType_Hung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvRoomType_Hung.Rows[e.RowIndex];

                IdLoaiPhong_Hung.Text = selectedRow.Cells[0].Value.ToString();
                TenLoaiPhong_Hung.Text = selectedRow.Cells[1].Value.ToString();
                GiaTien_Hung.Text = selectedRow.Cells[2].Value.ToString();
                MoTa_Hung.Text = selectedRow.Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Hung_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                var rType_Hung = new RoomTypeModel_Hung
                {
                    IdRoomType_Hung = (int)selectedRow.Cells[0].Value
                };

                try
                {
                    rTc.RemoveRoomType_Hung(rType_Hung);
                    LoadAllRoomType_Hung();
                    MessageBox.Show("Xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSave_Hung_Click(object sender, EventArgs e)
        {
            decimal price;
            if (!decimal.TryParse(GiaTien_Hung.Text, out price))
            {
                MessageBox.Show("Vui lòng nhập giá phòng hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RoomTypeModel_Hung roomType = new RoomTypeModel_Hung
            {
                NameRoomType_Hung = TenLoaiPhong_Hung.Text,
                PricePerDay_Hung = price,
                Description_Hung = MoTa_Hung.Text
            };

            // Thêm mới hay cập nhật dựa trên trạng thái flag_Hung
            if (flag_Hung)
            {
                // Sửa loại phòng
                roomType.IdRoomType_Hung = int.TryParse(IdLoaiPhong_Hung.Text, out int id) ? id : 0;

                var validKetqua_Chien = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(roomType, new ValidationContext(roomType), validKetqua_Chien, true);

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
                rTc.UpdateRoomType_Hung(roomType);
                MessageBox.Show("Loại phòng đã được cập nhật!");
            }
            else
            {
                // Thêm mới loại phòng
                var validKetqua_Chien = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(roomType, new ValidationContext(roomType), validKetqua_Chien, true);

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

                // Thêm loại phòng mới
                rTc.AddRoomType_Hung(roomType);
                MessageBox.Show("Thêm loại phòng thành công!");
            }

            // Quay lại tabDanhSach
            tabRoomType.TabPages.Remove(tabChucNang);
            tabRoomType.TabPages.Add(tabDanhSach);
            tabRoomType.SelectedTab = tabDanhSach;

            LoadAllRoomType_Hung();
        }

        private void btnCancel_Hung_Click(object sender, EventArgs e)
        {
            tabRoomType.TabPages.Remove(tabChucNang);
            tabRoomType.TabPages.Add(tabDanhSach);
            tabRoomType.SelectedTab = tabDanhSach;
        }
    }
}
