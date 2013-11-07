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
                // TODO: consider adding inner joins to the invGroups and invCategories
                // this may need to be done to see in what 'category' the item is
                // if it's a ship, it can be 'opened' and allowed to be fitted.
                // if it's a module, it can be fitted to the current ship
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

        public string GetShip(int typeID)
        {
            using (EVEEntities entities = new EVEEntities())
            {
                // note on resistances:
                // the formula for getting the resistance % is as follows:
                // 100 - (100 * resonance)

                // welp, this is a LOT of attributes and honestly I have no idea how to pieces this together
                // I could make them a list of attributes attached to the main type object, but that has its issues
                // if I'm just looking for the high slots or something for the current ship,
                // it'll be frustrating to have to first search the attributes list
                
                // this query will get all the 'attributes' of the ship
                // along with other misc stuff like the unit of display (e.g. HP, GJ, m3, %)
                // oops, need an outer join here on the eveUnits table to get rows when
                // the dgmAttributeTypes unitID is null
                // still need those with no units, but they can be left null

                // ok, turns out I don't really need to select from/join to the invTypes table,
                // I can just use this query to get the attributes and their associated units
                // based on the typeID

                // I'm still looking at 77 attributes for an Abaddon, which I'm using as my test case
                // I'm sure there'll be more/less for other ships or items,
                // but this is a lot of information about the ship that I'll need to figure out how to arrange
                // I'm adding in a published = true condition on this as well.
                // The only things that are not 'published' but seem like they might be important are:
                // requiredSkill1Level (id: 277)
                // heatCapacityHi/Med/Low (ids: 1178, 1199, 1200)
                // heatDissipationRateHi/Med/Low (ids: 1179, 1196, 1198)
                // warpCapacitorNeed (id: 153)
                // removing the 'unpublished' attributes brings this down to 51 attributes for an Abaddon
                var shipAttributes = 
                    from dta in entities.dgmTypeAttributes
                    join dat in entities.dgmAttributeTypes on dta.attributeID equals dat.attributeID
                    join u in entities.eveUnits on dat.unitID equals u.unitID into eudta
                    from e in eudta.DefaultIfEmpty()
                    where dta.typeID == typeID && dat.published == true
                    select new
                    {
                        dta1 = dta.valueFloat,
                        dta2 = dta.valueInt,
                        dat1 = dat.attributeID,
                        dat2 = dat.attributeName,
                        dat3 = dat.description,
                        dat4 = dat.displayName,
                        u1 = e.description,
                        u2 = e.displayName,
                        u3 = e.unitName
                    };

            }

            throw new NotImplementedException();
        }
    }
}
