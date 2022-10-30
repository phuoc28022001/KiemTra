using KiemTra.Model;
using KiemTra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.Services
{
    internal class NhomServices
    {
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
        public static KetQua AddNhom(Nhom l)
        {
            var db = new AppDBContext();
            var count = db.Nhom.Where(e => e.IDNhom == l.IDNhom).Count();
            if (count > 0)
            {
                return 0;
            }
            else
            {
                db.Nhom.Add(l);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static KetQua RemoveNhom(NhomViewModel l)
        {
            var db = new AppDBContext();
            var lopHoc = db.Nhom.Where(e => e.IDNhom == l.IDNhom).FirstOrDefault();
            db.Nhom.Remove(lopHoc);
            db.SaveChanges();

            return KetQua.ThanhCong;
        }
    }
}
