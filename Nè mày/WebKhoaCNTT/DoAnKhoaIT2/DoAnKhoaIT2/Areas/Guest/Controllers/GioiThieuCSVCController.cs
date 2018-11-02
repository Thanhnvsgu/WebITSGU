using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DAO;
using Models.ViewModel;
namespace DoAnKhoaIT2.Areas.Guest.Controllers
{
    public class GioiThieuCSVCController : Controller
    {
        // GET: GioiThieuCSVC
        public ActionResult  Gioithieu(string magt,string tengt)
        {            
            var dao = new GioiThieuDAO();
            var res = dao.Noidunggt(magt);
            ViewBag.TenGT = tengt;
            if(res==null)
            {
                return View(new Baidang_ThongTinNguoiDung());
            }
            else
            {
                return View(res);
            }
            
        }

        //public ActionResult GTChung(string magt)
        //{
        //    var dao = new GioiThieuDAO();
        //    var res = dao.Noidunggt(magt);
        //    return View(res);
        //}
        //public ActionResult CCTC_ChiBo(string magt)
        //{
        //    var dao = new GioiThieuDAO();
        //    var res = dao.Noidunggt(magt);
        //    return View(res);
        //}
        //public ActionResult CCTC_BCNK(string magt)
        //{
        //    var dao = new GioiThieuDAO();
        //    var res = dao.Noidunggt(magt);
        //    return View(res);
        //}
        //public ActionResult CCTC_HDKH(string magt)
        //{
        //    var dao = new GioiThieuDAO();
        //    var res = dao.Noidunggt(magt);
        //    return View(res);
        //}
        //public ActionResult CCTC_CongDoan(string magt)
        //{
        //    var dao = new GioiThieuDAO();
        //    var res = dao.Noidunggt(magt);
        //    return View(res);
        //}
        //public ActionResult CCTC_VPK(string magt)
        //{
        //    var dao = new GioiThieuDAO();
        //    var res = dao.Noidunggt(magt);
        //    return View(res);
        //}
        //public ActionResult CCTC_CVCK(string magt)
        //{
        //    var dao = new GioiThieuDAO();
        //    var res = dao.Noidunggt(magt);
        //    return View(res);
        //}
    }
}