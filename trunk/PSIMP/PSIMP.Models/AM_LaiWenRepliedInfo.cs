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
    
    public partial class AM_LaiWenRepliedInfo : BaseEntity
    {
        //主键被写在BaseEntity中,已忽略生成
        //public Guid ID{ get; set; }
        public string RepliedDepartment { get; set; }
        public System.Guid RepliedUserID { get; set; }
        public bool RepliedStatus { get; set; }
        public bool RepliedResult { get; set; }
        public string RepliedSuggestion { get; set; }
        public System.DateTime RepliedDate { get; set; }
        public System.Guid LaiWenRecordID { get; set; }
        public string Description { get; set; }
    
        public virtual AM_LaiWenRecordInfo AM_LaiWenRecordInfo { get; set; }
    }
}
