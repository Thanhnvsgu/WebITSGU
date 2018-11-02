using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DAO;
using Models.ViewModel;
namespace DoAnKhoaIT2.Areas.Guest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home


        public ActionResult Index()
        {
            var dao = new HomeDAO();
            View3Baidang view = new View3Baidang();
            ViewBag.List = dao.ListAll();
            view.v1 = dao.List_baidang("SK");
            view.v2 = dao.List_baidang("TD");
            view.v3 = dao.List_baidang("TS");
            view.v4 = dao.ListAll();
            return View(view);
        }

        public ActionResult Introduction()
        {

            return View();

        }


    }
}