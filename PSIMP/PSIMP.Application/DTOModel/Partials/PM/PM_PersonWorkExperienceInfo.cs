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
    /// 工作经历
    /// </summary>
    [Proxy(Read = "~/Person/GetWorks")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_PersonWorkExperienceInfo_MetaData))]
    public partial class PM_PersonWorkExperienceInfo 
    {
        [Model(IDProperty = "ID")]
        public class PM_PersonWorkExperienceInfo_MetaData
        {
            [Column(Hideable = false, Hidden = true)]
            [Field(FieldType = typeof(Hidden))]
            public Guid ID { get; set; }

            [Column(Text = "单位名称",Order = 1)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入单位名称")]
            public string CompanyName { get; set; }

            [Column(Text = "单位性质", Order = 2)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入单位性质")]
            public string Character { get; set; }

            [Column(Text = "行业类别", Order = 3)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入行业类别")]
            public string SectorClass { get; set; }

            [Column(Text = "所在部门", Order = 4)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入所在部门")]
            public string AtProject { get; set; }

            [Column(Text = "职位名称", Order = 5)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入职位名称")]
            public string PositionName { get; set; }

            [NumberColumn(Text = "薪资待遇", Order = 6)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入薪资待遇")]
            public decimal Salary { get; set; }

            [TemplateColumn(Text = "合同状态", Order = 7, TemplateString = "{[values.ContractStatus?'解除':'未解除']}")]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入合同状态")]
            public bool ContractStatus { get; set; }

            [DateColumn(Text = "开始时间", Order = 8)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入开始时间")]
            public System.DateTime WorkStartDate { get; set; }

            [DateColumn(Text = "结束时间", Order = 9)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入结束时间")]
            public System.DateTime WorkEndDate { get; set; }

            [Column(Text = "工作描述", Order = 10)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入工作描述")]
            public string WorkContent { get; set; }

            [Column(Text = "证明人姓名", Order = 11)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入证明人姓名")]
            public string RefereesName { get; set; }

            [Column(Text = "证明人联系方式", Order = 12)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入证明人联系方式")]
            public string RefereesPhoneNumber { get; set; }

            //[Column(Text = "备注", Width = 200, Order = 5)]
            //[Field(HideLabel = true)]
            //public string Descriptions { get; set; }

            [Column(Hideable = false, Hidden = true)]
            public Guid PersonID { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }           
        }
       
    }


    
}