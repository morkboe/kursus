using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewTest.Models;

namespace ViewTest.Controllers
{
    public class AppController : Controller
    {
        [HttpGet]
        [Route("~/")]
        [Route("~/App")]
        public ActionResult Index()
        {
            List<String> tmp = new List<string>();
            for (int i = 0; i < 10; i++)
                tmp.Add(Guid.NewGuid().ToString());

            return View(tmp);
        }

        [HttpGet]
        [Route("~/Test")]
        public ActionResult Test()
        {
            Person p = new Person() { Navn = "aa", Alder = 10, ErILive = true };
            return View(p);
        }

    }
}