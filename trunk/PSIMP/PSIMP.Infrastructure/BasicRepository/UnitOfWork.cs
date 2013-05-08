using PSIMP.Business.Context;
using Microsoft.Practices.Unity;


namespace PSIMP.Infrastructure.BasicRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        [Dependency]
        public IDBFactory _databaseFactory { get; set; }
        private PSIMPContext _dataContext;

        protected PSIMPContext DataContext
        {
            get { return _dataContext ?? (_dataContext = _databaseFactory.Get()); }
        }

        public void Commit()
        {
            DataContext.Commit();
        }
    }
}
