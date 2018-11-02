using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
namespace Model.DAO
{
    public class HomeDAO
    {
        SGU db = null;
        public HomeDAO()
        {
            db = new SGU();
        }
        public IEnumerable<string> List_baidang(string loai)
        {
            IEnumerable<string> sql = (from a in db.Baidangs
                       join b in db.Loaibaidangs on a.Maloai equals b.Maloai
                       where a.Maloai==loai
                       orderby a.Ngaydang descending
                       select a.Noidung).Take(3);
            return sql.ToList();
        }
    }
}
