using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using Models.ViewModel;
namespace Models.DAO
{
    public class HomeDAO
    {
        SGU db = null;
        public HomeDAO()
        {
            db = new SGU();
        }
        public List<BaidangViewModel> List_baidang(string loai)
        {
            var model = (from a in db.Baidangs join b in db.Tags on a.TagID  equals b.TagID join c in db.ChitietLoaiBaiDangs on b.TagID equals c.TagID
                        where c.MaCTLoaiBD == loai && a.ĐoituongHT=="SV" &&a.Flag==true
                        orderby a.Ngaydang descending
                        select new BaidangViewModel()
                        {
                            Noidung = a.Noidung,                            
                            Mabaidang=a.Mabaidang
                        }).Take(3);
            return model.ToList();
        }
        public List<BaidangViewModel> ListAll()
        {
            var model = (from a in db.Baidangs
                         where a.ĐoituongHT=="SV" && a.Flag==true
                         orderby a.Ngaydang descending
                         select new BaidangViewModel()
                         {
                             Tentieude = a.Tieude,
                             Mabaidang = a.Mabaidang,
                             Ngaydang = a.Ngaydang
                         }).Take(10);
            return model.ToList();
        }
    }
}
