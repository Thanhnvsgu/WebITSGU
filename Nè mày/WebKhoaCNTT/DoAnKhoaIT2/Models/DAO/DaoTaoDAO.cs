using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using Models.ViewModel;
using PagedList;
namespace Models.DAO
{
    public class DaoTaoDAO
    {
        SGU db = null;
        public DaoTaoDAO()
        {
            db = new SGU();
        }
        public IEnumerable<NoidungDT> Noidungdaotao(int page, int pagesize, string maloaidt)
        {
            //if (txtSearch == null)
                return db.NoidungDTs
              .Where( e=>e.MaloaiDT == maloaidt && e.Flag==true).OrderByDescending(e => e.Ngaydang).ToPagedList(page, pagesize);
            //else
            //    return db.NoidungDTs.Where(e => db.Thongtinnguoidungs.Where(m => m.Tentaikhoan == e.Tentaikhoan && e.NoidungDT1.Contains(txtSearch)  && e.Flag == true && e.MaloaiDT == maloaidt).Any()).OrderByDescending(e => e.Ngaydang).ToPagedList(page, pagesize);
        }
        public Baidang_ThongTinNguoiDung daotao_nd(string manddt)
        {
            var res = (from a in db.NoidungDTs
                       join b in db.Thongtinnguoidungs on a.Tentaikhoan equals b.Tentaikhoan                  
                       where a.MaNDDT ==manddt && a.Flag == true
                       select new Baidang_ThongTinNguoiDung
                       {
                           Tentieude=a.Tieude,
                           Mabaidang = a.MaNDDT,
                           Noidung = a.NoidungDT1,
                           HoTen= b.Hoten,
                           Ngaydang = a.Ngaydang                          
                       }).SingleOrDefault();

            return res;

        }

    }
}
       