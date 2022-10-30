using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KiemTra.Model;

namespace KiemTra.ViewModel
{
    internal class NhomViewModel
    {
        public int IDNhom { get; set; } 
        public string TenNhom { get; set; }

        public static List<NhomViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.Nhom.Select(e => new NhomViewModel
            {
                IDNhom = e.IDNhom,
                TenNhom = e.TenNhom,
            }).ToList();

            return rs;
        }
    }
}
