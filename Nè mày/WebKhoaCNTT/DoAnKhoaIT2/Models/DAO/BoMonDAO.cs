using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;
using Models.ViewModel;

namespace Models.DAO
{
    public class BoMonDAO
    {
        SGU db = null;
        public BoMonDAO()
        {
            db = new SGU();
        }
        public Bomon Noidung(string mabm)
        {
            return db.Bomons.Find(mabm);
        }
        public List<BoMon_GVModel> ListGV(string mabm)
        {
            var res = (from a in db.ThongtinGVs
                       join b in db.Chucvus on a.Machucvu equals b.Machucvu
                       where a.MaBM == mabm && a.Flag == true
                       select new BoMon_GVModel
                       {
                           TenCV = b.Tenchucvu,
                           TenGV = a.TenGV,
                           Gmail = a.Diachimail
                       }).ToList();
            return res;
        }
        public List<Monhoc> ListMonHoc(string mabm)
        {
            return db.Monhocs.Where(s => s.MaBM == mabm).ToList();
        }
    }
}
