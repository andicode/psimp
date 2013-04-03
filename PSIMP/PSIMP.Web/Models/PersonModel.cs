using Ext.Net;
using Ext.Net.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSIMP.Web.Models
{
    [Proxy(Read = "~/Person/GetPersons")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PersonModel_MetaData))]
    public partial class PersonModel
    {        
        [Model(IDProperty = "Id")]
        public class PersonModel_MetaData
        {
            [Column(Hidden = true)]
            [Field(FieldType = typeof(Hidden))]
            public int Id { get; set; }

            [Column(Text = "姓名")]
            [Field(FieldLabel = "姓名")]
            public string Name { get; set; }

            [Column(Text = "性别")]
            [Field(FieldLabel = "性别")]
            public string Sex { get; set; }

            [Column(Text = "身高(CM)")]
            [Field(FieldLabel = "身高(CM)")]
            public int? Height { get; set; }

            [Column(Text = "户籍地")]
            [Field(FieldLabel = "户籍地")]
            public string Census { get; set; }

            [Column(Text = "身份证号")]
            [Field(FieldLabel = "身份证号")]
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

            [TemplateColumn(Text = "照片", Order = 0, TemplateString = "<img src=\"{Picture}\" alt=\"\">")]
            [Field(FieldLabel = "照片")]
            public string Picture { get; set; }
        }
    }
    public partial class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int? Height { get; set; }
        public string Census { get; set; }
        public string IDCard { get; set; }
        public int? Age { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Picture { get; set; }

        public static List<PersonModel> GetAll()
        {
            return new List<PersonModel> 
            { 
                new PersonModel{ Id = 1, Name = "张三", Picture="/Images/Userpicture/default.png"},
                new PersonModel{ Id = 2, Name = "Fred", Picture="/Images/Userpicture/default.png"},
                new PersonModel{ Id = 3, Name = "Andrew", Picture="/Images/Userpicture/default.png"}
            };
        }

    }
}