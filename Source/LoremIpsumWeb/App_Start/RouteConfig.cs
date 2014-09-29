using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LoremIpsumWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                    "Default",
                    "{action}.aspx/{id}",
                    new { controller = "Home", action = "Index", id = "" }
              );

            routes.MapRoute(
                    "ControllerAndAction",
                    "{controller}/{action}.aspx/{id}",
                    new { action = "Index", id = "" }
              );
        }
    }
}