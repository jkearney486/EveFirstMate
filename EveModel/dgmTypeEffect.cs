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
    
    public partial class dgmTypeEffect
    {
        public int typeID { get; set; }
        public short effectID { get; set; }
        public Nullable<bool> isDefault { get; set; }
    
        public virtual dgmEffect dgmEffect { get; set; }
        public virtual invType invType { get; set; }
    }
}
