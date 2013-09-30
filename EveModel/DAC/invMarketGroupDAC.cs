using EveModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveModel.DAC
{
    public class invMarketGroupDAC
    {
        public List<MarketGroupMenuModel> GetTopLevelMenuGroups()
        {
            using (EVEEntities entities = new EVEEntities())
            {
                // TODO: There has to be a better way to get only the stuff that is fittable
                var top = from mg in entities.invMarketGroups
                          where mg.parentGroupID == null &&
                                (mg.marketGroupName == "Ships" ||
                                mg.marketGroupName == "Ship Equipment" ||
                                mg.marketGroupName == "Drones" ||
                                mg.marketGroupName == "Ship Modifications" ||
                                mg.marketGroupName == "Ammunition & Charges")
                          select new MarketGroupMenuModel
                          {
                              marketGroupID = mg.marketGroupID,
                              marketGroupName = mg.marketGroupName,
                              description = mg.description,
                              hasTypes = mg.hasTypes
                          };
                return top.OrderBy(x => x.marketGroupName).ToList();
            }
        }

        public List<MarketGroupMenuModel> GetChildMenuGroups(int marketGroupID)
        {
            using (EVEEntities entities = new EVEEntities())
            {
                var children = from mg in entities.invMarketGroups
                               where mg.parentGroupID == marketGroupID
                               select new MarketGroupMenuModel
                               {
                                   marketGroupID = mg.marketGroupID,
                                   marketGroupName = mg.marketGroupName,
                                   description = mg.description,
                                   hasTypes = mg.hasTypes
                               };
                return children.OrderBy(x => x.marketGroupName).ToList();
            }
        }
    }
}
