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
    
    public partial class VM_PaymentDetailInfo
    {
        public int PaymentDetailID { get; set; }
        public string VehicleLoanID { get; set; }
        public string VehicleID { get; set; }
        public string PaymentDate { get; set; }
        public string MonthlyPlanPrincipal { get; set; }
        public string MonthlyPlaceInterest { get; set; }
        public string MonthlyPlanAmount { get; set; }
        public string MonthlyRealityPrincipal { get; set; }
        public string MonthlyRealityInterest { get; set; }
        public string MonthlyRealityAmount { get; set; }
        public string RemainPrincipal { get; set; }
        public string RemainInterest { get; set; }
        public string RemainTotalLoans { get; set; }
        public decimal DepositMoney { get; set; }
        public string BankAccountBalance { get; set; }
        public string OperatorUserID { get; set; }
        public string Description { get; set; }
    
        public virtual VM_VehicleLoanInfo VM_VehicleLoanInfo { get; set; }
    }
}
