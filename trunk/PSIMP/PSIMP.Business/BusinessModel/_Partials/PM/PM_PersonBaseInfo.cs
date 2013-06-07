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
    /// 基础信息
    /// </summary>
    [Proxy(Read = "~/persons/default/getpersons")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_PersonBaseInfo_MetaData))]
    public partial class PM_PersonBaseInfo 
    {
        [Column(Ignore=true)]
        [Field(Ignore=true)]
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public long _dc { get { return DateTime.Now.Ticks; } }

        public class PM_PersonBaseInfo_MetaData
        {

            [Column(Ignore = true)]
            public Guid ID { get; set; }

            [Column(Text = "姓名",Order = 1)]
            [Field(FieldLabel = "姓名",  AllowBlank = false, BlankText = "请输入人员姓名")]
            public string PersonName { get; set; }

            [TemplateColumn(Text = "性别", Order = 2, TemplateString = "{[values.Sex?'男':'女']}")]
            [Field(FieldLabel = "性别", FieldType = typeof(SexComboBox), AllowBlank = false, BlankText = "请选择人员性别")]
            public bool Sex { get; set; }           

            [Column(Text = "户籍地")]
            [Field(FieldLabel = "户籍地")]
            public string RegisterAddress { get; set; }

            [Column(Text = "身份证号", Order = 3)]
            [Field(FieldLabel = "身份证号",AllowBlank=false,BlankText="请输入身份证号码",Regex=@"[1-6]\d{5}(?:19|20)\d{2}(?:0\d|1[12])(?:0\d|[12]\d|3[01])\d{3}[\dXx]",RegexText="请输入正确的18位身份证号码")]
            public string IDNumber { get; set; }

            [DateColumn(Text = "出生年月",Format="yyyy年M月d日", Order = 4)]
            [Field(FieldLabel = "出生年月", AllowBlank = false, BlankText = "请输入出生日期")]
            public DateTime Birthday { get; set; }

            [Column(Text = "联系电话", Order = 7)]
            [Field(FieldLabel = "联系电话", AllowBlank = false, BlankText = "请输入联系电话")]
            public string ContactPhoneNumber { get; set; }

            [Column(Text = "备用电话", Order = 7)]
            [Field(FieldLabel = "备用电话")]
            public string AlternatePhoneNumber { get; set; }

            [TemplateColumn(Text = "照片", Order = 0, Align = Alignment.Center, TemplateString = "<img style=\"width:38px;height:50px\" src=\"/Persons/Default/Photo/{ID}?_dc={_dc}\" alt=\"{PersonName}\">")]
            [Field(FieldLabel = "照片",FieldType=typeof(FileUploadField))]
            [JsonIgnore]
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
       
    }


    
}