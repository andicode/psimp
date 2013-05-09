using Ext.Net;
using Ext.Net.MVC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PSIMP.Models
{
    /// <summary>
    /// 保险信息
    /// </summary>
    [Proxy(Read = "~/Person/GetCertificates")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_CertificateManage_MetaData))]
    public partial class PM_CertificateManage
    {
        public class PM_CertificateManage_MetaData
        {
            [Column(Hideable = false, Hidden = true)]
            [Field(FieldType = typeof(Hidden))]
            public Guid ID { get; set; }

            [Column(Text = "档案编号", Order = 1)]
            [Field(FieldLabel = "档案编号")]
            public string FileNumber { get; set; }

            [DateColumn(Text = "注册日期", Order = 3)]
            [Field(FieldLabel = "注册日期")]
            public System.DateTime RegisterDate { get; set; }

            //[Column(Text = "所在项目", Order = 4)]
            //[Field(FieldLabel = "所在项目")]
            //public System.Guid ProjectID { get; set; }

            [Column(Text = "在岗状态", Order = 5)]
            [Field(FieldLabel = "在岗状态")]
            public bool PositionStatus { get; set; }

            [DateColumn(Text = "提交北京中通日期", Order = 6)]
            [Field(FieldLabel = "提交北京中通日期")]
            public System.DateTime SubmitCorporationDate { get; set; }


            public bool IsSubmitGraduationCertificate { get; set; }
            public bool IsSubmitSupervisionCertificate { get; set; }
            public bool IsSubmitPositionalCertificate { get; set; }
            public bool IsSubmitSecurityCertificate { get; set; }
            public bool IsSubmitConservationCertificate { get; set; }
            public bool IsSubmitIdentificationCard { get; set; }
            public System.DateTime ReturnBusinessUnitDate { get; set; }
            public bool IsReturnGraduationCertificate { get; set; }
            public bool IsReturnSupervisionCertificate { get; set; }
            public bool IsReturnPositionalCertificate { get; set; }
            public bool IsReturnSecurityCertificate { get; set; }
            public bool IsReturnConservationCertificate { get; set; }
            public bool IsReturnIdentificationCard { get; set; }
            public System.DateTime GivebackSelfDate { get; set; }
            public bool IsGivebackGraduationCertificate { get; set; }
            public bool IsGivebackSupervisionCertificate { get; set; }
            public bool IsGivebackPositionalCertificate { get; set; }
            public bool IsGivebackSecurityCertificate { get; set; }
            public bool IsGivebackConservationCertificate { get; set; }
            public bool IsGivebackIdentificationCard { get; set; }
            public string Description { get; set; }

            //[Column(Hideable = false, Hidden = true)]
            //public string PersonID { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
        }

        [Column(Text = "姓名", Order = 2)]
        [Field(Ignore = true)]
        public string PersonName
        {
            get { return this.PM_PersonBaseInfo.PersonName; }
            set { }
        }
    }
}
