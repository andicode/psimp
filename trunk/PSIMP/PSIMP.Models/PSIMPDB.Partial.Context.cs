﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PSIMPDBContainer : DbContext
    {
         public DbSet<UserProfile> UserProfileSet { get; set; }
         public DbSet<AM_ApplicationContent_CapitalFundCategory> AM_ApplicationContent_CapitalFundCategorySet { get; set; }
         public DbSet<AM_ApplicationContent_VehicleCategory> AM_ApplicationContent_VehicleCategorySet { get; set; }
         public DbSet<AM_ApplicationRepliedDetail> AM_ApplicationRepliedDetailSet { get; set; }
         public DbSet<AM_LaiWenCircularizeDetail> AM_LaiWenCircularizeDetailSet { get; set; }
         public DbSet<AM_LaiWenRecordInfo> AM_LaiWenRecordInfoSet { get; set; }
         public DbSet<AM_LaiWenRepliedInfo> AM_LaiWenRepliedInfoSet { get; set; }
         public DbSet<AM_ProjectApplicationBaseInfo> AM_ProjectApplicationBaseInfoSet { get; set; }
         public DbSet<AM_ProjectApplicationRepliedInfo> AM_ProjectApplicationRepliedInfoSet { get; set; }
         public DbSet<EM_ProjectBaseInfo> EM_ProjectBaseInfoSet { get; set; }
         public DbSet<EM_ProjectContractBaseInfo> EM_ProjectContractBaseInfoSet { get; set; }
         public DbSet<EM_ProjectContractDataInfo> EM_ProjectContractDataInfoSet { get; set; }
         public DbSet<EM_ProjectContractPayCondition> EM_ProjectContractPayConditionSet { get; set; }
         public DbSet<EM_ProjectContractPerformance> EM_ProjectContractPerformanceSet { get; set; }
         public DbSet<EM_ProjectContractPersonInfo> EM_ProjectContractPersonInfoSet { get; set; }
         public DbSet<EM_ProjectExpandInfo> EM_ProjectExpandInfoSet { get; set; }
         public DbSet<EM_ProjectPersonManage> EM_ProjectPersonManageSet { get; set; }
         public DbSet<EM_ProjectTestPutOnFile> EM_ProjectTestPutOnFileSet { get; set; }
         public DbSet<PM_CertificateManage> PM_CertificateManageSet { get; set; }
         public DbSet<PM_PersonBaseInfo> PM_PersonBaseInfoSet { get; set; }
         public DbSet<PM_PersonCertificateInfo> PM_PersonCertificateInfoSet { get; set; }
         public DbSet<PM_PersonContractInfo> PM_PersonContractInfoSet { get; set; }
         public DbSet<PM_PersonEducationalBackground> PM_PersonEducationalBackgroundSet { get; set; }
         public DbSet<PM_PersonInsuranceInfo> PM_PersonInsuranceInfoSet { get; set; }
         public DbSet<PM_PersonPositionalTitlesInfo> PM_PersonPositionalTitlesInfoSet { get; set; }
         public DbSet<PM_PersonRegister> PM_PersonRegisterSet { get; set; }
         public DbSet<PM_PersonTrainingExperience> PM_PersonTrainingExperienceSet { get; set; }
         public DbSet<PM_PersonWorkExperienceInfo> PM_PersonWorkExperienceInfoSet { get; set; }
    }
}
