using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelsphere.Models.ADMIN
{
    public class ServicesModel_TuanAnh
    {
        [Key]
        public int IdServices_TA { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên dịch vụ")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Vui lòng nhập trong khoảng từ 1 - 50 ký tự")]
        public string TenDichVu_TA { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên dịch vụ")]
        [Range(0, double.MaxValue, ErrorMessage = "Vui lòng nhập giá hợp lệ")]
        public decimal GiaDichVu_TA { get; set; }
        
    }
}
