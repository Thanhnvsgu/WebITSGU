using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using PagedList;
using Models.ViewModel;
namespace Models.DAO
{
    public class TT_TS
    {
        SGU db = null;
        public TT_TS()
        {
            db = new SGU();
        }
        public Baidang_ThongTinNguoiDung baidang_nd(string mabaidang)
        {
            var res = (from a in db.Baidangs
                       join b in db.Tags on a.TagID equals b.TagID
                       join c in db.Thongtinnguoidungs on b.Tentaikhoan equals c.Tentaikhoan
                       where a.Mabaidang == mabaidang && a.Flag == true
                       select new Baidang_ThongTinNguoiDung
                       {
                           Mabaidang = a.Mabaidang,
                           Noidung = a.Noidung,
                           HoTen = c.Hoten,
                           Ngaydang = a.Ngaydang,
                           Tentieude = a.Tieude

                       }).SingleOrDefault();

            return res;

        }
        public List<File> baidang_file(string mabaidang)
        {
            var rs = db.Files
              .Where(e => db.Baidangs.Where(m => m.Mabaidang == e.Mabaidang && m.Mabaidang == mabaidang).Any()).ToList();
            return rs;
        }
        public IEnumerable<BaidangViewModel> ListAllPaging(string maloai, int page, int pagesize)
        {
            var model = (from a in db.Baidangs
                         join b in db.Tags on a.TagID equals b.TagID
                         join c in db.ChitietLoaiBaiDangs on b.TagID equals c.TagID
                         where c.MaCTLoaiBD == maloai && a.ĐoituongHT == "SV" && a.Flag == true
                         orderby a.Ngaydang descending
                         select new BaidangViewModel()
                         {
                             Tentieude = a.Tieude,
                             Noidung = a.Noidung,
                             Mabaidang = a.Mabaidang
                         }).Take(3).ToPagedList(page, pagesize);
            return model;
        }
    }
}
