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
    
    public partial class invCategory
    {
        public invCategory()
        {
            this.invGroups = new HashSet<invGroup>();
            this.ramAssemblyLineTypeDetailPerCategories = new HashSet<ramAssemblyLineTypeDetailPerCategory>();
        }
    
        public int categoryID { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }
        public Nullable<int> iconID { get; set; }
        public Nullable<bool> published { get; set; }
    
        public virtual ICollection<invGroup> invGroups { get; set; }
        public virtual ICollection<ramAssemblyLineTypeDetailPerCategory> ramAssemblyLineTypeDetailPerCategories { get; set; }
    }
}