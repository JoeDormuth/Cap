#region "Imports"

#region "System Imports"
using System;
#endregion

#region "Capstone Imports"
using Capstone.Infrastructure.Data.Interface;
#endregion

#endregion

namespace Capstone.Infrastructure.Data.Specification {
    /// <summary>
    /// Base class for composite specs
    /// </summary>
    public abstract class CompositeSpecification<TEntity> : Specification<TEntity> where TEntity : class {
        /// <summary>
        /// Left side spec in question
        /// </summary>
        public abstract ISpecification<TEntity> LeftSideSpecification { get; }
        /// <summary>
        /// Right side spec in question
        /// </summary>
        public abstract ISpecification<TEntity> RightSideSpecification { get; }
    }
}
