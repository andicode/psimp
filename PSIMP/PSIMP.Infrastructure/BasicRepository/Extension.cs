using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Linq.Expressions;
using PSIMP.Business.BaseModel;

namespace PSIMP.Infrastructure.BasicRepository
{
    public static class Extension
    {
        public static IQueryable<T> OrderBy<T>(this IQueryable<T> source, string propertyName, bool ascending) where T : BaseEntity
        {
            Type type = typeof(T);
            PropertyInfo property = type.GetProperty(propertyName);
            if (property == null)
                throw new ArgumentException("propertyName", "Not Exist");

            ParameterExpression param = Expression.Parameter(type, "p");
            Expression propertyAccessExpression = Expression.MakeMemberAccess(param, property);
            LambdaExpression orderByExpression = Expression.Lambda(propertyAccessExpression, param);

            string methodName = ascending ? "OrderBy" : "OrderByDescending";

            MethodCallExpression resultExp = Expression.Call(typeof(Queryable), methodName, new Type[] { type, property.PropertyType }, source.Expression, Expression.Quote(orderByExpression));

            return source.Provider.CreateQuery<T>(resultExp);
        }

        /// <summary>
        /// 获取对应的字段名
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static string GetMemberName<TSource, TKey>(Expression<Func<TSource, TKey>> keySelector)
        {
            string fieldName = null;
            var exp = keySelector.Body as UnaryExpression;
            if (exp == null)
            {
                var body = keySelector.Body as MemberExpression;
                fieldName = body.Member.Name;
            }
            else
            {
                fieldName = (exp.Operand as MemberExpression).Member.Name;
            }
            return fieldName;
        }
    }
    /// <summary>
    /// 统一ParameterExpression
    /// </summary>
    internal class ParameterReplacer : ExpressionVisitor
    {
        public ParameterReplacer(ParameterExpression paramExpr)
        {
            this.ParameterExpression = paramExpr;
        }

        public ParameterExpression ParameterExpression { get; private set; }

        public Expression Replace(Expression expr)
        {
            return this.Visit(expr);
        }

        protected override Expression VisitParameter(ParameterExpression p)
        {
            return this.ParameterExpression;
        }
    }
    public static class PredicateExtensionses
    {
        public static Expression<Func<T, bool>> True<T>() { return f => true; }

        public static Expression<Func<T, bool>> False<T>() { return f => false; }

        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> exp_left, Expression<Func<T, bool>> exp_right, params Expression<Func<T, bool>>[] exp_more)
        {
            var candidateExpr = Expression.Parameter(typeof(T), "candidate");
            var parameterReplacer = new ParameterReplacer(candidateExpr);

            var left = parameterReplacer.Replace(exp_left.Body);
            var right = parameterReplacer.Replace(exp_right.Body);
            var body = Expression.And(left, right);
            foreach (Expression<Func<T, bool>> temp in exp_more)
            {
                var tempCon = parameterReplacer.Replace(temp.Body);
                body = Expression.And(body, tempCon);
            }
            return Expression.Lambda<Func<T, bool>>(body, candidateExpr);
        }

        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> exp_left, Expression<Func<T, bool>> exp_right)
        {
            var candidateExpr = Expression.Parameter(typeof(T), "candidate");
            var parameterReplacer = new ParameterReplacer(candidateExpr);

            var left = parameterReplacer.Replace(exp_left.Body);
            var right = parameterReplacer.Replace(exp_right.Body);
            var body = Expression.Or(left, right);
            return Expression.Lambda<Func<T, bool>>(body, candidateExpr);
        }
    }
}
