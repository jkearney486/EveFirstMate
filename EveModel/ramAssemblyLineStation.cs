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
    
    public partial class ramAssemblyLineStation
    {
        public int stationID { get; set; }
        public byte assemblyLineTypeID { get; set; }
        public Nullable<byte> quantity { get; set; }
        public Nullable<int> stationTypeID { get; set; }
        public Nullable<int> ownerID { get; set; }
        public Nullable<int> solarSystemID { get; set; }
        public Nullable<int> regionID { get; set; }
    
        public virtual crpNPCCorporation crpNPCCorporation { get; set; }
        public virtual mapRegion mapRegion { get; set; }
        public virtual mapSolarSystem mapSolarSystem { get; set; }
        public virtual ramAssemblyLineType ramAssemblyLineType { get; set; }
        public virtual staStation staStation { get; set; }
        public virtual staStationType staStationType { get; set; }
    }
}
