

namespace PSIMP.Models
{

    using System;
    using System.Collections.Generic;
    using PSIMP.Business.BaseModel;
    
    public partial class PM_PersonCertificateInfo : BaseEntity
    {
        public string CertificateName { get; set; }
        /// <summary>
        /// 证书类型,详见:枚举 CertType
        /// </summary>
        public string CertificateType { get; set; }
        public string CertificateNumber { get; set; }
        public DateTime? GotDate { get; set; }
        public string Authority { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// 各种证书扫描附件（存路径）
        /// </summary>
        public string Attachment { get; set; }
    
        public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
    }
}
