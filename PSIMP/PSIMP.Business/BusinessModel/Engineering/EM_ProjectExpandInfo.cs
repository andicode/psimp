//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace PSIMP.Models
{
    using System;
    using System.Collections.Generic;
    using PSIMP.Business.BaseModel;
    
    public partial class EM_ProjectExpandInfo : BaseEntity
    {
        public decimal ContractMoney { get; set; }
        public float Mileage { get; set; }
        public string RoadGrade { get; set; }
        public string TerrainCondition { get; set; }
        public int RoadbedWidth { get; set; }
        public decimal Excavation { get; set; }
        public string EarthStoneFill { get; set; }
        public string SoftFoundation { get; set; }
        public string BasicLevel { get; set; }
        public string RoadStructureTypeAndMileage { get; set; }
        public string BituminousConcretePavement { get; set; }
        public string CementConcretePavement { get; set; }
        public string BridgeStructureLengthLargestSpan { get; set; }
        public int GrandBridgeNum { get; set; }
        public int GreatBridgeNum { get; set; }
        public int MediumBridgeNum { get; set; }
        public int CulvertNum { get; set; }
        public int InterchangeNum { get; set; }
        public int InterchangeMainBridge { get; set; }
        public int TamperBridgeNum { get; set; }
        public string TamperBridgeMileage { get; set; }
        public string SuperLongTunnelNum { get; set; }
        public string LongTunnelNum { get; set; }
        public string MiddleTunnelNum { get; set; }
        public string ShortTunnelNum { get; set; }
        public string SideSlopeAfforestation { get; set; }
        public string MechanicalElectricalAndContent { get; set; }
        public string SupervisionTask { get; set; }
        public System.DateTime FinishedDate { get; set; }
        public string SupervisorWorkload { get; set; }
        public string QualityGrade { get; set; }
        public string HousingConstruction { get; set; }
        public System.Guid GeneralSupervision { get; set; }
        public string ConstructionCompanyName { get; set; }
        public string ConstructionCompanyLinkman { get; set; }
        public string ConstructionCompanyPhoneNum { get; set; }
        public string RewardAndPunishment { get; set; }
        public string Description { get; set; }
    
        public virtual EM_ProjectBaseInfo EM_ProjectBaseInfo { get; set; }
    }
}
