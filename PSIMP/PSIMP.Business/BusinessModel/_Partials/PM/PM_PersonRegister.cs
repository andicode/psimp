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
    /// 注册信息
    /// </summary>
    [Proxy(Read = "~/Person/GetRegisters")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_PersonRegister_MetaData))]
    public partial class PM_PersonRegister 
    {
        public class PM_PersonRegister_MetaData
        {
            [Column(Ignore = true)]
            [Field(FieldType = typeof(Hidden))]
            public Guid ID { get; set; }

            //[Column(Ignore = true)]
            //[Field(FieldLabel="注册人员")]
            //public System.Guid PersonID { get; set; }

            //[Column(Text = "注册人员姓名", Order = 1)]
            //[Field(Ignore=true)]
            //public string PersonName { get; set; }


            [DateColumn(Text = "登记日期", Order = 2, Format = "yyyy年M月d日")]
            [Field(FieldLabel="登记日期",FieldType=typeof(DateField))]
            public System.DateTime RegisterDate { get; set; }

            [Column(Text = "注册单位", Order = 3)]
            [Field(FieldLabel="注册单位")]
            public string RegisterCompany { get; set; }
            [Column(Text = "旧库注册情况", Order = 4)]
            [Field(FieldLabel = "旧库注册情况")]
            public string OldDBDesc { get; set; }
            [Column(Text = "新库注册情况", Order = 5)]
            [Field(FieldLabel = "新库注册情况")]
            public string NewDBDesc { get; set; }

            [Column(Text = "注册状态", Order = 6)]
            [Field(FieldLabel = "注册状态")]
            public int RegisterStatus { get; set; }

            [TemplateColumn(Text = "是否有身份证", Order = 7, TemplateString = "{[values.IsHaveIdentificationCard?'<span style=\'color:#0f0\'>有</span>':'<span style=\'color:#f00\'>无</span>']}")]
            [Field(FieldLabel = "")]
            public bool IsHaveIdentificationCard { get; set; }

            [TemplateColumn(Text = "是否有毕业证", Order = 8, TemplateString = "{[values.IsHaveGraduationCertificate?'<span style=\'color:#0f0\'>有</span>':'<span style=\'color:#f00\'>无</span>']}")]
            [Field(FieldLabel = "")]
            public bool IsHaveGraduationCertificate { get; set; }

            [TemplateColumn(Text = "是否有职称证", Order = 9, TemplateString = "{[values.IsHavePositionalCertificate?'<span style=\'color:#0f0\'>有</span>':'<span style=\'color:#f00\'>无</span>']}")]
            [Field(FieldLabel = "")]
            public bool IsHavePositionalCertificate { get; set; }

            [TemplateColumn(Text = "是否有监理证", Order = 10, TemplateString = "{[values.IshaveSupervisionCertificate?'<span style=\'color:#0f0\'>有</span>':'<span style=\'color:#f00\'>无</span>']}")]
            [Field(FieldLabel = "")]
            public bool IshaveSupervisionCertificate { get; set; }

            [TemplateColumn(Text = "是否有安全培训证", Order = 11, TemplateString = "{[values.IsHaveSecurityCertificate?'<span style=\'color:#0f0\'>有</span>':'<span style=\'color:#f00\'>无</span>']}")]
            [Field(FieldLabel = "")]
            public bool IsHaveSecurityCertificate { get; set; }

            [TemplateColumn(Text = "是否有环保培训证", Order = 12, TemplateString = "{[values.IsHaveConservationCertificate?'<span style=\'color:#0f0\'>有</span>':'<span style=\'color:#f00\'>无</span>']}")]
            [Field(FieldLabel = "")]
            public bool IsHaveConservationCertificate { get; set; }

            [TemplateColumn(Text = "是否有2寸白底照片", Order = 13, TemplateString = "{[values.IshaveTwoInchPhoto?'<span style=\'color:#0f0\'>有</span>':'<span style=\'color:#f00\'>无</span>']}")]
            [Field(FieldLabel = "")]
            public bool IshaveTwoInchPhoto { get; set; }

            [Column(Text = "不能注册原因", Order = 14)]
            [Field(FieldLabel = "不能注册原因", FieldType = typeof(TextArea))]
            public string NoCanRegisterCause { get; set; }

            [Column(Text = "备注", Order = 15)]
            [Field(FieldLabel = "备注",FieldType=typeof(TextArea))]
            public string Description { get; set; }


            [Column(Ignore=true)]
            [Field(Ignore=true)]
            public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
        }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string PersonName
        {
            get
            {
                return this.PM_PersonBaseInfo.PersonName;
            }
        }
    }


    
}