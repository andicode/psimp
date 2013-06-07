using Ext.Net;
using Ext.Net.MVC;
using Newtonsoft.Json;
using PSIMP.Models.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSIMP.Models
{
    /// <summary>
    /// 教育背景
    /// </summary>
    [Proxy(Read = "~/Persons/Default/GetEdus")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_PersonEducationalBackground_MetaData))]
    public partial class PM_PersonEducationalBackground 
    {
        [Model(IDProperty = "ID")]
        public class PM_PersonEducationalBackground_MetaData
        {
            [Column(Hideable = false, Hidden = true)]
            [Field(FieldType = typeof(Hidden))]
            public Guid ID { get; set; }

            [Column(Text = "学校名称",Order = 1)]
            [Field(FieldLabel = "学校名称", AllowBlank = false, BlankText = "请输入学校名称")]
            public string SchoolName { get; set; }

            [DateColumn(Text = "入学时间", Order = 2)]
            [Field(FieldLabel = "入学时间", AllowBlank = false, BlankText = "请选择人员性别")]
            public DateTime EduStartDate { get; set; }

            [DateColumn(Text = "毕业时间", Order = 3)]
            [Field(FieldLabel = "毕业时间")]
            public DateTime EduEndDate { get; set; }

            [Column(Text = "专业名称", Order = 4)]
            [Field(FieldLabel = "专业名称")]
            public string SpecialtyName { get; set; }

            [Column(Text = "学历/学位",Order = 5)]
            [Field(FieldLabel = "学历/学位")]
            public string Degree { get; set; }

            [Column(Text = "备注", Order = 6)]
            [Field(FieldLabel = "备注")]
            public string Description { get; set; }

            //[Column(Hideable=false,Hidden=true)]
            //public Guid PersonID { get; set; }

            [Column(Ignore = true)]
            [Field(Ignore = true)]
            [JsonIgnore]
            public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
           
        }
       
    }


    
}