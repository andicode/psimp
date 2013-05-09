using PSIMP.Business.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public static class PageExtensions
    {
        public static IEnumerable<T> GetPagesData<T>(this IEnumerable<T> data,int start,int count,out int total) where T :BaseEntity
        {
            total = data.Count();
            return data.OrderBy(m => m.CreateTime).Skip(start).Take(count);
        }
    }
}
