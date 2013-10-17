using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveModel.Models
{
    public class MarketGroupMenuModel
    {
        public int marketGroupID { get; set; }
        public string marketGroupName { get; set; }
        public string description { get; set; }
        public Nullable<bool> hasTypes { get; set; }
    }
}
