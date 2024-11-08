using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelsphere.UserControls.ADMIN
{
    public class RoomTypeModel_Hung
    {
        [Key]
        public int IdRoomType_Hung { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên loại phòng")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Vui lòng nhập trong khoảng từ 1 - 50 ký tự")]
        public string NameRoomType_Hung { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Vui lòng nhập giá hợp lệ")]
        public decimal PricePerDay_Hung { get; set; }
        public string Description_Hung { get; set; }

    }
}
