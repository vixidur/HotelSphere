using hotelsphere.Controller;
using hotelsphere.Controller.ADMIN;
using hotelsphere.Models;
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
    public partial class UC_Room_Admin_Chien : UserControl
    {
        public roomController_Hung rC;
        private bool flag_Hung = false;

        public UC_Room_Admin_Chien()
        {
            InitializeComponent();
            rC = new roomController_Hung();
            tabRoom_Khanh.SelectedTab = tabDanhSach_Khanh;
            tabRoom_Khanh.TabPages.Remove(tabChucNang_Khanh);
            dgvRoom_Khanh.AutoGenerateColumns = false;
            LoadDataPhong_Khanh();
            LayLoaiPhong();
        }

        public void LoadDataPhong_Khanh()
        {
            var room = rC.LayDataPhong_Khanh();
            dgvRoom_Khanh.DataSource = room;
        }

        private void txtTim_Khanh_TextChanged(object sender, EventArgs e)
        {
            string tim = txtTim_Khanh.Text;
            DataTable ketqua = rC.TimKiemPhong(tim);

            if (ketqua.Rows.Count > 0)
            {
                dgvRoom_Khanh.DataSource = ketqua;
            }
        }

        private void btnSave_Hung_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Khanh_Click(object sender, EventArgs e)
        {
            flag_Hung = false;
            tabRoom_Khanh.TabPages.Remove(tabDanhSach_Khanh);
            tabRoom_Khanh.TabPages.Add(tabChucNang_Khanh);
            tabRoom_Khanh.SelectedTab = tabChucNang_Khanh;

            IDPhong_Khanh.Clear();
            TenPhong_Khanh.Clear();
            cbLoaiPhong_Khanh.SelectedIndex = -1;
            cbTrangThai_Khanh.SelectedIndex = -1;
        }

        private void btnSave_Khanh_Click(object sender, EventArgs e)
        {
            if (cbLoaiPhong_Khanh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbTrangThai_Khanh.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RoomModel_Hung room = new RoomModel_Hung
            {
                TenPhong_Hung = TenPhong_Khanh.Text,
                IdLoaiPhong_Hung = rC.LayLPTheoID(cbLoaiPhong_Khanh.SelectedItem.ToString()),
                TinhTrangPhong_Hung = cbTrangThai_Khanh.SelectedItem.ToString(),
            };

            // Thêm mới hay cập nhật dựa trên trạng thái flag_Hung
            if (flag_Hung)
            {
                // Sửa phòng
                room.IdRoom_Hung = int.TryParse(IDPhong_Khanh.Text, out int id) ? id : 0;

                var validKetqua_Chien = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(room, new ValidationContext(room), validKetqua_Chien, true);

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
                rC.UpdateRoom_Khanh(room, cbLoaiPhong_Khanh.SelectedItem.ToString());
                MessageBox.Show("Phòng đã được cập nhật!");
            }
            else
            {
                // Kiểm tra trùng tên phòng khi thêm mới
                if (rC.KiemTraTrungTenPhong(room.TenPhong_Hung))
                {
                    MessageBox.Show("Tên phòng đã tồn tại. Vui lòng chọn tên khác.", "Lỗi trùng tên phòng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var validKetqua_Chien = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(room, new ValidationContext(room), validKetqua_Chien, true);

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

                // Thêm phòng mới
                rC.AddRoom_Khanh(room, cbLoaiPhong_Khanh.SelectedItem.ToString());
                MessageBox.Show("Thêm phòng thành công!");
            }

            // Quay lại tabDanhSach
            tabRoom_Khanh.TabPages.Remove(tabChucNang_Khanh);
            tabRoom_Khanh.TabPages.Add(tabDanhSach_Khanh);
            tabRoom_Khanh.SelectedTab = tabDanhSach_Khanh;

            LoadDataPhong_Khanh();
        }


        private void btnCancel_Khanh_Click(object sender, EventArgs e)
        {
            tabRoom_Khanh.TabPages.Remove(tabChucNang_Khanh);
            tabRoom_Khanh.TabPages.Add(tabDanhSach_Khanh);
            tabRoom_Khanh.SelectedTab = tabDanhSach_Khanh;
        }

        private DataGridViewRow selectedRow;
        private void btnXoa_Khanh_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                var rType_Hung = new RoomModel_Hung
                {
                    IdRoom_Hung = (int)selectedRow.Cells[0].Value
                };

                try
                {
                    rC.RemoveRoom_Khanh(rType_Hung);
                    LoadDataPhong_Khanh();
                    MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvRoom_Khanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRow = dgvRoom_Khanh.Rows[e.RowIndex];

                IDPhong_Khanh.Text = selectedRow.Cells[0].Value.ToString();
                TenPhong_Khanh.Text = selectedRow.Cells[1].Value.ToString();
                cbLoaiPhong_Khanh.Text = selectedRow.Cells[2].Value.ToString();
                cbTrangThai_Khanh.Text = selectedRow.Cells[4].Value.ToString();
            }
        }

        private void btnEdit_Khanh_Click(object sender, EventArgs e)
        {
            flag_Hung = true;
            tabRoom_Khanh.TabPages.Remove(tabDanhSach_Khanh);
            tabRoom_Khanh.TabPages.Add(tabChucNang_Khanh);
            tabRoom_Khanh.SelectedTab = tabChucNang_Khanh;
        }

        public void LayLoaiPhong()
        {
            List<string> roomTypes = rC.LoaiPhong();
            cbLoaiPhong_Khanh.Items.Clear();
            foreach (string roomType in roomTypes)
            {
                cbLoaiPhong_Khanh.Items.Add(roomType);
            }
            if (cbLoaiPhong_Khanh.Items.Count > 0)
            {
                cbLoaiPhong_Khanh.SelectedIndex = 0;
            }
        }

        private void UC_Room_Admin_Chien_Load(object sender, EventArgs e)
        {
            List<string> danhSachPhongChuaTonTai = rC.LayPhongChuaTonTai();

            TenPhong_Khanh.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            TenPhong_Khanh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(danhSachPhongChuaTonTai.ToArray());
            TenPhong_Khanh.AutoCompleteCustomSource = collection;
        }
    }
}
