using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DAO;
using Models.EF;
namespace DoAnKhoaIT2.Areas.Guest.Controllers
{
    public class BoMonController : Controller
    {
        // GET: BoMon
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BoMon(string mabm,string tenbm)
        {
            var dao = new BoMonDAO();
            var res = dao.Noidung(mabm);
            ViewBag.GV = dao.ListGV(mabm);
            ViewBag.MH = dao.ListMonHoc(mabm);
            ViewBag.TenBM = tenbm;
            if (res == null)
                return View(new Bomon());
            return View(res);
        }
        //public ActionResult KTPM(string mabm)
        //{
        //    //var dao = new BoMonDAO();
        //    //var res = dao.Noidung(mabm);
        //    //ViewBag.GV = dao.ListGV(mabm);
        //    return View();
        //}
        //public ActionResult KHMT(string mabm)
        //{
        //    //var dao = new BoMonDAO();
        //    //var res = dao.Noidung(mabm);
        //    //ViewBag.GV = dao.ListGV(mabm);
        //    return View();
        //}
        //public ActionResult MMT(string mabm)
        //{
        //    //var dao = new BoMonDAO();
        //    //var res = dao.Noidung(mabm);
        //    //ViewBag.GV = dao.ListGV(mabm);
        //    return View();
        //}
    }
}