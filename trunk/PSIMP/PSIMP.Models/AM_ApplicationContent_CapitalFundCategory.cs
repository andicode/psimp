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
    
    public partial class AM_ApplicationContent_CapitalFundCategory
    {
        public System.Guid ApplicationCapitalCategoryID { get; set; }
        public string ProjectApplicationID { get; set; }
        public string ApplicationType { get; set; }
        public string CapitalFundName { get; set; }
        public string SpecificationMode { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }
        public string Money { get; set; }
        public string TotalMoney { get; set; }
        public string Description { get; set; }
    
        public virtual AM_ProjectApplicationBaseInfo AM_ProjectApplicationBaseInfo { get; set; }
    }
}