using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelsphere.Models
{
    public class DichVuModel
    {
        public int IdDichVu { get; set; }
        public string TenDichVu { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuongSuDung { get; set; }
    }
}
