using System.Web.Mvc;
using System.Web.Routing;

namespace Patient_Tracker.Config
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                   name: "Default",
                   url: "{controller}/{action}/{id}",
                   defaults: new
                   {
                       controller = "Test",
                       action = "Testing",
                       id = UrlParameter.Optional
                   });
        }
    }
}