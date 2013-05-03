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
    
    public partial class PM_PersonInsuranceInfo
    {
        public System.Guid ID { get; set; }
        public System.Guid PersonID { get; set; }
        public string Sex { get; set; }
        public string IDNumber { get; set; }
        public string InsuranceNumber { get; set; }
        public string InsuranceType { get; set; }
        public System.DateTime EffectiveDate { get; set; }
        public System.DateTime ExpiryDate { get; set; }
        public bool PositionStatus { get; set; }
        public string InsuredNumber { get; set; }
        public string InsuranceContent { get; set; }
        public System.Guid ProjectID { get; set; }
        public string PositionName { get; set; }
        public int InsuranceStatus { get; set; }
        public string Description { get; set; }
    
        public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
    }
}
