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
	using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class PM_PersonRegister
    {
        public string RegisterID { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public string RegisterCompany { get; set; }
        public string OldDBDesc { get; set; }
        public string NewDBDesc { get; set; }
        public string IsHaveIdentificationCard { get; set; }
        public string IsHaveGraduationCertificate { get; set; }
        public string IsHavePositionalCertificate { get; set; }
        public string IshaveSupervisionCertificate { get; set; }
        public string IsHaveSecurityCertificate { get; set; }
        public string IsHaveConservationCertificate { get; set; }
        public string IshaveTwoInchPhoto { get; set; }
        public string RegisterStatus { get; set; }
        public string NoCanRegisterCause { get; set; }
        public string Descriptions { get; set; }
        public long PersonID { get; set; }
    
        public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
    }
}
