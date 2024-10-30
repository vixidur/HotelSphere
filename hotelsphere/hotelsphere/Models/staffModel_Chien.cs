using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelsphere.Models
{
    public class staffModel_Chien
    {
        [Key]
        public int? Id_Staff_Chien { get; set; } 

        [Display(Name = "Tài Khoản")]
        [Required(ErrorMessage = "Vui lòng nhập vào tài khoản.")]
        [StringLength(50, ErrorMessage = "Tên tài khoản không được vượt quá 50 ký tự.")]
        public string Taikhoan_Chien { get; set; } 

        [Display(Name = "Tên Nhân Viên")]
        [Required(ErrorMessage = "Vui lòng nhập vào tên nhân viên.")]
        [StringLength(100, ErrorMessage = "Tên nhân viên không được vượt quá 100 ký tự.")]
        public string NameStaff_Chien { get; set; }

        [Display(Name = "Ngày Sinh")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? NgaySinh_Chien { get; set; } 
        [Display(Name = "Giới Tính")]
        public string GioiTinh_Chien { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập vào mật khẩu.")]
        [StringLength(100, ErrorMessage = "Mật khẩu không được vượt quá 100 ký tự.")]
        [DataType(DataType.Password)]
        public string MatKhau_Chien { get; set; }

        [Display(Name = "Vai Trò")]
        public string Role_Chien { get; set; }
    }
}
