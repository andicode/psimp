using Ext.Net.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    [Proxy(Read = "~/Person/GetEducations",
        Create="~/Person/CreateEdu",
        Update="~/Person/UpdateEdu",
        Destroy="~/Person/DeleteEdu")]
    [JsonReader(Root = "data")]
    [JsonWriter(AllowSingle=true)]
    [MetadataType(typeof(Education_MetaData))]
    public partial class Education
    {
        [Model(IDProperty = "Id")]
        public class Education_MetaData:Psimp_MetaData
        {
            [Column(Hidden=true)]
            public long PersonId { get; set; }
            [Column(Text = "学校名称")]
            [Field(AllowBlank=false)]
            public string SchoolName { get; set; }
            [DateColumn(Text = "入学时间",Format="yyyy-MM-dd")]
            public DateTime? BeginDate { get; set; }
            [DateColumn(Text = "毕业时间", Format = "yyyy-MM-dd")]
            public DateTime? EndDate { get; set; }
            [Column(Text = "专业")]
            public string Discipline { get; set; }
            [Column(Text = "学位")]
            public string Degree { get; set; }
            [Column(Text = "备注")]
            public string Remark { get; set; }
            
            [Column(Ignore = true)]
            [Newtonsoft.Json.JsonIgnore]
            public virtual Person Person { get; set; }
        }
    }
}
