using hotelsphere.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.IO;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using HorizontalAlignment = iText.Layout.Properties.HorizontalAlignment;
using Image = iText.Layout.Element.Image;
using iText.Layout.Borders;

namespace hotelsphere.View
{
    public partial class InHoaDon : Form
    {
        public string CustomerName { get; set; }
        public int InvoiceNumber { get; set; }
        public string RoomName { get; set; }
        public int TotalDays { get; set; }
        public string RoomType { get; set; }
        public string StaffName { get; set; }
        public decimal TotalRoomPrice { get; set; }
        public decimal TotalServicePrice { get; set; }
        servicesController serviceController;
        public InHoaDon()
        {
            serviceController = new servicesController();
            InitializeComponent();
        }

        public void HienthiHoaDonChiTiet()
        {
            lblCustomerName_Chien.Text = CustomerName;
            lblNgayLapHoaDon_Khanh.Text = "Ngày lập hoá đơn: " + DateTime.Now.ToString();
            lblSoHoaDon_Hung.Text = "Số hoá đơn: " + InvoiceNumber.ToString();
            lblTenPhong_TAnh.Text = "Số phòng: " + RoomName;
            lblSoNgayThue_Chien.Text = "Số ngày " + TotalDays.ToString();
            lblLoaiPhong_Chien.Text = "Loại phòng: " + RoomType;
            lblNameStaff_Chien.Text = "Nhân viên: " + StaffName;
            lblTongTienThuePhong.Text = TotalRoomPrice.ToString("N0");
            lblTongGiaDichVu.Text = TotalServicePrice.ToString("N0");

            // Hiển thị dịch vụ sử dụng trong bảng
            DataTable serviceDetails = serviceController.LayDataService_Chien(); // Lấy dữ liệu dịch vụ
            dgvDichVuHoaDon_Chien.DataSource = serviceDetails;

            // Hiển thị tổng tiền
            lblTongTien.Text = (TotalRoomPrice + TotalServicePrice).ToString("N0") + " VNĐ";
        }

        private void btnPrinter_Chien_Click(object sender, EventArgs e)
        {
            // Open SaveFileDialog to choose file name and location
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Lưu Hoá Đơn";
                saveFileDialog.FileName = "HoaDon.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Tạo ra file PDF
                    try
                    {
                        using (PdfWriter writer = new PdfWriter(filePath))
                        using (PdfDocument pdf = new PdfDocument(writer))
                        using (Document document = new Document(pdf))
                        {
                            // Đường dẫn gốc đến ./hotelsphere/hotelsphere
                            string baseDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                            // Đường dẫn đến file *.ttf hỗ trợ Tiếng Việt
                            string fontPath = Path.Combine(baseDir, "fonts", "arial-unicode-ms-regular.ttf");
                            PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
                            document.SetFont(font);

                            // Đường dẫn đến ./hotelsphere/hotelsphere/images/logo.png
                            string logoPath = Path.Combine(baseDir, "images", "logo.png");
                            Image logo = new Image(ImageDataFactory.Create(logoPath));
                            logo.SetWidth(100);
                            logo.SetHorizontalAlignment(HorizontalAlignment.CENTER);
                            document.Add(logo);

                            // Tiêu đề file PDF
                            document.Add(new Paragraph("HOÁ ĐƠN")
                                .SetFontSize(18)
                                .SetBold()
                                .SetTextAlignment(TextAlignment.CENTER));

                            // Tạo một Table với 2 cột để căn chỉnh nội dung
                            Table table = new Table(2);
                            table.SetWidth(UnitValue.CreatePercentValue(100));

                            // Thêm các dòng vào table cho bên trái và bên phải
                            table.AddCell(new Cell().Add(new Paragraph("Khách hàng: " + CustomerName))
                                .SetTextAlignment(TextAlignment.LEFT)
                                .SetBorder(Border.NO_BORDER));
                            table.AddCell(new Cell().Add(new Paragraph("Số phòng: " + RoomName))
                                .SetTextAlignment(TextAlignment.RIGHT)
                                .SetBorder(Border.NO_BORDER));

                            table.AddCell(new Cell().Add(new Paragraph("Ngày lập hóa đơn: " + DateTime.Now.ToString("dd-MM-yyyy")))
                                .SetTextAlignment(TextAlignment.LEFT)
                                .SetBorder(Border.NO_BORDER));
                            table.AddCell(new Cell().Add(new Paragraph("Số ngày: " + TotalDays))
                                .SetTextAlignment(TextAlignment.RIGHT)
                                .SetBorder(Border.NO_BORDER));

                            table.AddCell(new Cell().Add(new Paragraph("Số hóa đơn: " + InvoiceNumber))
                                .SetTextAlignment(TextAlignment.LEFT)
                                .SetBorder(Border.NO_BORDER));
                            table.AddCell(new Cell().Add(new Paragraph("Loại phòng: " + RoomType))
                                .SetTextAlignment(TextAlignment.RIGHT)
                                .SetBorder(Border.NO_BORDER));

                            table.AddCell(new Cell().Add(new Paragraph("Nhân viên: " + StaffName))
                                .SetTextAlignment(TextAlignment.LEFT)
                                .SetBorder(Border.NO_BORDER));
                            table.AddCell(new Cell().SetBorder(Border.NO_BORDER));  // Ô trống cho căn chỉnh

                            // Thêm bảng vào tài liệu
                            document.Add(table);

                            // Dịch vụ (table)
                            Table serviceTable = new Table(UnitValue.CreatePercentArray(new float[] { 10, 40, 20, 15, 15 }));
                            serviceTable.SetWidth(UnitValue.CreatePercentValue(100));

                            string[] headers = { "ID", "Tên Dịch Vụ", "Giá Tiền", "Số Lượng", "Thành Tiền" };
                            foreach (string header in headers)
                            {
                                serviceTable.AddHeaderCell(new Cell().Add(new Paragraph(header).SetBold()).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                            }

                            foreach (DataGridViewRow row in dgvDichVuHoaDon_Chien.Rows)
                            {
                                if (row.Cells[0].Value != null)
                                {
                                    for (int i = 0; i < row.Cells.Count; i++)
                                    {
                                        serviceTable.AddCell(new Cell().Add(new Paragraph(row.Cells[i].Value.ToString())));
                                    }
                                }
                            }

                            document.Add(serviceTable);

                            document.Add(new Paragraph("TỔNG TIỀN: " + (TotalRoomPrice + TotalServicePrice).ToString("N0") + " VNĐ")
                                .SetBold().SetTextAlignment(TextAlignment.CENTER).SetFontColor(ColorConstants.RED));

                            document.Add(new Paragraph("CẢM ƠN QUÝ KHÁCH!")
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetFontSize(14)
                                .SetBold()
                                .SetFontColor(ColorConstants.BLUE));
                        }

                        // Thông báo thành công
                        MessageBox.Show("Hóa đơn đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (IOException ioEx)
                    {
                        MessageBox.Show("Lỗi khi ghi file: " + ioEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}
