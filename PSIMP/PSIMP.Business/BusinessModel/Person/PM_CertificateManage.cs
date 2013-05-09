using System;
using System.Collections.Generic;
using PSIMP.Business.BaseModel;


namespace PSIMP.Models
{
    public partial class PM_CertificateManage:BaseEntity
    {
        public string FileNumber { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool PositionStatus { get; set; }
        public DateTime SubmitCorporationDate { get; set; }
        public bool IsSubmitGraduationCertificate { get; set; }
        public bool IsSubmitSupervisionCertificate { get; set; }
        public bool IsSubmitPositionalCertificate { get; set; }
        public bool IsSubmitSecurityCertificate { get; set; }
        public bool IsSubmitConservationCertificate { get; set; }
        public bool IsSubmitIdentificationCard { get; set; }
        public DateTime ReturnBusinessUnitDate { get; set; }
        public bool IsReturnGraduationCertificate { get; set; }
        public bool IsReturnSupervisionCertificate { get; set; }
        public bool IsReturnPositionalCertificate { get; set; }
        public bool IsReturnSecurityCertificate { get; set; }
        public bool IsReturnConservationCertificate { get; set; }
        public bool IsReturnIdentificationCard { get; set; }
        public DateTime GivebackSelfDate { get; set; }
        public bool IsGivebackGraduationCertificate { get; set; }
        public bool IsGivebackSupervisionCertificate { get; set; }
        public bool IsGivebackPositionalCertificate { get; set; }
        public bool IsGivebackSecurityCertificate { get; set; }
        public bool IsGivebackConservationCertificate { get; set; }
        public bool IsGivebackIdentificationCard { get; set; }
        public string Description { get; set; }
    
        public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
        /// <summary>
        /// 所在项目
        /// </summary>
        public virtual EM_ProjectBaseInfo EM_ProjectBaseInfo { get; set; }
    }
}
