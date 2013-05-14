using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using PSIMP.Business.Model;
using PSIMP.Models;

namespace PSIMP.Business.Context
{
    public class PSIMPContext : DbContext
    {
        public DbSet<Dept> Depts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PM_PersonBaseInfo> PM_PersonBaseInfo { get; set; }
        public DbSet<PM_PersonCertificateInfo> PM_PersonCertificateInfo { get; set; }
        public DbSet<PM_PersonContractInfo> PM_PersonContractInfo { get; set; }
        public DbSet<PM_PersonEducationalBackground> PM_PersonEducationalBackground { get; set; }
        public DbSet<PM_PersonInsuranceInfo> PM_PersonInsuranceInfo { get; set; }
        public DbSet<PM_PersonPositionalTitlesInfo> PM_PersonPositionalTitlesInfo { get; set; }
        public DbSet<PM_PersonRegister> PM_PersonRegister { get; set; }
        public DbSet<PM_PersonTrainingExperience> PM_PersonTrainingExperience { get; set; }
        public DbSet<PM_PersonWorkExperienceInfo> PM_PersonWorkExperienceInfo { get; set; }
        public DbSet<PM_CertificateManage> PM_CertificateManage { get; set; }
        public DbSet<EM_ProjectBaseInfo> EM_ProjectBaseInfo { get; set; }
        public DbSet<EM_ProjectContractBaseInfo> EM_ProjectContractBaseInfo { get; set; }
        public DbSet<EM_ProjectContractDataInfo> EM_ProjectContractDataInfo { get; set; }
        public DbSet<EM_ProjectContractPayCondition> EM_ProjectContractPayCondition { get; set; }
        public DbSet<EM_ProjectContractPerformance> EM_ProjectContractPerformance { get; set; }
        public DbSet<EM_ProjectContractPersonInfo> EM_ProjectContractPersonInfo { get; set; }
        public DbSet<EM_ProjectExpandInfo> EM_ProjectExpandInfo { get; set; }
        public DbSet<EM_ProjectPersonManage> EM_ProjectPersonManage { get; set; }
        public DbSet<EM_ProjectTestPutOnFile> EM_ProjectTestPutOnFile { get; set; }
        public virtual void Commit()
        {
            try
            {
                base.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
               var errors= ex.EntityValidationErrors;
            }
        }
    }
}
