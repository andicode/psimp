using Ext.Net.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    [Proxy(Read = "~/Person/GetCertificates")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(EM_ProjectBaseInfo_MetaData))]
    public partial class EM_ProjectBaseInfo
    {
        public class EM_ProjectBaseInfo_MetaData
        {

            [Column(Text = "项目名称", Order = 0)]
            [Field(FieldLabel = "项目名称")]
            public string ProjectFullName { get; set; }

            [Column(Text = "项目简称", Order = 1)]
            [Field(FieldLabel = "项目简称")]
            public string ProjectName { get; set; }

            [Column(Text = "建设单位", Order = 2)]
            [Field(FieldLabel = "建设单位")]
            public string ConstructionCompany { get; set; }
            /// <summary>
            /// 项目类型,见枚举
            /// </summary>

            [Column(Text = "项目类型", Order =3)]
            [Field(FieldLabel = "项目类型")]
            public string ProjectType { get; set; }

            [Column(Text = "项目规模", Order = 4)]
            [Field(FieldLabel = "项目规模")]
            public float ProjectScale { get; set; }

            [Column(Text = "项目地点", Order = 5)]
            [Field(FieldLabel = "项目地点")]
            public string ProjectAddress { get; set; }
            public DateTime EntryDate { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime FinishedDate { get; set; }
            public DateTime CompletionDate { get; set; }
            /// <summary>
            /// 施工期（单位：月 ）
            /// </summary>
            public int ConstructionPeriod { get; set; }
            /// <summary>
            /// 缺陷责任期（单位:月）
            /// </summary>
            public int DefectsLiabilityPeriod { get; set; }
            public string Description { get; set; }

            public virtual ICollection<EM_ProjectContractBaseInfo> EM_ProjectContractBaseInfo { get; set; }
            public virtual ICollection<EM_ProjectPersonManage> EM_ProjectPersonManage { get; set; }
            public virtual ICollection<EM_ProjectContractPerformance> EM_ProjectContractPerformance { get; set; }
            public virtual ICollection<EM_ProjectTestPutOnFile> EM_ProjectTestPutOnFile { get; set; }
        }
    }
}
