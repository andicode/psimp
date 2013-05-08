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
    
    public partial class VM_VehicleUseInfo : BaseEntity
    {
        public System.Guid VehicleID { get; set; }
        public string UseAddress { get; set; }
        public string VehicleUseType { get; set; }
        public string VehicleDriver { get; set; }
        public System.DateTime VehicleStartDate { get; set; }
        public System.DateTime VehicleEndDate { get; set; }
        public string UsePurpose { get; set; }
        public string Description { get; set; }
        public string Other { get; set; }
    
        public virtual VM_VehicleBaseInfo VM_VehicleBaseInfo { get; set; }
    }
}