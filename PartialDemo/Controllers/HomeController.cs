using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [ChildActionOnly]
        // GET: Home
        public ActionResult Liste()
        {
            return PartialView();
        }

        [HttpGet]
        [ChildActionOnly]
        // GET: Home
        public ActionResult Liste2(int antal=10)
        {
            // Lokal fejlhåndtering
            try
            {
                List<string> lst = new List<string>();
                for (int i = 0; i < antal; i++)
                    lst.Add(Guid.NewGuid().ToString());

                return PartialView(lst);
            }
            catch (Exception ex)
            {
                // Evt. log fejl ...

                return RedirectToAction("Fejl");
            }
        }

        [HttpGet]
        public ActionResult Fejl()
        {
            return View();

        }

    }
}