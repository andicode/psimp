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
    /// <summary>
    /// 车辆调配信息
    /// </summary>
    public partial class VM_VehicleAllocateInfo : BaseEntity
    {
        public string LeaveFromCompany { get; set; }
        public string LeaveToCompany { get; set; }
        public DateTime AllocateDate { get; set; }
        public string AllocateReason { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string OperationUserID { get; set; }
        public string Description { get; set; }
        public string Other1 { get; set; }
        public string Other2 { get; set; }
    
        public virtual VM_VehicleBaseInfo VM_VehicleBaseInfo { get; set; }
    }
}
