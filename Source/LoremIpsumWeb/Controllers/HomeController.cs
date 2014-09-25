using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoremIpsumWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
            //return Content("Hallo");
        }

        public ActionResult Format()
        {
            return View();
            //return Content("Hallo");
        }

    }
}
