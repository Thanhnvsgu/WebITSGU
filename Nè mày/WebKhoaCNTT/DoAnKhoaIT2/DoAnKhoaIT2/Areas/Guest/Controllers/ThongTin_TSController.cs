using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DAO;
using Models.ViewModel;
using PagedList;
namespace DoAnKhoaIT2.Areas.Guest.Controllers
{
    public class ThongTin_TSController : Controller
    {
        // GET: ThongTin_TS
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TuyenSinh1(string mabaidang)
        {
            var dao = new TT_TS();
            var res = dao.baidang_nd(mabaidang);
            ViewBag.List = dao.baidang_file(mabaidang);
            if (res == null)
                return View(new BaidangViewModel());
            return View(res);
        }
        public ActionResult TT_TS(string maloai,int page=1,int pagesize=3)
        {
            ViewBag.Maloai = maloai;
            var dao = new TT_TS();
            var res = dao.ListAllPaging(maloai, page, pagesize);
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