using EveModel.Common;
using EveModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveModel.DAC
{
    public class invTypesDAC
    {
        public List<TypeMenuModel> GetMenuTypes(int marketGroupID)
        {
            using (EVEEntities entities = new EVEEntities())
            {
                var types = (from t in entities.invTypes
                             where t.marketGroupID == marketGroupID
                             orderby t.typeName
                             select new TypeMenuModel
                             {
                                 typeID = t.typeID,
                                 typeName = t.typeName,
                                 marketGroupID = t.marketGroupID,
                                 description = t.description
                             }).ToList();

                foreach (var item in types)
                    item.description = Utils.ParseTypeDescription(item.description);
                
                return types;
            }
        }
    }
}
