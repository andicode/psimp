using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSIMP.Business.BaseModel;
using System.Linq.Expressions;

namespace PSIMP.Business.Context
{
    public interface IRepository<T> where T:BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(string Id);
        T Get(Func<T, bool> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByCondition(Expression<Func<T, bool>> where);
    }
}
