#region "Imports"

#region "System Imports"
using System;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Data.Objects;
using System.Globalization;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
#endregion

#region "Capstone Imports"
using Capstone.Infrastructure.Data.Interface;
using Capstone.Infrastructure.Data.EF;
#endregion

#region "External Imports"
using log4net;
#endregion

#endregion

namespace Capstone.Infrastructure.Data {
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class {
        // Logging Mechanism
        private static readonly ILog Log = LogManager.GetLogger(typeof(BaseRepository<TEntity>));
        // Unit of Work
        private IUnitOfWork _context = null;

        #region "Constructor"
        public BaseRepository(IUnitOfWork dbContext) {
            if (dbContext == null) {
                Log.Debug("Context Injection failed :(");
                throw new ArgumentNullException("Db Context was null, injection failed");
            }

            _context = dbContext;
        }
        #endregion


        #region "IRepository Implementation"

        public IUnitOfWork DbContext {
            get { return _context; }
        }

        
        public virtual void Add(TEntity _item) {
            if (_item != null) 
                GetSet().Add(_item);
        }

        
        public virtual void Remove(TEntity _item) {
            if (_item != null)
                GetSet().Remove(_item);
        }

        
        public virtual void TrackItem(TEntity _item) {
            if (_item != null)
                _context.Attach<TEntity>(_item);
        }

        
        public virtual void Modify(TEntity _item) {
            if (_item != null)
                _context.SetModified<TEntity>(_item);
        }

        
        public virtual IEnumerable<TEntity> GetAll() {
            return (GetSet()).AsEnumerable<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetBySpecification(ISpecification<TEntity> spec) {
            if (spec == null)
                throw new ArgumentNullException("Specification cannot be null");

            return (GetSet().Where(spec.SatisfiedBy()).AsEnumerable<TEntity>());
        }
        
        public virtual IEnumerable<TEntity> GetPagedElements<S>(int pageIndex, int pageCount, Expression<Func<TEntity, S>> orderBy, bool ascending) {
            return (GetSet()).Paginate<TEntity, S>(orderBy, pageIndex, pageCount, ascending);
        }

        
        public virtual IEnumerable<TEntity> GetPagedElements<S>(int pageIndex, int pageCount, Expression<Func<TEntity, S>> orderBy, ISpecification<TEntity> specification, bool ascending) {
            var objectSet = GetSet();

            //this query cannot  use Paginate IQueryable extension method because Linq queries cannot be
            //merged with Object Builder methods. See Entity Framework documentation for more information

            return (ascending)
                                ?
                                    objectSet
                                     .Where(specification.SatisfiedBy())
                                     .OrderBy(orderBy)
                                     .Skip(pageIndex * pageCount)
                                     .Take(pageCount)
                                     .ToList()
                                :
                                    objectSet
                                     .Where(specification.SatisfiedBy())
                                     .OrderByDescending(orderBy)
                                     .Skip(pageIndex * pageCount)
                                     .Take(pageCount)
                                     .ToList();
        }

        public virtual IEnumerable<TEntity> GetByExpression(Expression<Func<TEntity, bool>> expression)
        {
            return (GetSet()).Where(expression).AsEnumerable();
        }
        #endregion



        #region "Private"

        /// <summary>
        /// Gets and object set of the current type
        /// </summary>
        private IDbSet<TEntity> GetSet() {
            return _context.CreateSet<TEntity>();
        }
        #endregion

    }
}
