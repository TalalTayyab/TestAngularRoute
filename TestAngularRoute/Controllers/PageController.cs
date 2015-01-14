using System;
using System.Web.Mvc;


namespace TestAngularRoute.Controllers
{
    public class PageController : Controller
    {
        public ActionResult Page_1()
        {
            return View();
        }

        public ActionResult Page_1_2()
        {
            return View();
        }

        public ActionResult Main()
        {
            return View();
        }
    }
}