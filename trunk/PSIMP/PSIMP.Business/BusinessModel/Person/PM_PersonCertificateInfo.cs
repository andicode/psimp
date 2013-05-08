

namespace PSIMP.Models
{

    using System;
    using System.Collections.Generic;
    using PSIMP.Business.BaseModel;
    
    public partial class PM_PersonCertificateInfo : BaseEntity
    {
        public string CertificateName { get; set; }
        public string CertificateType { get; set; }
        public string CertificateNumber { get; set; }
        public System.DateTime GotDate { get; set; }
        public string Authority { get; set; }
        public string Descriptions { get; set; }
        public System.Guid PersonID { get; set; }
    
        public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
    }
}
