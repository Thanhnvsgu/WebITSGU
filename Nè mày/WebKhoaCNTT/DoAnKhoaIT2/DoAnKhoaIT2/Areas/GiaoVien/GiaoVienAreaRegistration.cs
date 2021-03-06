﻿using System.Web.Mvc;

namespace DoAnKhoaIT2.Areas.GiaoVien
{
    public class GiaoVienAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "GiaoVien";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "GiaoVien_default",
                "GiaoVien/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}