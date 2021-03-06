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
    
    public partial class mapDenormalize
    {
        public int itemID { get; set; }
        public Nullable<int> typeID { get; set; }
        public Nullable<int> groupID { get; set; }
        public Nullable<int> solarSystemID { get; set; }
        public Nullable<int> constellationID { get; set; }
        public Nullable<int> regionID { get; set; }
        public Nullable<int> orbitID { get; set; }
        public Nullable<double> x { get; set; }
        public Nullable<double> y { get; set; }
        public Nullable<double> z { get; set; }
        public Nullable<double> radius { get; set; }
        public string itemName { get; set; }
        public Nullable<double> security { get; set; }
        public Nullable<byte> celestialIndex { get; set; }
        public Nullable<byte> orbitIndex { get; set; }
    
        public virtual invGroup invGroup { get; set; }
        public virtual invType invType { get; set; }
        public virtual mapConstellation mapConstellation { get; set; }
        public virtual mapRegion mapRegion { get; set; }
        public virtual mapSolarSystem mapSolarSystem { get; set; }
    }
}
