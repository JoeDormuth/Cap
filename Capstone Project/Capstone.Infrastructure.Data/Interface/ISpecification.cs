#region "Imports"

#region "System Imports"
using System;
using System.Linq;
using System.Linq.Expressions;
#endregion

#endregion

namespace Capstone.Infrastructure.Data.Interface {
    /// <summary>
    /// Base contract for specification pattern
    /// </summary>
    public interface ISpecification<TEntity> where TEntity : class {
        /// <summary>
        /// Checkes if the spec is satisfied by the expression
        /// </summary>
        /// <returns></returns>
        Expression<Func<TEntity, bool>> SatisfiedBy();
    }
}
