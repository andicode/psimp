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
    
    public partial class PM_PersonCertificateInfo
    {
        public string CertificateID { get; set; }
        public string CertificateName { get; set; }
        public string CertificateType { get; set; }
        public string CertificateNumber { get; set; }
        public System.DateTime GotDate { get; set; }
        public string Authority { get; set; }
        public string Descriptions { get; set; }
        public string PersonID { get; set; }
    }
}
