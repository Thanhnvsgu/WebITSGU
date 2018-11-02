using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DAO;
using Models.EF;
namespace DoAnKhoaIT2.Areas.Guest.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CTSV(string mact, string tenctsv, int page=1,int pagesize=1)
        {
            ViewBag.TenCTSV = tenctsv;
            ViewBag.MaCTSV = mact;
            var dao = new CongTacSVDAO();
            var res = dao.ListALL(mact, page, pagesize);
            if (res == null)
                return View(new NDCongtacSV());
            return View(res);
        }
        public ActionResult ThongTinCTSV(string mandct,string tenctsv,string mact)
        {
            ViewBag.TenCTSV = tenctsv;
            ViewBag.MaCTSV = mact;
            var dao = new CongTacSVDAO();
            var res = dao.ThongTinCTSV(mandct);
            ViewBag.File = dao.NoidungCTSV_file(mandct);
            return View(res);
        }
        public FileResult Dowload(string filepath)
        {
            string contentType = string.Empty;
            if (filepath.Contains(".docx"))
            {
                contentType = "application/docx";
            }
            else if (filepath.Contains(".pdf"))
            {
                contentType = "application/pdf";
            }
            else if (filepath.Contains(".xlsx"))
            {
                contentType = "application/xlsx";
            }
            return File(filepath, contentType, filepath);
        }
    }
}