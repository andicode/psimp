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
        /// 支付方式
        /// </summary>
        public enum PayMode { 按月度 = 0, 按季度 = 1, 按次数 = 2,按比列=3 }
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

    }
}
