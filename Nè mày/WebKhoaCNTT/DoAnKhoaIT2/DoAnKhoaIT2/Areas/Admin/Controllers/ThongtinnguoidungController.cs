using DoAnKhoaIT2.Common;
using DoAnKhoaIT2.Controllers;
using Models.DAO.Admin;
using Models.EF;
using Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnKhoaIT2.Areas.Admin.Controllers
{
    public class ThongtinnguoidungController : BaseController
    {
        // GET: Admin/Thongtinnguoidung
        public ActionResult Index()
        {
            var dao = new ThongtinnguoidungDao();
            ThongtinnguoidungModel res = new ThongtinnguoidungModel();
            res.listtaikhoan = dao.Listtaikhoan();
            res.listchucvu = dao.Listchucvu();
            res.listquyen = dao.Listquyen();
            ViewBag.Ichucvu = dao.Ichucvu();
            ViewBag.Itrangthai = dao.ITrangthai;
            ViewBag.show = "false";
            ViewBag.check = "false";
            return View(res);
        }

        // POST: Admin/Thongtinnguoidung/Create
        [HttpPost]
        public ActionResult Themtaikhoan(ThongtinnguoidungModel collection)
        {
            var dao = new ThongtinnguoidungDao();
            ThongtinnguoidungModel res = new ThongtinnguoidungModel();
            res.listtaikhoan = dao.Listtaikhoan();
            res.listchucvu = dao.Listchucvu();
            res.listquyen = dao.Listquyen();
            var check = dao.Themtaikhoan(collection.taikhoan);
            ViewBag.Ichucvu = dao.Ichucvu();
            ViewBag.Itrangthai = dao.ITrangthai;

            if (check == true)
                {
                    dao.Themthongtin(collection.taikhoan.Tentaikhoan, collection.thongtinnguoidung);
                    return RedirectToAction("Index");
                }
                ViewBag.show = "true";
                ViewBag.check = "true";
                ModelState.AddModelError("","Tài khoản đã tồn tại");
                return View("~/Areas/Admin/Views/Thongtinnguoidung/Index.cshtml",res);
        }

        // POST: Admin/Thongtinnguoidung/Edit/5
        [HttpPost]
        public ActionResult Suataikhoan(string id, ThongtinnguoidungModel collection)
        {
            ThongtinnguoidungModel res = new ThongtinnguoidungModel();
            ThongtinnguoidungDao dao = new ThongtinnguoidungDao();
            res.listtaikhoan = dao.Listtaikhoan();
            res.listchucvu = dao.Listchucvu();
            res.listquyen = dao.Listquyen();
            var kt = dao.timtaikhoan(collection.taikhoan.Tentaikhoan);
            if (kt.Matkhau == collection.taikhoan.Matkhau)
                collection.taikhoan.Matkhau = kt.Matkhau;
            else
                collection.taikhoan.Matkhau = Encryptor.Encrypt(collection.taikhoan.Tentaikhoan, collection.taikhoan.Matkhau);
            var check = dao.Suataikhoan(collection.taikhoan);
            dao.suathongtin(collection.taikhoan.Tentaikhoan, collection.thongtinnguoidung);
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View("~/Areas/Admin/Views/Thongtinnguoidung/Index.cshtml", res);
        }
        [HttpPost]
        public JsonResult ChangeStatus(string id)
        {
            var res = new ThongtinnguoidungDao().changeStatus(id);
            return Json(new
            {
                status = res
            });
        }
        [HttpPost]
        public JsonResult LoadSuataikhoan(string id)
        {
            var res = new ThongtinnguoidungDao().timtaikhoan(id);
            var res2 = new ThongtinnguoidungDao().timthongtin(id);
            string tt = res2.Namsinh.Value.ToShortDateString().ToString();
            return Json(new
            {
                Jtentaikhoan = res.Tentaikhoan,
                Jmachucvu = res.Machucvu,
                Jmatkhau = res.Matkhau,
                Jmail = res.Mail,
                Jhoten = res2.Hoten,
                Jngaysinh = tt,
                Jsdt = res2.Sodienthoai,
                Jquequan = res2.Quequan
            });
        }
    }
}
