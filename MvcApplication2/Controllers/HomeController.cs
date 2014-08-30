using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message="Feautured News";
            return View();
        }

        public ActionResult Kooperatiba()
        {
            return View();
        }

        public ActionResult Fertilizer()
        {
            return View();
        }

        public ActionResult Presyo()
        {
            return View();
        }

        public ActionResult LocatorMap()
        {
            return View();
        }

        public ActionResult ExtraRice()
        {
            return View();
        }
    }
}
