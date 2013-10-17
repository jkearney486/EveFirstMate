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
    
    public partial class ramAssemblyLineType
    {
        public ramAssemblyLineType()
        {
            this.ramAssemblyLines = new HashSet<ramAssemblyLine>();
            this.ramAssemblyLineStations = new HashSet<ramAssemblyLineStation>();
            this.ramAssemblyLineTypeDetailPerCategories = new HashSet<ramAssemblyLineTypeDetailPerCategory>();
            this.ramAssemblyLineTypeDetailPerGroups = new HashSet<ramAssemblyLineTypeDetailPerGroup>();
        }
    
        public byte assemblyLineTypeID { get; set; }
        public string assemblyLineTypeName { get; set; }
        public string description { get; set; }
        public Nullable<double> baseTimeMultiplier { get; set; }
        public Nullable<double> baseMaterialMultiplier { get; set; }
        public Nullable<double> volume { get; set; }
        public Nullable<byte> activityID { get; set; }
        public Nullable<double> minCostPerHour { get; set; }
    
        public virtual ramActivity ramActivity { get; set; }
        public virtual ICollection<ramAssemblyLine> ramAssemblyLines { get; set; }
        public virtual ICollection<ramAssemblyLineStation> ramAssemblyLineStations { get; set; }
        public virtual ICollection<ramAssemblyLineTypeDetailPerCategory> ramAssemblyLineTypeDetailPerCategories { get; set; }
        public virtual ICollection<ramAssemblyLineTypeDetailPerGroup> ramAssemblyLineTypeDetailPerGroups { get; set; }
    }
}
