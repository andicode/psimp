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
    
    public partial class VM_VehicleYearInspection
    {
        public System.Guid ID { get; set; }
        public System.Guid VehicleID { get; set; }
        public System.DateTime InspectionDate { get; set; }
        public bool InspectionResult { get; set; }
        public int InspectionTimes { get; set; }
        public string Other1 { get; set; }
        public string Other2 { get; set; }
        public string Description { get; set; }
    
        public virtual VM_VehicleBaseInfo VM_VehicleBaseInfo { get; set; }
    }
}
