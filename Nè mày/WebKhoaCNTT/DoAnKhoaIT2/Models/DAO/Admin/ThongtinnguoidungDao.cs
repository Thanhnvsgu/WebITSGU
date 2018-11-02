using Models.EF;
using Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO.Admin
{
    public class ThongtinnguoidungDao
    {
        SGU db = null;
        public ThongtinnguoidungDao()
        {
            db = new SGU();
        }
        public List<Taikhoan> Listtaikhoan()
        {
            var res = db.Taikhoans.ToList();
            return res;
        }
        public List<Chucvu> Listchucvu()
        {
            return db.Chucvus.ToList();
        }
        public List<Quyennguoidung> Listquyen()
        {
            return db.Quyennguoidungs.ToList();
        }
        public bool Themtaikhoan(Taikhoan entity)
        {
            var x = db.Taikhoans.Find(entity.Tentaikhoan);
            entity.TGdangki = System.DateTime.Now;
            entity.Trangthaihd = "Offline";
            if (x != null) return false;
            var res = db.Taikhoans.Add(entity);
            db.SaveChanges();
            return true;
        }
        public bool Themthongtin(string id,Thongtinnguoidung entity)
        {
            entity.Tentaikhoan = id;
            entity.Flag = true;
            var res = db.Thongtinnguoidungs.Add(entity);
            db.SaveChanges();
            return true;
        }
        public Taikhoan timtaikhoan(string tentaikhoan)
        {
            return db.Taikhoans.Find(tentaikhoan);
        }
        public Thongtinnguoidung timthongtin(string tentaikhoan)
        {
            var res = db.Thongtinnguoidungs.Where(Model => Model.Tentaikhoan == tentaikhoan);
            return res.SingleOrDefault();
        }
        public bool Suataikhoan(Taikhoan entity)
        {
            var res = db.Taikhoans.Find(entity.Tentaikhoan);
            if (res != null)
            {
                res.Matkhau = entity.Matkhau;
                res.Mail = entity.Mail;
                res.Machucvu = entity.Machucvu;
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool suathongtin(string id,Thongtinnguoidung entity)
        {
            var res = db.Thongtinnguoidungs.Where(model => model.Tentaikhoan == id).SingleOrDefault();
            res.Hoten = entity.Hoten;
            res.Namsinh = entity.Namsinh;
            res.Sodienthoai = entity.Sodienthoai;
            res.Quequan = entity.Quequan;
            db.SaveChanges();
            return true;

        }
        public IEnumerable<Chucvu> Ichucvu()
        {
            var res = db.Chucvus;
            return res;
        }
        public IEnumerable<Trangthai> ITrangthai = new List<Trangthai>
        {
            new Trangthai
            {
                id = "False",
                flag = "Khóa"
            },
            new Trangthai
            {
                id = "True",
                flag = "Không khóa"
            }
        };
        public bool? changeStatus(string id)
        {
            var taikhoan = db.Taikhoans.Find(id);
            taikhoan.Flag = !taikhoan.Flag;
            db.SaveChanges();
            return !taikhoan.Flag;
        }
    }
}
