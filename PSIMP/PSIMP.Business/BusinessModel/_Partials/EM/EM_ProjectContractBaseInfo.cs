using Ext.Net;
using Ext.Net.MVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    [Proxy(Read = "~/Project/GetContracts")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(EM_ProjectContractBaseInfo_MetaData))]
    public partial class EM_ProjectContractBaseInfo
    {
        public class EM_ProjectContractBaseInfo_MetaData
        {
            public string ID { get; set; }

            public System.DateTime BiddingDate { get; set; }
            /// <summary>
            /// 合同工期
            /// </summary>
            public int ContractPeriod { get; set; }
            public DateTime OpenDate { get; set; }
            /// <summary>
            /// 开口期限
            /// </summary>
            public int OpeningPeriod { get; set; }
            public string OpeningConditions { get; set; }
            public string Description { get; set; }
            /// <summary>
            /// 合同附件
            /// </summary>
            public string ContractAttachment { get; set; }

            public virtual EM_ProjectBaseInfo EM_ProjectBaseInfo { get; set; }
            public virtual ICollection<EM_ProjectContractDataInfo> EM_ProjectContractDataInfo { get; set; }
            public virtual ICollection<EM_ProjectContractPayCondition> EM_ProjectContractPayCondition { get; set; }
            public virtual ICollection<EM_ProjectContractPersonInfo> EM_ProjectContractPersonInfo { get; set; }
            public virtual ICollection<EM_ProjectExpandInfo> EM_ProjectExpandInfo { get; set; }
        }
    }
}
