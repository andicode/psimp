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
    
    public partial class EM_ProjectBaseInfo : BaseEntity
    {
        public string ProjectFullName { get; set; }
        public string ProjectName { get; set; }
        public string ConstructionCompany { get; set; }
        /// <summary>
        /// 项目类型,见枚举
        /// </summary>
        public string ProjectType { get; set; }
        public float ProjectScale { get; set; }
        public string ProjectAddress { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishedDate { get; set; }
        public DateTime CompletionDate { get; set; }
        /// <summary>
        /// 施工期（单位：月 ）
        /// </summary>
        public int ConstructionPeriod { get; set; }
        /// <summary>
        /// 缺陷责任期（单位:月）
        /// </summary>
        public int DefectsLiabilityPeriod { get; set; }
        public string Description { get; set; }

        public virtual EM_ProjectExpandInfo EM_ProjectExpandInfo { get; set; }
        public virtual ICollection<EM_ProjectContractBaseInfo> EM_ProjectContractBaseInfo { get; set; }
        public virtual ICollection<EM_ProjectPersonManage> EM_ProjectPersonManage { get; set; }
        public virtual ICollection<EM_ProjectContractPerformance> EM_ProjectContractPerformance { get; set; }
        public virtual ICollection<EM_ProjectTestPutOnFile> EM_ProjectTestPutOnFile { get; set; }
    }
}