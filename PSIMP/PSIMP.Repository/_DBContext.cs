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
    public class DBContext<T> where T : class,new()
    {
        public DBContext()
        {
            //test
            AccountUserId = 1;
        }
        public DBContext(int userId)
        {
            AccountUserId = userId;
        }
        public int AccountUserId { get; set; }
        private PSIMPDBContainer _context = null;
        public PSIMPDBContainer db
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
            db.Set<T>().Add(entity);
            db.SaveChanges();
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
            db.Set<T>().Attach(entity);
            var saveEntity = db.Entry<T>(entity);
            saveEntity.State = EntityState.Modified;
            db.SaveChanges();
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
            return CompletelyDelete(Get(Id));
        } /// <summary>
        /// 测底从据库数据库删除
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool CompletelyDelete(T entity)
        {
            db.Set<T>().Remove(entity);
            return db.SaveChanges() == 1;
        }

        public T Get(object id)
        {
            return db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().AsParallel().Where(m => true);
        }
        public IEnumerable<T> Where(Func<T, bool> expr)
        {
            return db.Set<T>().AsParallel().Where(expr);
        }
        public IEnumerable<T> GetPagesData(int start, int limit)
        {
            return db.Set<T>().AsParallel().OrderByDescending(m => m).Skip(start).Take(limit);
        }

        public int Count(Expression<Func<T, bool>> expr = null)
        {
            if (expr != null)
                return db.Set<T>().Count(expr);
            return db.Set<T>().Count();
        }
    }
}
