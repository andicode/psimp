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
    
    public partial class AMG_AssetAllocateInfo : BaseEntity
    {

        public System.Guid AssetBaseInfoID { get; set; }
        public string LeaveFromCompany { get; set; }
        public string LeaveToCompany { get; set; }
        public System.DateTime AllocateDate { get; set; }
        public string AllocateReason { get; set; }
        public System.Guid OperationUserID { get; set; }
        public string Description { get; set; }
        public int Other1 { get; set; }
        public int Other2 { get; set; }
    
        public virtual AMG_AssetBaseInfo AMG_AssetBaseInfo { get; set; }
    }
}
