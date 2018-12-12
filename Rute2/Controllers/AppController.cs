using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rute2.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        [HttpGet]
        [Route("~/")]
        [Route("~/Forside")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("~/salg/{kundeid:int?}")]
        public ActionResult Salg(int? kundeid)
        {
            ViewBag.kundeid = kundeid;
            return View();
        }

    }
}