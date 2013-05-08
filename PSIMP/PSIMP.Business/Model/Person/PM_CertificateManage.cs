using System;
using System.Collections.Generic;
using PSIMP.Business.BaseModel;


namespace PSIMP.Models
{
    public partial class PM_CertificateManage:BaseEntity
    {
        public string FileNumber { get; set; }
        public string PersonID { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public System.Guid ProjectID { get; set; }
        public bool PositionStatus { get; set; }
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
        public string Descriptions { get; set; }
    
        public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
    }
}
