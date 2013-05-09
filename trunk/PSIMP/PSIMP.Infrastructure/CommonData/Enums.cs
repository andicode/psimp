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
    }
}
