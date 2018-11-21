using System.Web.Mvc;

namespace Git.Storage.Web.Areas.WMS
{
    public class WMSAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "WMS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "WMS_default",
                "WMS/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
