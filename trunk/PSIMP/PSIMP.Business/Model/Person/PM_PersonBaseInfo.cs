//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace PSIMP.Models
{
    using System;
    using System.Collections.Generic;
    using PSIMP.Business.BaseModel;
    
    public partial class PM_PersonBaseInfo : BaseEntity
    {
        public PM_PersonBaseInfo()
        {
            this.Sex = true;
            this.PM_CertificateManage = new HashSet<PM_CertificateManage>();
            this.PM_PersonRegister = new HashSet<PM_PersonRegister>();
            this.PM_PersonCertificateInfo = new HashSet<PM_PersonCertificateInfo>();
            this.PM_PersonInsuranceInfo = new HashSet<PM_PersonInsuranceInfo>();
            this.PM_PersonTrainingExperience = new HashSet<PM_PersonTrainingExperience>();
            this.PM_PersonPositionalTitlesInfo = new HashSet<PM_PersonPositionalTitlesInfo>();
            this.PM_PersonEducationalBackground = new HashSet<PM_PersonEducationalBackground>();
            this.PM_PersonWorkExperienceInfo = new HashSet<PM_PersonWorkExperienceInfo>();
            this.PM_PersonContractInfo = new HashSet<PM_PersonContractInfo>();
        }
        
        public string PersonName { get; set; }
        public bool Sex { get; set; }
        public System.DateTime Birthday { get; set; }
        public string IDNumber { get; set; }
        public string RegisterAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string AlternatePhoneNumber { get; set; }
        public byte[] TwoInchPhoto { get; set; }
    
        public virtual ICollection<PM_CertificateManage> PM_CertificateManage { get; set; }
        public virtual ICollection<PM_PersonRegister> PM_PersonRegister { get; set; }
        public virtual ICollection<PM_PersonCertificateInfo> PM_PersonCertificateInfo { get; set; }
        public virtual ICollection<PM_PersonInsuranceInfo> PM_PersonInsuranceInfo { get; set; }
        public virtual ICollection<PM_PersonTrainingExperience> PM_PersonTrainingExperience { get; set; }
        public virtual ICollection<PM_PersonPositionalTitlesInfo> PM_PersonPositionalTitlesInfo { get; set; }
        public virtual ICollection<PM_PersonEducationalBackground> PM_PersonEducationalBackground { get; set; }
        public virtual ICollection<PM_PersonWorkExperienceInfo> PM_PersonWorkExperienceInfo { get; set; }
        public virtual ICollection<PM_PersonContractInfo> PM_PersonContractInfo { get; set; }
    }
}
