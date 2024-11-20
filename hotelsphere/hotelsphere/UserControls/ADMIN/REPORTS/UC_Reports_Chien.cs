using hotelsphere.Controller.ADMIN;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace hotelsphere.UserControls.ADMIN.REPORTS
{
    public partial class UC_Reports_Chien : UserControl
    {
        private thongkeController_Chien thongkeController_Chien;
        public UC_Reports_Chien()
        {
            InitializeComponent();
            thongkeController_Chien = new thongkeController_Chien();
            decimal tongDoanhThu = thongkeController_Chien.LayTongDoanhThu_Chien();
            lblTongDoanhThu.Text = tongDoanhThu.ToString("N0") + " VNĐ";
            int tongKhachHang = thongkeController_Chien.LaySLKhachHang_Chien();
            lblTongKhachHang_Chien.Text = tongKhachHang.ToString();
            int tongNhanVien = thongkeController_Chien.LaySLNhanVien_Chien();
            lblTongNhanVien_Chien.Text = tongNhanVien.ToString();


            TongDoanhThu();

            SLPhongTheoLoai();

            LoadChart_DichVuKhachHang();
        }

        public void TongDoanhThu()
        {
            DataTable dt = thongkeController_Chien.LayChartDataDoanhThuTheoNgay();
            if (dt.Rows.Count <= 5)
            {
                chartData_Chien.Series["DoanhThu"].ChartType = SeriesChartType.Pie;
            }
            else // Bar Chart nếu dữ liệu nhiều
            {
                chartData_Chien.Series["DoanhThu"].ChartType = SeriesChartType.Column;
            }

            foreach (DataRow row in dt.Rows)
            {
                chartData_Chien.Series["DoanhThu"].Points.AddXY(row["Ngay"].ToString(), Convert.ToDecimal(row["TongDoanhThu"]));
            }
        }


        public void SLPhongTheoLoai()
        {
            DataTable dtPhong = thongkeController_Chien.LayChartDataSoLuongPhongTheoLoai();

            if (dtPhong.Rows.Count <= 5)
            {
                chartSLPhongTheoLoai_Chien.Series["SoLuongPhongTheoLoai"].ChartType = SeriesChartType.Pie;
            }
            else
            {
                chartSLPhongTheoLoai_Chien.Series["SoLuongPhongTheoLoai"].ChartType = SeriesChartType.Column;
            }

            foreach (DataRow row in dtPhong.Rows)
            {
                chartSLPhongTheoLoai_Chien.Series["SoLuongPhongTheoLoai"].Points.AddXY(row["LoaiPhong"].ToString(), Convert.ToInt32(row["SoLuongPhong"]));
            }
        }


        public void LoadChart_DichVuKhachHang()
        {
            DataTable dt = thongkeController_Chien.LayThongKeDichVuKhachHang();

            if (dt.Rows.Count <= 5) // Pie Chart nếu dữ liệu ít (<= 5 khách hàng)
            {
                chart2.Series["DichVuKhachHang"].ChartType = SeriesChartType.Pie;
            }
            else // Bar Chart nếu dữ liệu nhiều
            {
                chart2.Series["DichVuKhachHang"].ChartType = SeriesChartType.Column;
            }

            foreach (DataRow row in dt.Rows)
            {
                string tenKhachHang = row["TenKhachHang"].ToString();
                int soLuongDichVu = Convert.ToInt32(row["SoLuongDichVu"]);
                decimal tongTienDichVu = Convert.ToDecimal(row["TongTienDichVu"]);

                chart2.Series["DichVuKhachHang"].Points.AddXY(tenKhachHang, tongTienDichVu);
            }
        }



    }

}
