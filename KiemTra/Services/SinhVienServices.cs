using KiemTra.Model;
using KiemTra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.Services
{
    internal class SinhVienServices
    {
        public static List<SinhVienViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.SinhVien.Select(e => new SinhVienViewModel
            {
                MSV = e.MSV,
                HoDem = e.HoDem,
                Ten = e.Ten,
                NgaySinh = e.NgaySinh,
                IDNhom = e.IDNhom,
                Email = e.Email,
                SoDienThoai = e.SoDienThoai,

            }).ToList();

            return rs;
        }
        public static KetQua AddSinhVien(SinhVien sv)
        {
            var db = new AppDBContext();
            var count = db.SinhVien.Where(e => e.MSV == sv.MSV).Count();
            if (count > 0)
            {
                return 0;
            }
            else
            {
                db.SinhVien.Add(sv);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }
        }
        public static KetQua RemoveSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDBContext();
            var sinhVien = db.SinhVien.Where(e => e.MSV == sv.MSV).FirstOrDefault();
            db.SinhVien.Remove(sinhVien);
            db.SaveChanges();

            return KetQua.ThanhCong;
        }
    }
}
