//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EveFirstMate
{
    using System;
    using System.Collections.Generic;
    
    public partial class chrRace
    {
        public chrRace()
        {
            this.invTypes = new HashSet<invType>();
        }
    
        public byte raceID { get; set; }
        public string raceName { get; set; }
        public string description { get; set; }
        public Nullable<int> iconID { get; set; }
        public string shortDescription { get; set; }
    
        public virtual ICollection<invType> invTypes { get; set; }
    }
}
