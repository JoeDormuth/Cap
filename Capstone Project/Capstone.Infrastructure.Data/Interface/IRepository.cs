#region "Imports"

#region "System Imports"
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
#endregion

#region "Capstone Imports"
using Capstone.Infrastructure.Data.EF;
#endregion

#endregion

namespace Capstone.Infrastructure.Data.Interface {
    public interface IRepository<TEntity> where TEntity : class {

        IUnitOfWork DbContext { get; }

        void Add(TEntity _item);
        void Remove(TEntity _item);
        void TrackItem(TEntity _item);
        void Modify(TEntity _item);



        /// <summary>
        /// Returns all elements
        /// </summary>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Gets items by specification
        /// </summary>
        IEnumerable<TEntity> GetBySpecification(ISpecification<TEntity> spec);
        /// <summary>
        /// Gets paginated elemnts
        /// </summary>
        IEnumerable<TEntity> GetPagedElements<S>(int pageIndex, int pageCount, Expression<Func<TEntity, S>> orderBy, bool ascending);
        /// <summary>
        /// Gets paginated elements based on a specification filter
        /// </summary>
        IEnumerable<TEntity> GetPagedElements<S>(int pageIndex, int pageCount, Expression<Func<TEntity, S>> orderBy, ISpecification<TEntity> specification, bool ascending);
        /// <summary>
        /// Gets elements by an expression
        /// </summary>
        IEnumerable<TEntity> GetByExpression(Expression<Func<TEntity, bool>> where);
    }
}
