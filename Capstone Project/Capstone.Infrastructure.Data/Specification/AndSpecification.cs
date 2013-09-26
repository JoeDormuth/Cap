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
    
    public sealed class AndSpecification<TEntity> : CompositeSpecification<TEntity> where TEntity : class {

        private ISpecification<TEntity> _leftSideSpecification = null;
        private ISpecification<TEntity> _rightSideSpecification = null;


        public AndSpecification(ISpecification<TEntity> leftSide, ISpecification<TEntity> rightSide) {
            if (leftSide == null || rightSide == null)
                throw new ArgumentNullException("Either side of the specification cannot be null");

            _leftSideSpecification = leftSide;
            _rightSideSpecification = rightSide;
        }



        public override ISpecification<TEntity> LeftSideSpecification {
            get { return _leftSideSpecification; }
        }

        public override ISpecification<TEntity> RightSideSpecification {
            get { return _rightSideSpecification; }
        }

        public override Expression<Func<TEntity, bool>> SatisfiedBy() {
            Expression<Func<TEntity, bool>> left = _leftSideSpecification.SatisfiedBy();
            Expression<Func<TEntity, bool>> right = _rightSideSpecification.SatisfiedBy();
            return (left.And(right));
        }
        
    }
}
