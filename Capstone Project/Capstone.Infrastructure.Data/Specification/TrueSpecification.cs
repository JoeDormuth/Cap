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
    public sealed class TrueSpecification<T> : Specification<T> where T : class {

        public override Expression<Func<T, bool>> SatisfiedBy() {
            Expression<Func<T, bool>> trueExp = t => true;
            return trueExp;
        }
    }
}
