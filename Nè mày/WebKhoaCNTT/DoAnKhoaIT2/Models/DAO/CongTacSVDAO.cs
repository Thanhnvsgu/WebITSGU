using Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagedList;
using Models.ViewModel;
namespace Models.DAO
{
    public class CongTacSVDAO
    {
        SGU db = null;
        public CongTacSVDAO()
        {
            db = new SGU();
        }
        public IEnumerable<NDCongtacSV> ListALL(string mact,int page,int pagesize)
        {
            return db.NDCongtacSVs.Where(s => s.MaCTSV == mact && s.flag == true).OrderByDescending(s => s.Ngaydang).ToPagedList(page, pagesize);
        }
        public CTSV_ThongTinND ThongTinCTSV(string mandct)
        {
            var res = (from a in db.NDCongtacSVs
                       join b in db.Thongtinnguoidungs on a.Tentaikhoan equals b.Tentaikhoan
                       where a.MaNDCTSV == mandct && a.flag == true && b.Flag == true
                       select new CTSV_ThongTinND
                       {
                           Tieude = a.Tieude,
                           Noidung = a.NoidungCTSV,
                           Ngaydang = a.Ngaydang,
                           TenTK = b.Tentaikhoan
                       }).SingleOrDefault();
            return res;
        }
        public List<File> NoidungCTSV_file(string mandct)
        {
            var rs = db.Files
              .Where(e => db.NDCongtacSVs.Where(m => m.MaNDCTSV == e.MaNDCTSV && m.MaNDCTSV == mandct && e.Flag == true).Any()).ToList();
            return rs;
        }
    }
}
