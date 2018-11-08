using System.Web.Mvc;

namespace DoAnKhoaIT2.Areas.GiaoVjen
{
    public class GiaoVjenAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "GiaoVjen";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "GiaoVjen_default",
                "GiaoVjen/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}