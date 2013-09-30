﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    internal partial class EVEEntities : DbContext
    {
        public EVEEntities()
            : base("name=EVEEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<agtAgent> agtAgents { get; set; }
        public DbSet<agtAgentType> agtAgentTypes { get; set; }
        public DbSet<agtResearchAgent> agtResearchAgents { get; set; }
        public DbSet<chrAncestry> chrAncestries { get; set; }
        public DbSet<chrAttribute> chrAttributes { get; set; }
        public DbSet<chrBloodline> chrBloodlines { get; set; }
        public DbSet<chrFaction> chrFactions { get; set; }
        public DbSet<chrRace> chrRaces { get; set; }
        public DbSet<crpActivity> crpActivities { get; set; }
        public DbSet<crpNPCCorporationDivision> crpNPCCorporationDivisions { get; set; }
        public DbSet<crpNPCCorporationResearchField> crpNPCCorporationResearchFields { get; set; }
        public DbSet<crpNPCCorporation> crpNPCCorporations { get; set; }
        public DbSet<crpNPCCorporationTrade> crpNPCCorporationTrades { get; set; }
        public DbSet<crpNPCDivision> crpNPCDivisions { get; set; }
        public DbSet<crtCategory> crtCategories { get; set; }
        public DbSet<crtCertificate> crtCertificates { get; set; }
        public DbSet<crtClass> crtClasses { get; set; }
        public DbSet<crtRecommendation> crtRecommendations { get; set; }
        public DbSet<crtRelationship> crtRelationships { get; set; }
        public DbSet<dgmAttributeCategory> dgmAttributeCategories { get; set; }
        public DbSet<dgmAttributeType> dgmAttributeTypes { get; set; }
        public DbSet<dgmEffect> dgmEffects { get; set; }
        public DbSet<dgmTypeAttribute> dgmTypeAttributes { get; set; }
        public DbSet<dgmTypeEffect> dgmTypeEffects { get; set; }
        public DbSet<eveUnit> eveUnits { get; set; }
        public DbSet<invBlueprintType> invBlueprintTypes { get; set; }
        public DbSet<invCategory> invCategories { get; set; }
        public DbSet<invContrabandType> invContrabandTypes { get; set; }
        public DbSet<invControlTowerResourcePurpos> invControlTowerResourcePurposes { get; set; }
        public DbSet<invControlTowerResource> invControlTowerResources { get; set; }
        public DbSet<invFlag> invFlags { get; set; }
        public DbSet<invGroup> invGroups { get; set; }
        public DbSet<invItem> invItems { get; set; }
        public DbSet<invMarketGroup> invMarketGroups { get; set; }
        public DbSet<invMetaGroup> invMetaGroups { get; set; }
        public DbSet<invMetaType> invMetaTypes { get; set; }
        public DbSet<invName> invNames { get; set; }
        public DbSet<invPosition> invPositions { get; set; }
        public DbSet<invTypeMaterial> invTypeMaterials { get; set; }
        public DbSet<invTypeReaction> invTypeReactions { get; set; }
        public DbSet<invType> invTypes { get; set; }
        public DbSet<invUniqueName> invUniqueNames { get; set; }
        public DbSet<mapCelestialStatistic> mapCelestialStatistics { get; set; }
        public DbSet<mapConstellationJump> mapConstellationJumps { get; set; }
        public DbSet<mapConstellation> mapConstellations { get; set; }
        public DbSet<mapDenormalize> mapDenormalizes { get; set; }
        public DbSet<mapJump> mapJumps { get; set; }
        public DbSet<mapLandmark> mapLandmarks { get; set; }
        public DbSet<mapLocationScene> mapLocationScenes { get; set; }
        public DbSet<mapLocationWormholeClass> mapLocationWormholeClasses { get; set; }
        public DbSet<mapRegionJump> mapRegionJumps { get; set; }
        public DbSet<mapRegion> mapRegions { get; set; }
        public DbSet<mapSolarSystemJump> mapSolarSystemJumps { get; set; }
        public DbSet<mapSolarSystem> mapSolarSystems { get; set; }
        public DbSet<mapUniverse> mapUniverses { get; set; }
        public DbSet<planetSchematic> planetSchematics { get; set; }
        public DbSet<planetSchematicsPinMap> planetSchematicsPinMaps { get; set; }
        public DbSet<planetSchematicsTypeMap> planetSchematicsTypeMaps { get; set; }
        public DbSet<ramActivity> ramActivities { get; set; }
        public DbSet<ramAssemblyLine> ramAssemblyLines { get; set; }
        public DbSet<ramAssemblyLineStation> ramAssemblyLineStations { get; set; }
        public DbSet<ramAssemblyLineTypeDetailPerCategory> ramAssemblyLineTypeDetailPerCategories { get; set; }
        public DbSet<ramAssemblyLineTypeDetailPerGroup> ramAssemblyLineTypeDetailPerGroups { get; set; }
        public DbSet<ramAssemblyLineType> ramAssemblyLineTypes { get; set; }
        public DbSet<ramInstallationTypeContent> ramInstallationTypeContents { get; set; }
        public DbSet<ramTypeRequirement> ramTypeRequirements { get; set; }
        public DbSet<staOperation> staOperations { get; set; }
        public DbSet<staOperationService> staOperationServices { get; set; }
        public DbSet<staService> staServices { get; set; }
        public DbSet<staStation> staStations { get; set; }
        public DbSet<staStationType> staStationTypes { get; set; }
        public DbSet<translationTable> translationTables { get; set; }
        public DbSet<trnTranslationColumn> trnTranslationColumns { get; set; }
        public DbSet<trnTranslationLanguage> trnTranslationLanguages { get; set; }
        public DbSet<trnTranslation> trnTranslations { get; set; }
        public DbSet<warCombatZone> warCombatZones { get; set; }
        public DbSet<warCombatZoneSystem> warCombatZoneSystems { get; set; }
    }
}
