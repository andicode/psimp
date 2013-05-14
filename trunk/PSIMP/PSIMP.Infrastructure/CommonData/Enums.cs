using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSIMP.Infrastructure.CommonData
{
    public class Enums 
    {
        public enum Sex
        {
            男=0,
            女=1
        }
        public enum CertType
        {
            身份证,
            毕业证,
            职称证, 
            监理证,
            安全证,
            环保证
        }
        public enum RegisterStatus
        {
            未注册=0,
            已注册=1,
            已注销=2
        }
        /// <summary>
        /// 职位
        /// </summary>
        public enum Position {总监,副总监,专监,试验主任,试验员,监理员,办公室主任,司机,其他 }
        /// <summary>
        /// 合同状态
        /// </summary>
        public enum ContractStatus { 解除 = 0, 未解除 = 1 }
        /// <summary>
        /// 项目类型
        /// </summary>
        public enum ProjectType { 高速公路 = 0, 等级公路 = 1,其他=2 }
        /// <summary>
        /// 项目合同支付方式
        /// </summary>
        public enum ContractPayMode { 按月度 = 0, 按季度 = 1, 按次数 = 2,按比列=3 }
        /// <summary>
        /// 纳税方式
        /// </summary>
        public enum PayDutyMode {协作单位=0,监理单位=1,业主代缴=2 }
        /// <summary>
        /// 项目人员类别
        /// </summary>
        public enum PersonComeType { 履约 = 0, 变更 = 1, 增配 = 2 }
        /// <summary>
        /// 项目人员在场状态
        /// </summary>
        public enum PersonSceneStatus { 在现场 = 0, 不在现场 = 1 }
        /// <summary>
        /// 车辆支付方式
        /// </summary>
        public enum VehiclePayMode { 一次性支付 = 0, 分期支付 = 1 }
        /// <summary>
        /// 车辆来源
        /// </summary>
        public enum VehicleSource { 公司 = 0, 租赁 = 1, 业主 = 2 }
        /// <summary>
        /// 车辆使用状态
        /// </summary>
        public enum VehicleUseStatus { 在用 = 0, 出售 = 1, 报废 = 2 }
        /// <summary>
        /// 车辆租赁合同状态
        /// </summary>
        public enum VehicleLeaseStatus { 办理中 = 0, 经签 = 1, 未签 = 2 }
        /// <summary>
        /// 维修级别
        /// </summary>
        public enum VehicleRepairGrade { 大修 = 0, 中修 = 1, 小修 = 2 }
        /// <summary>
        /// 资产类别
        /// </summary>
        public enum AssetType { 办公设备 = 0, 生活用品 = 1, 试验设备 = 2 }
        /// <summary>
        /// 资产维修类别
        /// </summary>
        public enum AssetRepairType {维修=0,处置=1,报废=2 }
        /// <summary>
        /// 车辆类申请类别
        /// </summary>
        public enum VehicleApplicationType { 车辆维修申请 = 0, 车辆保养申请 = 1, 车辆年审申请 = 2 }
        /// <summary>
        /// 资产类申请类别
        /// </summary>
        public enum AssetApplicationType { 资产购置 = 0, 资产维修 = 1, 资产处置 = 2 }
        /// <summary>
        /// 来文类别
        /// </summary>
        public enum LaiWenType { 业主类 = 0, 质检站类 = 1, 公司总部类 = 2, 事业部通知公告类 = 3 }
        /// <summary>
        /// 来文方式
        /// </summary>
        public enum LaiWenMode { 邮件 = 0, 传真 = 1, 信函 = 2 }

    }
}
