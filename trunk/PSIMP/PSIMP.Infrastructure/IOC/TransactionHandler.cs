using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity.InterceptionExtension;
using System.Data;
using System.Data.Sql;
using System.Data.Entity;
using PSIMP.Business.Context;
using Microsoft.Practices.Unity;
using PSIMP.Infrastructure.BasicRepository;
using System.Transactions;

namespace PSIMP.Infrastructure.IOC
{
    public class TransactionInterceptor : ICallHandler
    {
        public IDBFactory _databaseFactory { get; set; }
        private PSIMPContext _dataContext;

        protected PSIMPContext DataContext
        {
            get { return _dataContext ?? (_dataContext = _databaseFactory.Get()); }
        }
        public System.Data.IsolationLevel Level { get; private set; }

        public TransactionInterceptor(System.Data.IsolationLevel level, int order, IDBFactory db)
        {
            this.Level = level;
            this.Order = order;
            _databaseFactory = db;
        }

        #region ICallHandler 成员

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            using (TransactionScope tran = new TransactionScope())
            {
                var result = getNext()(input, getNext);
                if (result.Exception == null)
                {
                    tran.Complete();
                }
                else
                {
                    result.Exception = null;
                }
                return result;
            }
        }

        public int Order { get; set; }

        #endregion

    }
}
