﻿using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Objects;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Infrastructure.Data {
    public static class IQueryableExtensions {



        /// <summary>
        /// Paginate query in a specific page range
        /// </summary>
        /// <typeparam name="TEntity">Typeof entity in underlying query</typeparam>
        /// <typeparam name="S">Typeof ordered data value</typeparam>
        /// <param name="queryable">Query to paginate</param>
        /// <param name="orderBy">Order by expression used in paginate method
        /// <remarks>
        /// At this moment Order by expression only support simple order by c=>c.CustomerCode. If you need
        /// add more complex order functionality don't use this extension method
        /// </remarks>
        /// </param>
        /// <param name="pageIndex">Page index</param>
        /// <param name="pageCount">Page count</param>
        /// <param name="ascending">order direction</param>
        /// <returns>A paged queryable</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        public static IQueryable<TEntity> Paginate<TEntity, S>(this IQueryable<TEntity> queryable, Expression<Func<TEntity, S>> orderBy, int pageIndex, int pageCount, bool ascending)
            where TEntity : class {
            ObjectQuery<TEntity> query = queryable as ObjectQuery<TEntity>;

            if (query != null) {
                //this paginate method use ESQL for solve problems with Parametrized queries
                //in L2E and Skip/Take methods

                string orderPath = AnalyzeExpressionPath<TEntity, S>(orderBy);

                return query.Skip(string.Format(CultureInfo.InvariantCulture, "it.{0} {1}", orderPath, (ascending) ? "asc" : "desc"), "@skip", new ObjectParameter("skip", (pageIndex) * pageCount))
                            .Top("@limit", new ObjectParameter("limit", pageCount));

            } else // for In-Memory object set
                return queryable.OrderBy(orderBy).Skip((pageIndex * pageCount)).Take(pageCount);
        }


        static string AnalyzeExpressionPath<TEntity, S>(Expression<Func<TEntity, S>> expression) where TEntity : class {
            if (expression == (Expression<Func<TEntity, S>>)null)
                throw new ArgumentNullException("Expression not valid or null");

            MemberExpression body = expression.Body as MemberExpression;
            if (
                    (
                    (body == null)
                    ||
                    !body.Member.DeclaringType.IsAssignableFrom(typeof(TEntity))
                    )
                    ||
                    (body.Expression.NodeType != ExpressionType.Parameter)) {
                throw new ArgumentException("Path not valid");
            } else
                return body.Member.Name;
        }
    } 
}
