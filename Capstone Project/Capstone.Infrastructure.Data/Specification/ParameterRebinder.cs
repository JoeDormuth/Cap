﻿#region "Imports"

#region "System Imports"
using System.Linq.Expressions;
using System.Collections.Generic;
#endregion

#endregion

namespace Capstone.Infrastructure.Data.Specification {
    public sealed class ParameterRebinder : ExpressionVisitor {
        private readonly Dictionary<ParameterExpression, ParameterExpression> map;


        public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map) {
            this.map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
        }


        public static Expression ReplaceParamters(Dictionary<ParameterExpression, ParameterExpression> map, Expression exp) {
            return new ParameterRebinder(map).Visit(exp);
        }

        protected override Expression VisitParameter(ParameterExpression node) {
            ParameterExpression replacement;
            if (map.TryGetValue(node, out replacement)) {
                node = replacement;
            }

            return base.VisitParameter(node);
        }
    }
}
