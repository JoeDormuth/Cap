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
    /// <summary>
    /// Specification base class
    /// </summary>
    public abstract class Specification<TEntity> : ISpecification<TEntity> where TEntity : class {

        #region "ISpecification Implementation"
        public abstract Expression<Func<TEntity, bool>> SatisfiedBy();
        #endregion

        #region "Operator Overrides"
        
        /// <summary>
        /// Overrides the & operator
        /// </summary>
        public static Specification<TEntity> operator &(Specification<TEntity> leftSpec, Specification<TEntity> rightSpec) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Overrides the | operator
        /// </summary>
        public static Specification<TEntity> operator |(Specification<TEntity> leftSpec, Specification<TEntity> rightSpec) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Not specification
        /// </summary>
        public static Specification<TEntity> operator !(Specification<TEntity> specification) {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Override operator false, only for support AND OR operators
        /// </summary>
        public static bool operator false(Specification<TEntity> specification) {
            return false;
        }

        /// <summary>
        /// Override operator True, only for support AND OR operators
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "specification")]
        public static bool operator true(Specification<TEntity> specification) {
            return true;
        }
        #endregion
    }
}
