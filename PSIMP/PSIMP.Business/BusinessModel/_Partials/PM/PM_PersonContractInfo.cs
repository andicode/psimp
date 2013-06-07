using Ext.Net;
using Ext.Net.MVC;
using Newtonsoft.Json;
using PSIMP.Models.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PSIMP.Models
{
    /// <summary>
    /// 注册信息
    /// </summary>
    [Proxy(Read = "~/Persons/Contracts/GetContracts")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_PersonContractInfo_MetaData))]
    public partial class PM_PersonContractInfo 
    {
        public class PM_PersonContractInfo_MetaData
        {
            [Column(Ignore = true)]
            [Field(FieldType = typeof(Hidden))]
            public Guid ID { get; set; }

            [Column(Ignore = true)]
            [Field(FieldLabel = "合同人员")]
            public string PersonDisplayName { get; set; }

            [Column(Text = "姓名", Order = 1)]
            [Field(FieldLabel = "姓名")]
            public string PersonName { get; set; }

            [Column(Text = "性别", Order = 2)]
            [Field(FieldLabel = "性别")]
            public string Sex { get; set; }

            [Column(Text = "身份证号", Order = 3)]
            [Field(FieldLabel = "身份证号")]
            public string IDNumber { get; set; }

            [Column(Text ="合同编号",Order=4)]
            [Field(FieldLabel="合同编号")]
            public string ContractNumber { get; set; }

            [Column(Text = "签订日期", Order = 5)]
            [Field(FieldLabel = "签订日期")]
            public DateTime? SignDate { get; set; }

            [Column(Text = "开始日期", Order = 6)]
            [Field(FieldLabel = "开始日期")]
            public DateTime? ContractBeginDate { get; set; }

            [Column(Text = "终止日期", Order = 7)]
            [Field(FieldLabel = "终止日期")]
            public DateTime? ContractEndDate { get; set; }
            /// <summary>
            /// 合同岗位
            /// </summary>
            [Column(Text = "合同岗位", Order = 8)]
            [Field(FieldLabel = "合同岗位")]
            public string ContractPosition { get; set; }
            [Column(Text = "合同工资", Order = 9)]
            [Field(FieldLabel = "合同工资")]
            public decimal ContractSalary { get; set; }
            [Column(Text = "备注", Order = 10)]
            [Field(FieldLabel = "备注")]
            public string Description { get; set; }

            [Column(Ignore=true)]
            [Field(Ignore=true)]
            public virtual PM_PersonBaseInfo PM_PersonBaseInfo { get; set; }
        }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string PersonDisplayName
        {
            get { return this.PersonName + "," + this.Sex + "," + this.IDNumber; }
            set { }
        }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string PersonName
        {
            get { return this.PM_PersonBaseInfo.PersonName; }
        }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string Sex
        {
            get
            {
                return this.PM_PersonBaseInfo.Sex ? "男" : "女";
            }
        }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string IDNumber
        {
            get
            {
                return this.PM_PersonBaseInfo.IDNumber;
            }
        }
    }


    
}