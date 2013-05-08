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
    /// 培训信息
    /// </summary>
    [Proxy(Read = "~/Person/GetTrains")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_PersonTrainingExperience_MetaData))]
    public partial class PM_PersonTrainingExperience 
    {
        public class PM_PersonTrainingExperience_MetaData
        {
            [Column(Hideable = false, Hidden = true)]
            [Field(FieldType = typeof(Hidden))]
            public Guid ID { get; set; }

            [Column(Text = "机构名称",Order = 1)]
            [Field(FieldLabel = "机构名称", AllowBlank = false, BlankText = "请输入机构名称")]
            public string InstitutionsName { get; set; }

            [DateColumn(Text = "开始时间", Order = 2)]
            [Field(FieldLabel = "开始时间", AllowBlank = false, BlankText = "请选择开始时间")]
            public DateTime TrainingStartDate { get; set; }

            [DateColumn(Text = "结束时间", Order = 3)]
            [Field(FieldLabel = "结束时间")]
            public DateTime TrainingEndDate { get; set; }

            [Column(Text = "培训地点", Order = 4)]
            [Field(FieldLabel = "培训地点")]
            public string TrainingAddress { get; set; }

            [Column(Text = "培训内容", Order =5)]
            [Field(FieldLabel = "培训内容")]
            public DateTime TrainingContent { get; set; }

            [Column(Text = "获得证书", Order = 6)]
            [Field(FieldLabel = "获得证书")]
            public string GotCertificate { get; set; }

            [Column(Text = "备注", Order = 7)]
            [Field(FieldLabel = "备注")]
            public string Descriptions { get; set; }


            [Column(Hideable = false, Hidden = true)]
            public Guid PersonID { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }           
        }
       
    }


    
}