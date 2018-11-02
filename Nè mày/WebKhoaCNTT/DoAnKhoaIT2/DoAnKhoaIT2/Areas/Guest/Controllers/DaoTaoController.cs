using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DAO;
using Models.EF;
namespace DoAnKhoaIT2.Areas.Guest.Controllers
{
    public class DaoTaoController : Controller
    {
        // GET: DaoTao
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TrinhDo(string maloaidt,string tendt,int page=1,int pagesize=3)
        {
            ViewBag.maloaidt = maloaidt;
            ViewBag.TenDT = tendt;
            var dao = new DaoTaoDAO();
            var res = dao.Noidungdaotao(page,pagesize,maloaidt);
            if (res == null)
                return View(new NoidungDT());
            return View(res);
        }
        //public ActionResult TrinhDoThacSi(string maloaidt, string txtSearch, int page = 1, int pagesize = 3)
        //{
        //    ViewBag.maloaidt = maloaidt;
        //    var dao = new DaoTaoDAO();
        //    var res = dao.Noidungdaotao(txtSearch, page, pagesize, maloaidt);
        //    return View(res);
        //}
        public ActionResult Thongtintrinhdo(string manddt,string madt,string tendt)
        {
            ViewBag.TenDT = tendt;
            ViewBag.MaDT = madt;
            var dao = new DaoTaoDAO();
            var res = dao.daotao_nd(manddt);
            return View(res);
        }

    }
}