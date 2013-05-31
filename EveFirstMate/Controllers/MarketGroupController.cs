using EveFirstMate.Common;
using EveFirstMate.Models;
using EveFirstMate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EveFirstMate.Controllers
{
    public class MarketGroupController : BaseController
    {
        public JsonResult GetTopGroups()
        {
            List<invMarketGroup> marketGroups = Entities.invMarketGroups.Where(x => x.invMarketGroup1 == null && (x.marketGroupName == "Ships" || x.marketGroupName == "Ship Equipment" || x.marketGroupName == "Ship Modifications")).ToList();
            List<MarketGroupViewModel> groups = new List<MarketGroupViewModel>();

            foreach (var item in marketGroups)
            {
                groups.Add(new MarketGroupViewModel(item));
            }

            return Json(groups, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetChildGroups(int marketGroupID)
        {
            List<invMarketGroup> marketGroups = Entities.invMarketGroups.Where(x => x.parentGroupID == marketGroupID).ToList();
            List<MarketGroupViewModel> childGroups = new List<MarketGroupViewModel>();

            foreach (var item in marketGroups)
            {
                childGroups.Add(new MarketGroupViewModel(item));
            }

            return Json(childGroups, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTypes(int marketGroupID)
        {
            List<invType> types = Entities.invTypes.Where(x => x.marketGroupID == marketGroupID).ToList();
            List<TypeViewModel> vm = new List<TypeViewModel>();

            foreach (var item in types)
            {
                vm.Add(new TypeViewModel(item));
            }

            return Json(vm, JsonRequestBehavior.AllowGet);
        }
    }
}
