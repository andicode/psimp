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
    
    public partial class PM_PersonEducationalBackground : BaseEntity
    {
        //主键被写在BaseEntity中,已忽略生成
        //public Guid ID{ get; set; }
        public string SchoolName { get; set; }
        public System.DateTime EduStartDate { get; set; }
        public System.DateTime EduEndDate { get; set; }
        public string SpecialtyName { get; set; }
        public string Degree { get; set; }
        public string Descriptions { get; set; }
        public System.Guid PersonID { get; set; }
    
        public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
    }
}
