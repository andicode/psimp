using System;
using PSIMP.Business.Context;

namespace PSIMP.Infrastructure.BasicRepository
{
    public interface IDBFactory : IDisposable
    {
        PSIMPContext Get();
    }
}
