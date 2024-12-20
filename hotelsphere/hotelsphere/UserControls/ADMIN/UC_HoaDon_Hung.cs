﻿using DocumentFormat.OpenXml.VariantTypes;
using hotelsphere.Controller.ADMIN;
using hotelsphere.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelsphere.UserControls.ADMIN
{
    public partial class UC_HoaDon_Hung : UserControl
    {
        private hoadonController_Chien hd;
        public UC_HoaDon_Hung()
        {
            InitializeComponent();
            hd = new hoadonController_Chien();
            dgvHoaDon_Chien.AllowUserToAddRows = false;
        }

        public void LoadDataHoaDon_Chien()
        {
            var hondon = hd.LayDataHoaDon_Chien();
            dgvHoaDon_Chien.DataSource = hondon;

            if (dgvHoaDon_Chien.Columns["Xem Chi Tiết"] == null)
            {
                DataGridViewImageColumn detailsColumn = new DataGridViewImageColumn();
                detailsColumn.Name = "Xem Chi Tiết";
                detailsColumn.HeaderText = "Xem Chi Tiết";
                detailsColumn.Image = Properties.Resources.icon_details;
                detailsColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dgvHoaDon_Chien.Columns.Add(detailsColumn);
            }

            if (dgvHoaDon_Chien.Columns["Xóa"] == null)
            {
                DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn();
                deleteColumn.Name = "Xóa";
                deleteColumn.HeaderText = "Xóa";
                deleteColumn.Image = Properties.Resources.icon_remove;
                deleteColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                deleteColumn.Width = 40;
                dgvHoaDon_Chien.Columns.Add(deleteColumn);
            }
        }



        private void UC_HoaDon_Hung_Load(object sender, EventArgs e)
        {
            LoadDataHoaDon_Chien();

            dgvHoaDon_Chien.Columns["MaHoaDon"].HeaderText = "ID Hoá Đơn";
            dgvHoaDon_Chien.Columns["NhanVienLap"].HeaderText = "Nhân Viên Lập";
            dgvHoaDon_Chien.Columns["TenKhachHang"].HeaderText = "Tên Khách Hàng";
            dgvHoaDon_Chien.Columns["SoCCCD"].HeaderText = "Số CCCD";
            dgvHoaDon_Chien.Columns["NgayLap"].HeaderText = "Ngày Lập";
            dgvHoaDon_Chien.Columns["ThanhTien"].HeaderText = "Thành Tiền";
        }

        private void dgvHoaDon_Chien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!dgvHoaDon_Chien.Columns.Contains("Xem Chi Tiết") || !dgvHoaDon_Chien.Columns.Contains("Xóa"))
                {
                    MessageBox.Show("Không tìm thấy các cột hành động cần thiết.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string tenCot = dgvHoaDon_Chien.Columns[e.ColumnIndex].Name;
                if (tenCot == "Xem Chi Tiết")
                {
                    int maHoaDon = Convert.ToInt32(dgvHoaDon_Chien.Rows[e.RowIndex].Cells["MaHoaDon"].Value);
                    HienThiChiTietHoaDon(maHoaDon);
                }
                else if (tenCot == "Xóa")
                {
                    var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hoá đơn này không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            int maHoaDon = Convert.ToInt32(dgvHoaDon_Chien.Rows[e.RowIndex].Cells["MaHoaDon"].Value);
                            XoaHoaDon(maHoaDon);
                            MessageBox.Show("Xóa hoá đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvHoaDon_Chien.DataSource = hd.LayDataHoaDon_Chien(); 
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lựa chọn không tồn tại. Vui lòng chọn vào hàng có giá trị");
                }
            }
        }

        private void HienThiChiTietHoaDon(int maHoaDon)
        {
            //MessageBox.Show("check ma nhé: " + maHoaDon);
            ChiTietHoaDon chiTietHoaDon = new ChiTietHoaDon(maHoaDon);
            chiTietHoaDon.Show();
        }

        private void txtSearchRoomType_Chien_TextChanged(object sender, EventArgs e)
        {
            string tim = txtTimHoaDon_Chien.Text;
            DataTable ketqua = hd.TimKiemHoaDon(tim);

            if (ketqua.Rows.Count > 0)
            {
                dgvHoaDon_Chien.DataSource = ketqua;
            }
        }

        private void XoaHoaDon(int maHoaDon)
        {
            hd.XoaHoaDon_Chien(maHoaDon);
        }
    }
}
