//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EveFirstMate.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class chrBloodline
    {
        public byte bloodlineID { get; set; }
        public string bloodlineName { get; set; }
        public Nullable<byte> raceID { get; set; }
        public string description { get; set; }
        public string maleDescription { get; set; }
        public string femaleDescription { get; set; }
        public Nullable<int> shipTypeID { get; set; }
        public Nullable<int> corporationID { get; set; }
        public Nullable<byte> perception { get; set; }
        public Nullable<byte> willpower { get; set; }
        public Nullable<byte> charisma { get; set; }
        public Nullable<byte> memory { get; set; }
        public Nullable<byte> intelligence { get; set; }
        public Nullable<int> iconID { get; set; }
        public string shortDescription { get; set; }
        public string shortMaleDescription { get; set; }
        public string shortFemaleDescription { get; set; }
    
        public virtual crpNPCCorporation crpNPCCorporation { get; set; }
        public virtual invType invType { get; set; }
    }
}