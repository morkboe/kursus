using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace intro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            string navn = "element nr. 1";

            return Json(navn, JsonRequestBehavior.AllowGet);
        }
    }
}