using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace LoremIpsumWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}.asmx",
                defaults: new {  }
            );
        }
    }
}
