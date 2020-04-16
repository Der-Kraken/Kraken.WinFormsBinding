using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Kraken.WinFormsBinding.Tools
{
    public static class TypeSafeMagicStrings
    {
        /// <summary>
        /// Returns the property path as a magic string separated by dots.
        /// </summary>
        public static string GetPropertyPath<T>(Expression<Func<T, object>> expression)
        {
            if (expression is null) throw new ArgumentNullException(nameof(expression));

            return GetPropertyPath((MemberExpression)expression.Body);
        }

        private static string GetPropertyPath(MemberExpression expression)
        {
            if (expression is null) throw new ArgumentNullException(nameof(expression));

            var parts = new List<string>();

            while (expression != null)
            {
                parts.Add(expression.Member.Name);
                expression = expression.Expression as MemberExpression;
            }

            parts.Reverse();
            return string.Join(".", parts);
        }
    }
}
