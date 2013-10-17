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
    
    public partial class mapRegion
    {
        public mapRegion()
        {
            this.mapConstellationJumps = new HashSet<mapConstellationJump>();
            this.mapConstellationJumps1 = new HashSet<mapConstellationJump>();
            this.mapConstellations = new HashSet<mapConstellation>();
            this.mapDenormalizes = new HashSet<mapDenormalize>();
            this.mapSolarSystemJumps = new HashSet<mapSolarSystemJump>();
            this.mapSolarSystemJumps1 = new HashSet<mapSolarSystemJump>();
            this.mapSolarSystems = new HashSet<mapSolarSystem>();
            this.ramAssemblyLineStations = new HashSet<ramAssemblyLineStation>();
            this.staStations = new HashSet<staStation>();
            this.mapRegions1 = new HashSet<mapRegion>();
            this.mapRegions = new HashSet<mapRegion>();
        }
    
        public int regionID { get; set; }
        public string regionName { get; set; }
        public Nullable<double> x { get; set; }
        public Nullable<double> y { get; set; }
        public Nullable<double> z { get; set; }
        public Nullable<double> xMin { get; set; }
        public Nullable<double> xMax { get; set; }
        public Nullable<double> yMin { get; set; }
        public Nullable<double> yMax { get; set; }
        public Nullable<double> zMin { get; set; }
        public Nullable<double> zMax { get; set; }
        public Nullable<int> factionID { get; set; }
        public Nullable<double> radius { get; set; }
    
        public virtual chrFaction chrFaction { get; set; }
        public virtual ICollection<mapConstellationJump> mapConstellationJumps { get; set; }
        public virtual ICollection<mapConstellationJump> mapConstellationJumps1 { get; set; }
        public virtual ICollection<mapConstellation> mapConstellations { get; set; }
        public virtual ICollection<mapDenormalize> mapDenormalizes { get; set; }
        public virtual ICollection<mapSolarSystemJump> mapSolarSystemJumps { get; set; }
        public virtual ICollection<mapSolarSystemJump> mapSolarSystemJumps1 { get; set; }
        public virtual ICollection<mapSolarSystem> mapSolarSystems { get; set; }
        public virtual ICollection<ramAssemblyLineStation> ramAssemblyLineStations { get; set; }
        public virtual ICollection<staStation> staStations { get; set; }
        public virtual ICollection<mapRegion> mapRegions1 { get; set; }
        public virtual ICollection<mapRegion> mapRegions { get; set; }
    }
}
