using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationRules;

namespace Bytes2you.Validation
{
    public static class EnumerableArgumentFluentExttensions
    {
        public static IValidatableArgument<IEnumerable> IsNullOrEmpty(this IArgument<IEnumerable> @argument)
        {
            return @argument.AddValidationRule(NullOrEmptyEnumerableValidationRule.Instance);
        }

        public static IValidatableArgument<IEnumerable> IsNotNullOrEmpty(this IArgument<IEnumerable> @argument)
        {
            return @argument.AddValidationRule(NotNullOrEmptyEnumerableValidationRule.Instance);
        }
    }
}