using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnKhoaIT2.Areas.GiaoVjen.Controllers
{
    public class HomeController : Controller
    {
        // GET: GiaoVjen/Home
        public ActionResult IndexGV()
        {
            return View();
        }
    }
}