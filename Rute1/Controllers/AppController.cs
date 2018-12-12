using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rute1.Controllers
{
    public class AppController : Controller
    {
        [HttpGet]
        // GET: App
        public ActionResult Index()
        {
            return View();
        }
        // GET: App
        public ActionResult Salg()
        {
            return View();
        }

        public ActionResult Fejl(string q)
        {
            return View();
        }

    }
}