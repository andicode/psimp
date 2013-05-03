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
    
    public partial class EM_ProjectContractPerformance : BaseEntity
    {
        //主键被写在BaseEntity中,已忽略生成
        //public Guid ID{ get; set; }
        public System.Guid ProjectID { get; set; }
        public System.Guid PersonID { get; set; }
        public string PersonName { get; set; }
        public System.Guid OnProjectID { get; set; }
        public System.DateTime InPresentDate { get; set; }
        public System.Guid PerformanceProjectID { get; set; }
        public string PerformanceDuties { get; set; }
        public System.DateTime OutDate { get; set; }
        public string Description { get; set; }
    
        public virtual EM_ProjectBaseInfo EM_ProjectBaseInfo { get; set; }
    }
}