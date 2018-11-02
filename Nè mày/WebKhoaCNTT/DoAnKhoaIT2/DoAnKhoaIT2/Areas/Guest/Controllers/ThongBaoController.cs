using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DAO;
using Models.EF;
using PagedList;
using System.IO;
namespace DoAnKhoaIT2.Areas.Guest.Controllers
{
    public class ThongBaoController : Controller
    {
        SGU db = new SGU();
        // GET: ThongBao
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TB(string txtSearch,int page=1,int pagesize=3)
        {
            var dao = new ThongBaoDAO();
            var res = dao.ListAllPaging(txtSearch, page, pagesize);
            if (res == null)
                return View(new Baidang());
            return View(res);

        }
        public ActionResult ThongBao1(string mabaidang)
        {
            var dao = new ThongBaoDAO();
            ViewBag.List = dao.baidang_file(mabaidang);
            var res = dao.baidang_nd(mabaidang);
            return View(res);
        }
        public FileResult Dowload(string filepath)
        {         
            string contentType = string.Empty;
            if(filepath.Contains(".docx"))
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