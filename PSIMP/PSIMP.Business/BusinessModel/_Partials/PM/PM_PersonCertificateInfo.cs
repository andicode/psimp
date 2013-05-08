using Ext.Net;
using Ext.Net.MVC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    /// <summary>
    /// 证书信息
    /// </summary>
    [Proxy(Read = "~/Person/GetCerts")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_PersonCertificateInfo_MetaData))]
    public partial class PM_PersonCertificateInfo
    {
        public class PM_PersonCertificateInfo_MetaData
        {
            [Column(Hideable = false, Hidden = true)]
            [Field(FieldType = typeof(Hidden))]
            public Guid ID { get; set; }

            [Column(Text = "证书名称", Order = 1)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入证书名称")]            
            public string CertificateName { get; set; }

            [Column(Text = "证书类型", Order = 2)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入证书类型")]
            public string CertificateType { get; set; }

            [Column(Text = "证书编号", Order = 3)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入证书编号")]
            public string CertificateNumber { get; set; }
            [DateColumn(Text = "取得时间", Order = 4)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入取得时间")]
            public System.DateTime GotDate { get; set; }
            [Column(Text = "颁发机构", Order = 5)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入颁发机构")]
            public string Authority { get; set; }
            [Column(Text = "备注", Order = 6)]
            [Field(HideLabel = true)] 
            public string Descriptions { get; set; }


            [Column(Hideable = false, Hidden = true)]
            public Guid PersonID { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
            public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }           
        
        }
    }
}
