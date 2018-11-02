using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DAO;
using Models.ViewModel;
using PagedList.Mvc;
namespace DoAnKhoaIT2.Areas.Guest.Controllers
{
    public class TinTuc_SuKienController : Controller
    {
        // GET: TinTuc_SuKien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TT_SK(string maloai,int page=1,int pagesize=3)
        {
            ViewBag.Maloai = maloai;
            var dao = new TT_SK();
            var res = dao.ListAllPaging(maloai,page,pagesize);
            if (res == null)
                return View(new BaidangViewModel());
            return View(res);
        }
        
        public ActionResult Tin1(string mabaidang)
        {
            var model = new TT_SK();
            var res = model.baidang_nd(mabaidang);
            ViewBag.List = model.baidang_file(mabaidang);
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