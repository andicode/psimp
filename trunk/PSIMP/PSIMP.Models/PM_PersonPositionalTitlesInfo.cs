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
    
    public partial class PM_PersonPositionalTitlesInfo
    {
        public string PositionalID { get; set; }
        public string PositionalName { get; set; }
        public string PositionalType { get; set; }
        public System.DateTime AssessmentDate { get; set; }
        public string AssessmentBody { get; set; }
        public string Descriptions { get; set; }
        public long PersonID { get; set; }
    
        public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
    }
}
