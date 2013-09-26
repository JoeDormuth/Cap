#region "Imports"

#region "System Imports"
using System;
using System.Linq.Expressions;
#endregion

#endregion

namespace Capstone.Infrastructure.Data.Specification {
    public sealed class DirectSpecification<TEntity> : Specification<TEntity> where TEntity : class {

        private Expression<Func<TEntity, bool>> _matchCriteria;

        public DirectSpecification(Expression<Func<TEntity, bool>> matchCriteria) {
            if (matchCriteria == null) 
                throw new ArgumentNullException("Matching criteria is required and cannot be null.");
            _matchCriteria = matchCriteria;
        }

        public override Expression<Func<TEntity, bool>> SatisfiedBy() {
            return _matchCriteria;
        }
    }
}
