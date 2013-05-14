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
    
    public partial class AM_ProjectApplicationBaseInfo : BaseEntity
    {
        public string ApplicationSerialNumber { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string ApplicationProjectID { get; set; }
        public string ApplicationPersonID { get; set; }
        public string ApplicationReason { get; set; }
        public string ApplicationContent { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<AM_ApplicationContent_CapitalFundCategory> AM_ApplicationContent_CapitalFundCategory { get; set; }
        public virtual ICollection<AM_ApplicationContent_VehicleCategory> AM_ApplicationContent_VehicleCategory { get; set; }
    }
}
