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
	using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class EM_ProjectContractDataInfo
    {
        public System.Guid PContractDataID { get; set; }
        public string ContractMoney { get; set; }
        public string ProvisionalSums { get; set; }
        public string ContractNetAmount { get; set; }
        public string ConstructionPeriodMoney { get; set; }
        public string DefectPeriodMoeny { get; set; }
        public string GuaranteePeriodMoney { get; set; }
        public string HonestDepositMoney { get; set; }
        public string GuaranteeMoney { get; set; }
        public string AgainstRiskMoney { get; set; }
        public string ReviewMoeny { get; set; }
        public string ContractID { get; set; }
    
        public virtual EM_ProjectContractBaseInfo EM_ProjectContractBaseInfo { get; set; }
    }
}