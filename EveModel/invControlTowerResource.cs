//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EveModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class invControlTowerResource
    {
        public int controlTowerTypeID { get; set; }
        public int resourceTypeID { get; set; }
        public Nullable<byte> purpose { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<double> minSecurityLevel { get; set; }
        public Nullable<int> factionID { get; set; }
    
        public virtual chrFaction chrFaction { get; set; }
        public virtual invType invType { get; set; }
        public virtual invType invType1 { get; set; }
    }
}
