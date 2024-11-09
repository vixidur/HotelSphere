using hotelsphere.UserControls.ADMIN;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelsphere.Models.ADMIN
{
    public class RoomModel_Hung
    {
        [Key]
        public int IdRoom_Hung { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên phòng")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Tên phòng phải có độ dài từ 1 đến 50 ký tự")]
        public string TenPhong_Hung { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn loại phòng")]
        public int IdLoaiPhong_Hung { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn tình trạng phòng")]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "Tình trạng phòng phải có độ dài từ 1 đến 20 ký tự")]
        public string TinhTrangPhong_Hung { get; set; }
        [ForeignKey("IdLoaiPhong_Hung")]
        public virtual RoomTypeModel_Hung LoaiPhong_Hung { get; set; }
    }
}
