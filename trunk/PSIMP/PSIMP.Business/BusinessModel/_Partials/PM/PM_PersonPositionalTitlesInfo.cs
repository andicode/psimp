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
    /// 职称信息
    /// </summary>
    [Proxy(Read = "~/Persons/Default/GetTitles")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(PM_PersonPositionalTitlesInfo_MetaData))]
    public partial class PM_PersonPositionalTitlesInfo 
    {
        public class PM_PersonPositionalTitlesInfo_MetaData
        {
            [Column(Hideable = false, Hidden = true)]
            [Field(FieldType = typeof(Hidden))]
            public Guid ID { get; set; }

            [Column(Text = "职称名称",Order = 1)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入职称名称")]
            public string PositionalName { get; set; }

            [Column(Text = "职称类型", Order = 2)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入职称类型")]
            public string PositionalType { get; set; }

            [DateColumn(Text = "取得时间", Order = 3)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请选择职称取得时间")]
            public DateTime? AssessmentDate { get; set; }

            [Column(Text = "评定机构(授予单位)",Width=150, Order = 4)]
            [Field(HideLabel = true, AllowBlank = false, BlankText = "请输入职称评定机构(授予单位)")]
            public string AssessmentBody { get; set; }


            [Column(Text = "备注", Width = 200, Order = 5)]
            [Field(HideLabel = true)]
            public string Description { get; set; }


            //[Column(Hideable = false, Hidden = true)]
            //public Guid PersonID { get; set; }

            [Column(Ignore = true)]
            [JsonIgnore]
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