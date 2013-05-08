using Ext.Net;
using Ext.Net.MVC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PSIMP.Application.DTOModel
{
    /// <summary>
    /// 保险信息
    /// </summary>
    [Proxy(Read = "~/Person/GetInsurances")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_PersonInsuranceInfo_MetaData))]
    public partial class PM_PersonInsuranceInfo
    {
        [Model(IDProperty = "ID")]
        public class PM_PersonInsuranceInfo_MetaData
        {
            [Column(Hideable = false, Hidden = true)]
            [Field(FieldType = typeof(Hidden))]
            public Guid ID { get; set; }

            [Column(Hideable = false, Hidden = true)]
            [Field(FieldLabel = "姓名")]
            public System.Guid PersonID { get; set; }

            [Column(Ignore=true)]
            [Field(FieldLabel = "保险人员")]
            public string PersonDisplayName { get; set; }

            [Column(Text = "姓名", Order = 1)]
            [Field(FieldLabel = "姓名")]
            public string PersonName { get; set; }

            [Column(Text = "性别", Order = 2)]
            [Field(FieldLabel = "性别")]
            public string Sex { get; set; }

            [Column(Text = "身份证号", Order = 3)]
            [Field(FieldLabel = "身份证号")]
            public string IDNumber { get; set; }

            [Column(Text = "保单号", Order = 4)]
            [Field(FieldLabel = "保单号")]
            public string InsuranceNumber { get; set; }

            [Column(Text = "保单类别", Order = 5)]
            [Field(FieldLabel = "保单类别")]
            public string InsuranceType { get; set; }

            [DateColumn(Text = "起保日期", Order = 6)]
            [Field(FieldLabel = "起保日期")]
            public System.DateTime EffectiveDate { get; set; }

            [DateColumn(Text = "止保日期", Order = 7)]
            [Field(FieldLabel = "止保日期")]
            public System.DateTime ExpiryDate { get; set; }

            [TemplateColumn(Text = "在职状态", Order = 8, TemplateString = "{[values.PositionStatus?'在职':'离职']}")]
            [Field(FieldLabel = "在职状态")]
            public bool PositionStatus { get; set; }

            [Column(Text = "投保份数", Order = 9)]
            [Field(FieldLabel = "投保份数")]
            public string InsuredNumber { get; set; }

            [Column(Text = "保单信息", Order = 10)]
            [Field(FieldLabel = "保单信息")]
            public string InsuranceContent { get; set; }


            [Column(Text = "所在项目", Order = 11)]
            [Field(FieldLabel = "所在项目")]
            public System.Guid ProjectID { get; set; }

            [Column(Text = "目前岗位", Order = 12)]
            [Field(FieldLabel = "目前岗位")]
            public string PositionName { get; set; }

            [Column(Text = "保险状态", Order = 13)]
            [Field(FieldLabel = "保险状态")]
            public int InsuranceStatus { get; set; }

            [Column(Text = "备注", Order = 14)]
            [Field(FieldLabel = "备注")]
            public string Description { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
        }
        public string PersonDisplayName
        {
            get { return this.PersonName + "," + this.Sex + "," + this.IDNumber; }
            set { }
        }
        public string PersonName
        {
            get { return this.PM_PersonBaseInfo.PersonName; }
        }
        public string Sex
        {
            get
            {
                return this.PM_PersonBaseInfo.Sex ? "男" : "女";
            }
        }
        public string IDNumber
        {
            get
            {
                return this.PM_PersonBaseInfo.IDNumber;
            }
        }
    }
}
