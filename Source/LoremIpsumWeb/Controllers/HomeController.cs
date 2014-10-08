using System;
using System.Collections.Generic;
using System.IO;
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
            StreamReader reader = new StreamReader(Server.MapPath("~/LoremIpsum.txt"));
            ViewBag.LoremIpsumFullText = reader.ReadToEnd();
            return View();
            //return Content("Hallo");
        }

        public ActionResult Canvas()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Formular()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formular(string name, string email, string nachricht)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.Nachricht = nachricht;
            return View("Formularauswertung");
        }

        public ActionResult Ajax()
        {
            return View();
        }

    }
}
