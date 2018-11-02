using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using Models.ViewModel;
namespace Models.DAO
{
    public class GioiThieuDAO
    {
        SGU db = null;
        public GioiThieuDAO()
        {
            db = new SGU();
        }
        public Baidang_ThongTinNguoiDung Noidunggt(string magt)
        {
            var res = (from a in db.NoidungGioithieux
                       join b in db.Thongtinnguoidungs on a.Tentaikhoan equals b.Tentaikhoan
                       where a.MaGT == magt && a.Flag == true
                       select new Baidang_ThongTinNguoiDung
                       {
                           Tentieude=a.Tieude,
                           Noidung = a.NoidungGT,
                           Ngaydang = a.Ngaydang,
                           HoTen = b.Hoten
                       }).SingleOrDefault();
            
            return res;

        }
    }
}
