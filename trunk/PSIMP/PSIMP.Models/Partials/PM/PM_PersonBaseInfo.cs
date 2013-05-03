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
    [Proxy(Read = "~/Person/GetPersons")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_PersonBaseInfo_MetaData))]
    public partial class PM_PersonBaseInfo
    {
      


        [Model(IDProperty = "PersonID")]
        public class PM_PersonBaseInfo_MetaData
        {
            [Column(Ignore = true)]
            [Field(FieldType = typeof(Hidden))]
            public Guid PersonID { get; set; }

            [Column(Text = "姓名",Order = 1)]
            [Field(FieldLabel = "姓名",  AllowBlank = false, BlankText = "请输入人员姓名")]
            public string PersonName { get; set; }

            [TemplateColumn(Text = "性别", Order = 2, TemplateString = "{[values.Sex?'男':'女']}")]
            [Field(Ignore=true)]
            public bool Sex { get; set; }
            [Column(Ignore = true)]

            [Field(FieldLabel = "性别", FieldType = typeof(SexComboBox), AllowBlank = false, BlankText = "请选择人员性别")]
            public Enums.Sex SexBox { get; set; }

            [Column(Text = "户籍地")]
            [Field(FieldLabel = "户籍地")]
            public string RegisterAddress { get; set; }

            [Column(Text = "身份证号", Order = 3)]
            [Field(FieldLabel = "身份证号",AllowBlank=false,BlankText="请输入身份证号码",Regex=@"[1-6]\d{5}(?:19|20)\d{2}(?:0\d|1[12])(?:0\d|[12]\d|3[01])\d{3}[\dXx]",RegexText="请输入正确的18位身份证号码")]
            public string IDNumber { get; set; }

            [DateColumn(Text = "出生年月",Format="yyyy年MM月dd日", Order = 4)]
            [Field(FieldLabel = "出生年月", AllowBlank = false, BlankText = "请输入出生年月")]
            public DateTime Birthday { get; set; }

            [Column(Text = "联系电话", Order = 7)]
            [Field(FieldLabel = "联系电话", AllowBlank = false, BlankText = "请输入联系电话")]
            public string ContactPhoneNumber { get; set; }

            [Column(Text = "联系电话", Order = 7)]
            [Field(FieldLabel = "联系电话")]
            public string AlternatePhoneNumber { get; set; }

            [TemplateColumn(Text = "照片", Order = 0, Align = Alignment.Center, TemplateString = "<img style=\"width:38px;height:50px\" src=\"/Person/Photo/{PersonID}\" alt=\"{Name}\">")]
            [Field(FieldLabel = "照片",FieldType=typeof(FileUploadField))]
            public byte[] TwoInchPhoto { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual ICollection<PM_CertificateManage> PM_CertificateManage { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual ICollection<PM_PersonRegister> PM_PersonRegister { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual ICollection<PM_PersonCertificateInfo> PM_PersonCertificateInfo { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual ICollection<PM_PersonInsuranceInfo> PM_PersonInsuranceInfo { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual ICollection<PM_PersonTrainingExperience> PM_PersonTrainingExperience { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual ICollection<PM_PersonPositionalTitlesInfo> PM_PersonPositionalTitlesInfo { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual ICollection<PM_PersonEducationalBackground> PM_PersonEducationalBackground { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual ICollection<PM_PersonWorkExperienceInfo> PM_PersonWorkExperienceInfo { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual ICollection<PM_PersonWorkExperienceInfo> PM_PersonContractInfo { get; set; }
        }
        private Enums.Sex _sexBox = Enums.Sex.男;
        public Enums.Sex SexBox
        {
            get { return _sexBox; }
            set
            {
                _sexBox = value;
                this.Sex = _sexBox == Enums.Sex.男;
            }
        }
    }


    
}