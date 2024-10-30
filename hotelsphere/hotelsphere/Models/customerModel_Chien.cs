using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace hotelsphere.Models
{
    public class customerModel_Chien
    {
        [Key]
        public int? Id_Customer { get; set; }

        [Display(Name = "Tên Khách Hàng")]
        [Required(ErrorMessage = "Tên khách hàng là bắt buộc.")]
        [StringLength(50, ErrorMessage = "Tên khách hàng không được vượt quá 50 ký tự.")]
        public string NameCustomer { get; set; }

        [Display(Name = "Số CCCD")]
        [Required(ErrorMessage = "Số CCCD là bắt buộc.")]
        [StringLength(12, ErrorMessage = "Số CCCD không được vượt quá 12 ký tự.")]
        public string SoCCCD { get; set; }

        [Display(Name = "Quốc Tịch")]
        [Required(ErrorMessage = "Quốc tịch là bắt buộc.")]
        [StringLength(50, ErrorMessage = "Quốc tịch không được vượt quá 50 ký tự.")]
        public string QuocTich { get; set; }

        [Display(Name = "Quốc Tịch")]
        [Required(ErrorMessage = "Quốc tịch là bắt buộc.")]
        [StringLength(50, ErrorMessage = "Quốc tịch không được vượt quá 50 ký tự.")]
        public string Gioitinh { get; set; }

        [Display(Name = "Số Điện Thoại")]
        [Required(ErrorMessage = "Số điện thoại là bắt buộc.")]
        [StringLength(15, ErrorMessage = "Số điện thoại không được vượt quá 15 ký tự.")]
        public string SDT { get; set; }

    }
}
