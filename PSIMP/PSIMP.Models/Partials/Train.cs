using Ext.Net.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    [Proxy(Read = "~/Person/GetTrains")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(Train_MetaData))] 
    public partial class Train
    {
        [Model(IDProperty = "Id")]
        public class Train_MetaData : Psimp_MetaData
        {
            [Column(Text = "培训机构")]
            public string Agency { get; set; }
            [DateColumn(Text = "受训时间")]
            public DateTime? DateTime { get; set; }
            [Column(Text = "培训地点")]
            public string Location { get; set; }
            [Column(Text = "受训课程")]
            public string Curriculum { get; set; }
            [Column(Text = "获得证书")]
            public string Certificate { get; set; }
            [Column(Text = "详细描述")]
            public string Details { get; set; }
            [Column(Text = "证书扫描")]
            public string CertDetails { get; set; }

            [Column(Hidden = true)]
            public long PersonId { get; set; }

            [Column(Ignore = true)]
            [Newtonsoft.Json.JsonIgnore]
            public virtual Person Person { get; set; }
        }
    }
}
