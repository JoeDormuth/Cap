#region "Imports"

#region "System Imports"
using System;
using System.Linq.Expressions;
#endregion

#region "Capstone Imports"
using Capstone.Infrastructure.Data.Interface;
#endregion

#endregion

namespace Capstone.Infrastructure.Data.Specification {
    public sealed class OrSpecification<T> : CompositeSpecification<T> where T : class {
        private ISpecification<T> _leftSideSpec = null;
        private ISpecification<T> _rightSideSpec = null;

        public OrSpecification(ISpecification<T> leftSideSpec, ISpecification<T> rightSideSpec) {
            if (leftSideSpec == null || rightSideSpec == null)
                throw new ArgumentNullException("Left or right side specification cannot be null");

            _leftSideSpec = leftSideSpec;
            _rightSideSpec = rightSideSpec;
        }

        public override ISpecification<T> LeftSideSpecification {
            get { return _leftSideSpec; }
        }
        public override ISpecification<T> RightSideSpecification {
            get { return _rightSideSpec; }
        }

        public override Expression<Func<T, bool>> SatisfiedBy() {
            Expression<Func<T, bool>> left = _leftSideSpec.SatisfiedBy();
            Expression<Func<T, bool>> right = _rightSideSpec.SatisfiedBy();
            return (left.Or(right));
        }
    }
}
