#region "Imports"

#region "System Imports"
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
#endregion

#region "Capstone Imports"
using Capstone.Infrastructure.Data.Interface;
#endregion

#endregion

namespace Capstone.Infrastructure.Data.Specification {
    public class AndAllSpecification<TEntity> : Specification<TEntity> where TEntity : class {
        private IEnumerable<ISpecification<TEntity>> _specifications;

        public AndAllSpecification(IEnumerable<ISpecification<TEntity>> specifications) {
            _specifications = specifications;
        }

        public override System.Linq.Expressions.Expression<Func<TEntity, bool>> SatisfiedBy() {
            ISpecification<TEntity> finalSpec = new DirectSpecification<TEntity>(t => true);
            if (_specifications == null || !_specifications.Any())
                return new DirectSpecification<TEntity>(t => false).SatisfiedBy();

            foreach (var i in _specifications)
                finalSpec = new AndSpecification<TEntity>(finalSpec, i);

            return finalSpec.SatisfiedBy();
        }
    }
}
