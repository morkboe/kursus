using FilterDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilterDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            ViewBag.nu = DateTime.Now.ToLongTimeString();
            return View();
        }

        [HttpGet]
        public ActionResult RetPerson()
        {
            Person p;
            string sti = Server.MapPath("~/app_data/person.json");
            if (System.IO.File.Exists(sti))
            {
                string indhold = System.IO.File.ReadAllText(sti);
                p = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(indhold);
            }
            else
            {
                p = new Person();
                p.Id = 1;
            }
            return View(p);
        }
        
        [HttpPost]
        public ActionResult RetPerson(Person p)
        {
            if (ModelState.IsValid)
            {
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(p);
                string sti = Server.MapPath("~/app_data/person.json");
                System.IO.File.WriteAllText(sti, json);
            }
            return View();
        }
    }
}