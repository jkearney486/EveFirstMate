using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EveModel;
using EveFirstMate.Common;
using EveModel.DAC;

namespace EveFirstMate.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            //invTypesDAC dac = new invTypesDAC();
            //dac.GetShip(24692);
            return View();
        }
    }
}
