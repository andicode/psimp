using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity.InterceptionExtension;
using System.Data;

namespace PSIMP.Infrastructure.IOC
{
    /// </summary>
    public class TransactionAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(Microsoft.Practices.Unity.IUnityContainer container)
        {
            return new TransactionInterceptor(Level, Order);
        }
        /// <summary>
        /// 事务隔离级别
        /// </summary>
        public IsolationLevel Level { get; private set; }

        /// <summary>
        /// 自定义事务隔离级别
        /// </summary>
        /// <param name="level"></param>
        public TransactionAttribute(IsolationLevel level)
        {
            this.Level = level;
        }
        /// <summary>
        /// 使用数据库默认隔离级别
        /// </summary>
        public TransactionAttribute() : this(IsolationLevel.Unspecified) { }
    }
}
