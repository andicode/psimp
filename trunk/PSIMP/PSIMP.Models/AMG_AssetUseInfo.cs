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
    
    public partial class AMG_AssetUseInfo
    {
        public System.Guid ID { get; set; }
        public System.Guid AssetBaseInfoID { get; set; }
        public string AssetUseCompany { get; set; }
        public int Number { get; set; }
        public decimal UseDate { get; set; }
        public string UsePerson { get; set; }
        public string UseReason { get; set; }
        public string Description { get; set; }
        public string Other { get; set; }
    
        public virtual AMG_AssetBaseInfo AMG_AssetBaseInfo { get; set; }
    }
}
