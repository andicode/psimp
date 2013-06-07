using Ext.Net.MVC;
using PSIMP.Infrastructure.CommonData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PSIMP.Models
{
    [Proxy(Read = "~/Assets/default/getAssets")]
    [JsonReader(Root = "data")]
    [MetadataType(typeof(AMG_AssetBaseInfo_MetaData))]
    public partial class AMG_AssetBaseInfo
    {
        public class AMG_AssetBaseInfo_MetaData
        {
            [Column(Ignore=true)]
            public string ID { get; set; }
            /// <summary>
            /// 资产类别,详见枚举
            /// </summary>
            [Column(Ignore = true)]
            [Field(FieldLabel = "资产类型")]
            public int AssetType { get; set; }

            [Column(Text = "资产编号", Order = 1)]
            [Field(FieldLabel = "资产编号")]
            public string AssetSerialNumber { get; set; }
            [Column(Text = "资产名称", Order = 2)]
            [Field(FieldLabel = "资产名称")]
            public string AssetName { get; set; }
            [Column(Text = "规格型号", Order = 4)]
            [Field(FieldLabel = "规格型号")]
            public string AssetSpecificationModel { get; set; }
            [Column(Text = "单位", Order = 5)]
            [Field(FieldLabel = "单位")]
            public string Unit { get; set; }
            [Column(Text = "购置日期", Order = 6)]
            [Field(FieldLabel = "购置日期")]
            public DateTime? BuyDate { get; set; }
            [Column(Text = "数量", Order = 7)]
            [Field(FieldLabel = "数量")]
            public int Quantity { get; set; }
            [Column(Text = "单价(元)", Order = 8)]
            [Field(FieldLabel = "单价(元)")]
            public decimal UnitPrice { get; set; }
            [Column(Text = "金额(元)", Order = 9)]
            [Field(FieldLabel = "金额(元)")]
            public decimal SumPrice { get; set; }
            /// <summary>
            /// 资产状态
            /// </summary>
            [Column(Text = "资产状态", Order = 10)]
            [Field(FieldLabel = "资产状态")]
            public int AssetStatus { get; set; }
            [Column(Text = "备注", Order = 11)]
            [Field(FieldLabel = "备注")]
            public string Description { get; set; }
            [Column(Ignore = true)]
            public string Other1 { get; set; }
            [Column(Ignore = true)]
            public string Other2 { get; set; }
            [Column(Ignore = true)]
            public string Other3 { get; set; }

            [Column(Ignore=true)]
            public virtual ICollection<AMG_AssetAllocateInfo> AMG_AssetAllocateInfo { get; set; }
            [Column(Ignore = true)]
            public virtual ICollection<AMG_AssetRepairInfo> AMG_AssetRepairInfo { get; set; }
            [Column(Ignore = true)]
            public virtual ICollection<AMG_AssetUseInfo> AMG_AssetUseInfo { get; set; }
        }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        [Column(Text = "资产类型", Order = 3)]
        public string TypeName
        {
            get { return Enum.GetName(typeof(Enums.AssetType), this.AssetType);}
            set { ;}
        }
    }
}
