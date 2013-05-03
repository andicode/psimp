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
    
    public partial class AM_LaiWenRecordInfo
    {
        public AM_LaiWenRecordInfo()
        {
            this.AM_LaiWenCircularizeDetail = new HashSet<AM_LaiWenCircularizeDetail>();
            this.AM_LaiWenRepliedInfo = new HashSet<AM_LaiWenRepliedInfo>();
        }
    
        public System.Guid ID { get; set; }
        public string LaiWenUnit { get; set; }
        public string LaiWenType { get; set; }
        public string LaiWenMode { get; set; }
        public string FileSubject { get; set; }
        public string LaiWenSerialNumber { get; set; }
        public System.DateTime IncomeFileDate { get; set; }
        public int IncomeFileNum { get; set; }
        public byte FileAttachment { get; set; }
        public System.Guid ProjectID { get; set; }
    
        public virtual ICollection<AM_LaiWenCircularizeDetail> AM_LaiWenCircularizeDetail { get; set; }
        public virtual ICollection<AM_LaiWenRepliedInfo> AM_LaiWenRepliedInfo { get; set; }
    }
}
