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
            [Field(FieldLabel = "性别",FieldType=typeof(ComboBox),AllowBlank=false,BlankText="请选择人员性别")]
            public bool Sex { get; set; }

            [Column(Text = "户籍地")]
            [Field(FieldLabel = "户籍地",AllowBlank=false,BlankText="请输入人员户籍")]
            public string RegisterAddress { get; set; }

            [Column(Text = "身份证号", Order = 3)]
            [Field(FieldLabel = "身份证号",AllowBlank=false,BlankText="请输入身份证号码",Regex=@"[1-6]\d{5}(?:19|20)\d{2}(?:0\d|1[12])(?:0\d|[12]\d|3[01])\d{3}[\dXx]",RegexText="请输入正确的18位身份证号码")]
            public string IDNumber { get; set; }

            [DateColumn(Text = "出生年月",Format="yyyy年MM月dd日", Order = 4)]
            [Field(FieldLabel = "出生年月")]
            public DateTime Birthday { get; set; }

            [Column(Text = "联系电话", Order = 7)]
            [Field(FieldLabel = "联系电话")]
            public string ContactNumber { get; set; }

            [Column(Text = "联系电话", Order = 7)]
            [Field(FieldLabel = "联系电话")]
            public string AlternateNumber { get; set; }

            [TemplateColumn(Text = "照片", Order = 0, Align=Alignment.Center, TemplateString = "<img style=\"width:38px;height:50px\" src=\"/images/Person/{Picture}\" alt=\"{Name}\">")]
            [Field(FieldLabel = "照片")]
            public string TwoInchPhoto { get; set; }
            
        }
    }
}