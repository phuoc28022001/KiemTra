using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.ViewModel
{
    public enum KetQua
    {
        TrungMa,
        ThanhCong,
    }
    internal class SinhVienViewModel
    {
    
        public string MSV { get; set; }

        public string HoDem { get; set; }

        public string Ten { get; set; }

        public DateTime? NgaySinh { get; set; }

        public int? GioiTinh { get; set; }

        public int? IDNhom { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
    }
}
