using Ext.Net;
using Ext.Net.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    [Proxy(Read = "~/Project/GetProjects")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(EM_ProjectBaseInfo_MetaData))]
    public partial class EM_ProjectBaseInfo
    {
        public class EM_ProjectBaseInfo_MetaData
        {
            [Column(Ignore=true)]
            [Field(FieldType=typeof(Hidden))]
            public string ID { get; set; }

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
            [Column(Text = "进场日期", Order = 6)]
            [Field(FieldLabel = "进场日期")]
            public DateTime EntryDate { get; set; }
            [Column(Text = "开工日期", Order = 7)]
            [Field(FieldLabel = "开工日期")]
            public DateTime StartDate { get; set; }
            [Column(Text = "交工日期", Order = 8)]
            [Field(FieldLabel = "交工日期")]
            public DateTime FinishedDate { get; set; }
            [Column(Text = "竣工日期", Order = 9)]
            [Field(FieldLabel = "竣工日期")]
            public DateTime CompletionDate { get; set; }
            /// <summary>
            /// 施工期（单位：月 ）
            /// </summary>

            [Column(Text = "施工期", Order = 10)]
            [Field(FieldLabel = "施工期")]
            public int ConstructionPeriod { get; set; }
            /// <summary>
            /// 缺陷责任期（单位:月）
            /// </summary>

            [Column(Text = "缺陷责任期", Order = 11)]
            [Field(FieldLabel = "缺陷责任期")]
            public int DefectsLiabilityPeriod { get; set; }
            [Column(Text = "备注", Order = 12)]
            [Field(FieldLabel = "备注")]
            public string Description { get; set; }

            [Column(Ignore = true)]
            [Newtonsoft.Json.JsonIgnore]
            public virtual ICollection<EM_ProjectContractBaseInfo> EM_ProjectContractBaseInfo { get; set; }
            [Column(Ignore = true)]
            [Newtonsoft.Json.JsonIgnore]
            public virtual ICollection<EM_ProjectPersonManage> EM_ProjectPersonManage { get; set; }
            [Column(Ignore = true)]
            [Newtonsoft.Json.JsonIgnore]
            public virtual ICollection<EM_ProjectContractPerformance> EM_ProjectContractPerformance { get; set; }
            [Column(Ignore = true)]
            [Newtonsoft.Json.JsonIgnore]
            public virtual ICollection<EM_ProjectTestPutOnFile> EM_ProjectTestPutOnFile { get; set; }
        }
    }
}
