using EveFirstMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EveFirstMate.Common;

namespace EveFirstMate.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            using (EVEEntities entities = new EVEEntities())
            {
                List<invMarketGroup> marketGroups = entities.invMarketGroups.Where(x => x.invMarketGroup1 == null).ToList();
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
