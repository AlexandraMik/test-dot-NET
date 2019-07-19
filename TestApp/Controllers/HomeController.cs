using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        ActorContext actorContext = new ActorContext();

        public ActionResult Index()
        {
            IEnumerable<Actor> actors = actorContext.Actors; //Gat data from table Actors

            ViewBag.Actors = actors; //Write actors in dynamic property

            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;

            return View();
        }
        [HttpPost]
        public string Buy(Buying buying)
        {
            buying.DateTime = DateTime.Now;

            actorContext.Buyings.Add(buying);

            actorContext.SaveChanges();

            return $"Thanks for buying, {buying.FIO}";
        }
    }
}