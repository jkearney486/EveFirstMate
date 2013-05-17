using EveFirstMate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EveFirstMate.Common;
using EveFirstMate.ViewModels;

namespace EveFirstMate.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            EveViewModel viewModel = new EveViewModel();
            viewModel.marketGroups = Entities.invMarketGroups.Where(x => x.invMarketGroup1 == null && (x.marketGroupName == "Ships" || x.marketGroupName == "Ship Equipment" || x.marketGroupName == "Ship Modifications")).ToList();
            
            return View(viewModel);
        }
    }
}
