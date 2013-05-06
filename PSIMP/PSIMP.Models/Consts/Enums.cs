using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSIMP.Models
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
    }
}
