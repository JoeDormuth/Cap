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
    public class InSpecification<T1, T2> : Specification<T1> where T1 : class {

        private IEnumerable<T2> _list;
        private Func<T2, ISpecification<T1>> _specSelector;

        public InSpecification(IEnumerable<T2> list, Func<T2, ISpecification<T1>> specSelector) {
            _list = list;
            _specSelector = specSelector;
        }

        public override System.Linq.Expressions.Expression<Func<T1, bool>> SatisfiedBy() {
            ISpecification<T1> orList = new DirectSpecification<T1>(t => false);
            if (_list == null || !_list.Any())
                return orList.SatisfiedBy();

            foreach (var i in _list)
                orList = new OrSpecification<T1>(orList, _specSelector(i));

            return orList.SatisfiedBy();
        }
    }
}
