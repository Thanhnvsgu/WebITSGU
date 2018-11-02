using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.EF;
namespace DoAnKhoaIT2.Areas.Guest.Controllers
{
    public class LayoutController : Controller
    {
        SGU db = new SGU();
        // GET: Layout
        public PartialViewResult GioiThieu_1()
        {

            ViewBag.GT1 = db.Gioithieux.Where(s=>s.Flag==true).Take(2).ToList();          
            return PartialView("_GioiThieu1");
        }
        public PartialViewResult GioiThieu_2()
        {

            ViewBag.GT2 = db.Gioithieux.Where(s => s.MaGT !="GT1" && s.MaGT!="GT2").ToList();            
            return PartialView("_GioiThieu2");
        }
        public PartialViewResult BoMon()
        {

            ViewBag.BM = db.Bomons.ToList();               
            return PartialView("_BoMon");
        }
        public PartialViewResult DaoTao()
        {
            ViewBag.DT = db.LoaiDaotaos.ToList();         
            return PartialView("_DaoTao");
        }
        public PartialViewResult CongTacSV()
        {

            ViewBag.CTSV = db.CongtacSVs.ToList();          
            return PartialView("_CTSV");
        }
    }
}