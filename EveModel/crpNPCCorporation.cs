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
    
    public partial class crpNPCCorporation
    {
        public crpNPCCorporation()
        {
            this.agtAgents = new HashSet<agtAgent>();
            this.chrBloodlines = new HashSet<chrBloodline>();
            this.chrFactions = new HashSet<chrFaction>();
            this.chrFactions1 = new HashSet<chrFaction>();
            this.crpNPCCorporationDivisions = new HashSet<crpNPCCorporationDivision>();
            this.crpNPCCorporations1 = new HashSet<crpNPCCorporation>();
            this.crpNPCCorporations11 = new HashSet<crpNPCCorporation>();
            this.crpNPCCorporations12 = new HashSet<crpNPCCorporation>();
            this.crpNPCCorporations13 = new HashSet<crpNPCCorporation>();
            this.crpNPCCorporations14 = new HashSet<crpNPCCorporation>();
            this.crpNPCCorporations15 = new HashSet<crpNPCCorporation>();
            this.crtCertificates = new HashSet<crtCertificate>();
            this.ramAssemblyLines = new HashSet<ramAssemblyLine>();
            this.ramAssemblyLineStations = new HashSet<ramAssemblyLineStation>();
            this.staStations = new HashSet<staStation>();
            this.invTypes = new HashSet<invType>();
            this.invTypes1 = new HashSet<invType>();
        }
    
        public int corporationID { get; set; }
        public string size { get; set; }
        public string extent { get; set; }
        public Nullable<int> solarSystemID { get; set; }
        public Nullable<int> investorID1 { get; set; }
        public Nullable<byte> investorShares1 { get; set; }
        public Nullable<int> investorID2 { get; set; }
        public Nullable<byte> investorShares2 { get; set; }
        public Nullable<int> investorID3 { get; set; }
        public Nullable<byte> investorShares3 { get; set; }
        public Nullable<int> investorID4 { get; set; }
        public Nullable<byte> investorShares4 { get; set; }
        public Nullable<int> friendID { get; set; }
        public Nullable<int> enemyID { get; set; }
        public Nullable<long> publicShares { get; set; }
        public Nullable<int> initialPrice { get; set; }
        public Nullable<double> minSecurity { get; set; }
        public Nullable<bool> scattered { get; set; }
        public Nullable<byte> fringe { get; set; }
        public Nullable<byte> corridor { get; set; }
        public Nullable<byte> hub { get; set; }
        public Nullable<byte> border { get; set; }
        public Nullable<int> factionID { get; set; }
        public Nullable<double> sizeFactor { get; set; }
        public Nullable<short> stationCount { get; set; }
        public Nullable<short> stationSystemCount { get; set; }
        public string description { get; set; }
        public Nullable<int> iconID { get; set; }
    
        public virtual ICollection<agtAgent> agtAgents { get; set; }
        public virtual ICollection<chrBloodline> chrBloodlines { get; set; }
        public virtual ICollection<chrFaction> chrFactions { get; set; }
        public virtual ICollection<chrFaction> chrFactions1 { get; set; }
        public virtual ICollection<crpNPCCorporationDivision> crpNPCCorporationDivisions { get; set; }
        public virtual ICollection<crpNPCCorporation> crpNPCCorporations1 { get; set; }
        public virtual crpNPCCorporation crpNPCCorporation1 { get; set; }
        public virtual ICollection<crpNPCCorporation> crpNPCCorporations11 { get; set; }
        public virtual crpNPCCorporation crpNPCCorporation2 { get; set; }
        public virtual ICollection<crpNPCCorporation> crpNPCCorporations12 { get; set; }
        public virtual crpNPCCorporation crpNPCCorporation3 { get; set; }
        public virtual ICollection<crpNPCCorporation> crpNPCCorporations13 { get; set; }
        public virtual crpNPCCorporation crpNPCCorporation4 { get; set; }
        public virtual ICollection<crpNPCCorporation> crpNPCCorporations14 { get; set; }
        public virtual crpNPCCorporation crpNPCCorporation5 { get; set; }
        public virtual ICollection<crpNPCCorporation> crpNPCCorporations15 { get; set; }
        public virtual crpNPCCorporation crpNPCCorporation6 { get; set; }
        public virtual mapSolarSystem mapSolarSystem { get; set; }
        public virtual ICollection<crtCertificate> crtCertificates { get; set; }
        public virtual ICollection<ramAssemblyLine> ramAssemblyLines { get; set; }
        public virtual ICollection<ramAssemblyLineStation> ramAssemblyLineStations { get; set; }
        public virtual ICollection<staStation> staStations { get; set; }
        public virtual ICollection<invType> invTypes { get; set; }
        public virtual ICollection<invType> invTypes1 { get; set; }
    }
}