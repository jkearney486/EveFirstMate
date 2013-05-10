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
    
    public partial class invType
    {
        public invType()
        {
            this.chrBloodlines = new HashSet<chrBloodline>();
            this.crtRecommendations = new HashSet<crtRecommendation>();
            this.dgmTypeAttributes = new HashSet<dgmTypeAttribute>();
            this.dgmTypeEffects = new HashSet<dgmTypeEffect>();
            this.invBlueprintTypes = new HashSet<invBlueprintType>();
            this.invBlueprintTypes1 = new HashSet<invBlueprintType>();
            this.invContrabandTypes = new HashSet<invContrabandType>();
            this.invControlTowerResources = new HashSet<invControlTowerResource>();
            this.invControlTowerResources1 = new HashSet<invControlTowerResource>();
            this.invMetaTypes = new HashSet<invMetaType>();
            this.invTypeMaterials = new HashSet<invTypeMaterial>();
            this.invTypeMaterials1 = new HashSet<invTypeMaterial>();
            this.invTypeReactions = new HashSet<invTypeReaction>();
            this.mapDenormalizes = new HashSet<mapDenormalize>();
            this.mapSolarSystems = new HashSet<mapSolarSystem>();
            this.ramTypeRequirements = new HashSet<ramTypeRequirement>();
            this.staOperations = new HashSet<staOperation>();
            this.staOperations1 = new HashSet<staOperation>();
            this.staOperations2 = new HashSet<staOperation>();
            this.staOperations3 = new HashSet<staOperation>();
            this.staOperations4 = new HashSet<staOperation>();
            this.agtAgents = new HashSet<agtAgent>();
            this.crpNPCCorporations = new HashSet<crpNPCCorporation>();
            this.crpNPCCorporations1 = new HashSet<crpNPCCorporation>();
        }
    
        public int typeID { get; set; }
        public Nullable<int> groupID { get; set; }
        public string typeName { get; set; }
        public string description { get; set; }
        public Nullable<double> mass { get; set; }
        public Nullable<double> volume { get; set; }
        public Nullable<double> capacity { get; set; }
        public Nullable<int> portionSize { get; set; }
        public Nullable<byte> raceID { get; set; }
        public Nullable<decimal> basePrice { get; set; }
        public Nullable<bool> published { get; set; }
        public Nullable<int> marketGroupID { get; set; }
        public Nullable<double> chanceOfDuplicating { get; set; }
    
        public virtual ICollection<chrBloodline> chrBloodlines { get; set; }
        public virtual chrRace chrRace { get; set; }
        public virtual ICollection<crtRecommendation> crtRecommendations { get; set; }
        public virtual ICollection<dgmTypeAttribute> dgmTypeAttributes { get; set; }
        public virtual ICollection<dgmTypeEffect> dgmTypeEffects { get; set; }
        public virtual invBlueprintType invBlueprintType { get; set; }
        public virtual ICollection<invBlueprintType> invBlueprintTypes { get; set; }
        public virtual ICollection<invBlueprintType> invBlueprintTypes1 { get; set; }
        public virtual ICollection<invContrabandType> invContrabandTypes { get; set; }
        public virtual ICollection<invControlTowerResource> invControlTowerResources { get; set; }
        public virtual ICollection<invControlTowerResource> invControlTowerResources1 { get; set; }
        public virtual invGroup invGroup { get; set; }
        public virtual invMarketGroup invMarketGroup { get; set; }
        public virtual ICollection<invMetaType> invMetaTypes { get; set; }
        public virtual invMetaType invMetaType { get; set; }
        public virtual ICollection<invTypeMaterial> invTypeMaterials { get; set; }
        public virtual ICollection<invTypeMaterial> invTypeMaterials1 { get; set; }
        public virtual ICollection<invTypeReaction> invTypeReactions { get; set; }
        public virtual ICollection<mapDenormalize> mapDenormalizes { get; set; }
        public virtual ICollection<mapSolarSystem> mapSolarSystems { get; set; }
        public virtual ICollection<ramTypeRequirement> ramTypeRequirements { get; set; }
        public virtual ICollection<staOperation> staOperations { get; set; }
        public virtual ICollection<staOperation> staOperations1 { get; set; }
        public virtual ICollection<staOperation> staOperations2 { get; set; }
        public virtual ICollection<staOperation> staOperations3 { get; set; }
        public virtual ICollection<staOperation> staOperations4 { get; set; }
        public virtual staStationType staStationType { get; set; }
        public virtual ICollection<agtAgent> agtAgents { get; set; }
        public virtual ICollection<crpNPCCorporation> crpNPCCorporations { get; set; }
        public virtual ICollection<crpNPCCorporation> crpNPCCorporations1 { get; set; }
    }
}
