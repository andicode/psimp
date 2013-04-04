using PSIMP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;

namespace PSIMP.Repository
{
    public class DBContext
    {
        private PSIMPDBContainer _context = null;
        public PSIMPDBContainer Context
        {
            get
            {
                if (_context == null)
                    _context = new PSIMPDBContainer();
                return _context;
            }
        }

        /// <summary>
        /// 新增一个到数据库
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T Add<T>(T entity) where T:class
        {
            try
            {
                Context.Set<T>().Add(entity);
                Context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
 
            }
            return entity;
        }
        /// <summary>
        /// 更新数据库数据库
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public T Update<T>(T entity) where T : class
        {
            if(!Context.Set<T>().Contains(entity))
            {
               Context.Set<T>().Attach(entity);
            }
            Context.Entry<T>(entity).State = EntityState.Modified;
            Context.SaveChanges();
            return entity;
        }
        /// <summary>
        /// 测底从据库数据库删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Id">实体主键</param>
        /// <returns></returns>
        public bool CompletelyDelete<T>(object Id) where T : class
        {
            return CompletelyDelete(Context.Set<T>().Find(Id));
        } /// <summary>
        /// 测底从据库数据库删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool CompletelyDelete<T>(T entity) where T : class
        {
            Context.Set<T>().Remove(entity);
            return Context.SaveChanges() == 1;
        }

        public T Get<T>(object id) where T : class
        {
            return Context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll<T>() where T : class
        {
            return Context.Set<T>().Where(m => true);
        }
    }
}
