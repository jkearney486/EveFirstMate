using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EveModel.Models
{
    public class TypeMenuModel
    {
        public int typeID { get; set; }
        public string typeName { get; set; }
        public string description { get; set; }
        public Nullable<int> marketGroupID { get; set; }
    }
}
