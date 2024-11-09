using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelsphere.Models.ADMIN
{
    public class StaffModel_Chien
    {
        [Key]
        public int IdStaff_Chien { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tài khoản")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Vui lòng nhập trong khoảng 1 - 50")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Tài khoản chỉ được chứa chữ cái, số và dấu gạch dưới")]
        public string TaiKhoan_Chien { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string HoTen_Chien { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn ngày sinh")]
        [DataType(DataType.Date)]
        public DateTime NgaySinh_Chien { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        public string GioiTinh_Chien { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,}$", ErrorMessage = "Mật khẩu phải chứa ít nhất một chữ cái, một số và một ký tự đặc biệt")]
        public string MatKhau_Chien { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn role")]
        public string Role_Chien { get; set; }
    }
}
