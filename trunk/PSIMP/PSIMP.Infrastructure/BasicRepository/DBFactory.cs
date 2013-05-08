
using System.Data.Entity;
using PSIMP.Business.Context;

namespace PSIMP.Infrastructure.BasicRepository
{
public class DBFactory : Disposable, IDBFactory
{

    public DBFactory()
    {
        Database.SetInitializer<PSIMPContext>(new CreateDatabaseIfNotExists<PSIMPContext>());
    }
    private PSIMPContext dataContext;
    public PSIMPContext Get()
    {
        return dataContext ?? (dataContext = new PSIMPContext());
    }
    protected override void DisposeCore()
    {
        if (dataContext != null)
            dataContext.Dispose();
    }
}
}
