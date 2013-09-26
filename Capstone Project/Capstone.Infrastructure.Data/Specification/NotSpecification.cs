#region "Imports"

#region "System Imports"
using System;
using System.Linq;
using System.Linq.Expressions;
#endregion

#region "Capstone Imports"
using Capstone.Infrastructure.Data.Interface;
#endregion

#endregion

namespace Capstone.Infrastructure.Data.Specification {
    public sealed class NotSpecification<T> : Specification<T> where T : class {
        private Expression<Func<T, bool>> _criteria;

        public NotSpecification(ISpecification<T> originalSpec) {
            if (originalSpec == null)
                throw new ArgumentNullException("Original Specification cannot be null");
            _criteria = originalSpec.SatisfiedBy();
        }

        public NotSpecification(Expression<Func<T, bool>> originalSpec) {
            if (originalSpec == null)
                throw new ArgumentNullException();
            _criteria = originalSpec;
        }


        public override Expression<Func<T, bool>> SatisfiedBy() {
            return Expression.Lambda<Func<T, bool>>(Expression.Not(_criteria.Body), _criteria.Parameters.Single());
        }
    }
}
