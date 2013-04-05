using Ext.Net;
using Ext.Net.MVC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSIMP.Models
{
    [Proxy(Read = "~/Person/GetPersons")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PersonModel_MetaData))]
    public partial class Person
    {        
        [Model(IDProperty = "Id")]
        public class PersonModel_MetaData
        {
            [Column(Hidden = true)]
            [Field(FieldType = typeof(Hidden))]
            public long Id { get; set; }

            [Column(Text = "姓名")]
            [Field(FieldLabel = "姓名",AllowBlank=false,BlankText="请输入人员姓名")]
            public string Name { get; set; }

            [Column(Text = "性别")]
            [Field(FieldLabel = "性别",AllowBlank=false,BlankText="请选择人员性别")]
            public string Sex { get; set; }

            [Column(Text = "身高(CM)")]
            [Field(FieldLabel = "身高(CM)")]
            public int? Height { get; set; }

            [Column(Text = "户籍地")]
            [Field(FieldLabel = "户籍地",AllowBlank=false,BlankText="请输入人员户籍")]
            public string Census { get; set; }

            [Column(Text = "身份证号")]
            [Field(FieldLabel = "身份证号",AllowBlank=false,BlankText="请输入身份证号码",Regex=@"[1-6]\d{5}(?:19|20)\d{2}(?:0\d|1[12])(?:0\d|[12]\d|3[01])\d{3}[\dXx]",RegexText="请输入正确的18位身份证号码")]
            public string IDCard { get; set; }

            [Column(Text = "年龄")]
            [Field(FieldLabel = "年龄")]
            public int? Age { get; set; }

            [Column(Text = "联系号码")]
            [Field(FieldLabel = "联系号码")]
            public string Telephone { get; set; }

            [Column(Text = "电子邮件")]
            [Field(FieldLabel = "电子邮件" ,StandardVtype=ValidationType.Email)]
            public string Email { get; set; }

            [TemplateColumn(Text = "照片", Order = 0, TemplateString = "<img style=\"width:85px;height:120px\" src=\"/person/picture/{Id}\" alt=\"{Name}\">")]
            [Field(FieldLabel = "照片")]
            [JsonIgnore]
            public byte[] Picture { get; set; }
        }
    }
}