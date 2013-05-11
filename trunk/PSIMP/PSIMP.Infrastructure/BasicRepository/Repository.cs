using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Entity;
using PSIMP.Business.Context;
using PSIMP.Business.BaseModel;
using System.Linq.Expressions;


namespace PSIMP.Infrastructure.BasicRepository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private PSIMPContext _dataContext;
        private readonly IDbSet<T> dbset;
        protected Repository(IDBFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }

        protected IDBFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected PSIMPContext DataContext
        {
            get { return _dataContext ?? (_dataContext = DatabaseFactory.Get()); }
        }
        public virtual void Add(T entity)
        {
            entity.ID = Guid.NewGuid().ToString();
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            //dbset.Attach(entity);
            _dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public void Delete(Expression<Func<T, Boolean>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset.Where(m => true);//.ToList<T>();
        }
        public virtual IEnumerable<T> GetByCondition(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).ToList();
        }
        public T Get(Expression<Func<T, Boolean>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }
    }
}
