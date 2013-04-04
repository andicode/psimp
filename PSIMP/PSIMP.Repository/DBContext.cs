﻿using PSIMP.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.Metadata.Edm;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PSIMP.Repository
{
    public class DBContext<T> where T:Psimp
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
        public T Add(T entity) 
        {
            try
            {
                Context.Set<T>().Add(entity);
                Context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

            }
            catch (Exception e)
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
        public T Update(T entity)
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
        public bool CompletelyDelete(object Id) 
        {
            return CompletelyDelete(Context.Set<T>().Find(Id));
        } /// <summary>
        /// 测底从据库数据库删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool CompletelyDelete(T entity) 
        {
            Context.Set<T>().Remove(entity);
            return Context.SaveChanges() == 1;
        }

        public T Get(object id)
        {
            return Context.Set<T>().Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>().Where(m => true);
        }

        public IQueryable<T> GetPagesData(int start, int limit) 
        {
            return Context.Set<T>().OrderBy(m=>m.Id).Skip(start).Take(limit);
        }

        public int Count(Expression<Func<T, bool>> expr = null)
        {
            if (expr != null)
                return Context.Set<T>().Count(expr);
            return Context.Set<T>().Count();
        }
    }
}
