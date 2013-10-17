using EveFirstMate.Common;
using EveModel;
using EveModel.DAC;
using EveModel.Models;
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
            invMarketGroupDAC dac = new invMarketGroupDAC();
            List<MarketGroupMenuModel> marketGroups = dac.GetTopLevelMenuGroups();
            
            return Json(marketGroups, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetChildGroups(int id)
        {
            invMarketGroupDAC dac = new invMarketGroupDAC();
            List<MarketGroupMenuModel> marketGroups = dac.GetChildMenuGroups(id);

            return Json(marketGroups, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTypes(int id)
        {
            invTypesDAC dac = new invTypesDAC();
            List<TypeMenuModel> types = dac.GetMenuTypes(id);

            return Json(types, JsonRequestBehavior.AllowGet);
        }
    }
}
