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
    
    public partial class dgmAttributeCategory
    {
        public dgmAttributeCategory()
        {
            this.dgmAttributeTypes = new HashSet<dgmAttributeType>();
        }
    
        public byte categoryID { get; set; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
    
        public virtual ICollection<dgmAttributeType> dgmAttributeTypes { get; set; }
    }
}
