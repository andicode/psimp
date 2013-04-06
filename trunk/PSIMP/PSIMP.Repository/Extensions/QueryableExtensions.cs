using PSIMP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace System.Linq
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> GetPagesData<T>(this IQueryable<T> query, int start, int limit) where T : Psimp
        {
            return query.OrderByDescending(m => m.CreateTime).Skip(start).Take(limit);
        }
    }
}