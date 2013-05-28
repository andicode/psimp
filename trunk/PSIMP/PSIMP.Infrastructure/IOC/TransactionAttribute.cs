using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
using PSIMP.Infrastructure.BasicRepository;

namespace PSIMP.Infrastructure.IOC
{
    /// </summary>
    public class TransactionAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(Microsoft.Practices.Unity.IUnityContainer container)
        {
            IDBFactory db = (IDBFactory)container.Resolve<IDBFactory>();
            return new TransactionInterceptor(Level, Order, db);
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
