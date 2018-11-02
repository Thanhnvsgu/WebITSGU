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
    public class ThongBaoDAO
    {
        SGU db = null;
        public ThongBaoDAO()
        {
            db = new SGU();
        }



        public List<File> baidang_file(string mabaidang)
        {           
            var rs = db.Files
              .Where(e => db.Baidangs.Where(m => m.Mabaidang == e.Mabaidang && m.Mabaidang== mabaidang && e.Flag==true).Any()).ToList();
            return rs;
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
        public IEnumerable<Baidang> ListAllPaging(string txtSearch, int page, int pagesize)
        {
            if (txtSearch == null)
                return db.Baidangs.Where(s => s.ĐoituongHT == "SV" && s.Flag==true).OrderByDescending(s => s.Ngaydang).ToPagedList(page, pagesize);

            else
                return db.Baidangs.Where(s => s.ĐoituongHT == "SV" && s.Flag == true && (s.Noidung.Contains(txtSearch)|| s.Tieude.Contains(txtSearch))).OrderByDescending(s => s.Ngaydang).ToPagedList(page, pagesize);

        }


    }
}

