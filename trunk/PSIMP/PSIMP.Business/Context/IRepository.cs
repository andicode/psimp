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
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetByCondition(Expression<Func<T, bool>> where);
        /// <summary>
        /// 分页查询方法
        /// </summary>
        /// <param name="query">查询条件</param>
        /// <param name="pageSize">每页显示的记录数</param>
        /// <param name="pageIndex">当前页数，默认从1开始</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        IEnumerable<T> GetPagesData(Expression<Func<T, bool>> where, int pageSize, int pageIndex, out long totalCount);
        /// <summary>
        /// 分页查询方法
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="orderBy">排序属性，单个属性</param>
        /// <param name="asc">是否升序</param>
        /// <param name="pageSize">每页显示的记录数</param>
        /// <param name="pageIndex">当前页数，默认从1开始</param>
        /// <param name="totalCount">总记录数</param>
        /// <returns></returns>
        IEnumerable<T> GetPagesData(Expression<Func<T, bool>> where, string orderBy, bool asc, int pageSize, int pageIndex, out long totalCount);
    }
}
