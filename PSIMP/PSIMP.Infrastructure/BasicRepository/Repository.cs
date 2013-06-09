using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.Entity;
using PSIMP.Business.Context;
using PSIMP.Business.BaseModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Collections;
using System.Data.Entity.Infrastructure;



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
            DataContext.SaveChanges();
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            var entry = _dataContext.Entry(entity);
            DbPropertyValues databseValues = entry.GetDatabaseValues();
            entry.OriginalValues.SetValues(databseValues);
            entry.CurrentValues["CreateTime"] = databseValues["CreateTime"];
            entry.CurrentValues["CreateUser"] = databseValues["CreateUser"];
            DataContext.SaveChanges();
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
            DataContext.SaveChanges();
        }
        public void Delete(Expression<Func<T, Boolean>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
            DataContext.SaveChanges();
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
        /// <summary>
        /// 分页查询方法
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="propertyName">排序属性</param>
        /// <param name="asc">是否升序</param>
        /// <param name="pageSize">每页显示的记录数</param>
        /// <param name="pageIndex">当前页数，默认从1开始</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public virtual IEnumerable<T> GetPagesData(Expression<Func<T, bool>> where, string propertyName, bool asc, int pageSize, int pageIndex, out long totalCount)
        {
            totalCount = 0;
            int skipCount = (pageIndex - 1) * pageSize;
            var result = where != null ? dbset.Where(where).AsQueryable() : dbset.AsQueryable();
            totalCount = result.Count();
            result = skipCount == 0 ? result.OrderBy(propertyName, asc).Take(pageSize) : result.OrderBy(propertyName, asc).Skip(skipCount).Take(pageSize);
            return result.AsQueryable().ToList();
        }
        /// <summary>
        /// 分页查询方法
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="pageSize">每页显示的记录数</param>
        /// <param name="pageIndex">当前页数，默认从1开始</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        public virtual IEnumerable<T> GetPagesData(Expression<Func<T, bool>> where, int pageSize, int pageIndex, out long totalCount)
        {
            totalCount = 0;
            int skipCount = (pageIndex - 1) * pageSize;
            var result = where != null ? dbset.Where(where).AsQueryable() : dbset.AsQueryable();
            totalCount = result.Count();
            result = skipCount == 0 ? result.OrderBy(m => m.CreateTime).Take(pageSize) : result.OrderBy(m => m.CreateTime).Skip(skipCount).Take(pageSize);
            return result.AsQueryable().ToList();
        }
    }
}
