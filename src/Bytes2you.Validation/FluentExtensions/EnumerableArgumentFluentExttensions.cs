using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationRules;

namespace Bytes2you.Validation
{
    public static class EnumerableArgumentFluentExttensions
    {
        public static IValidatableArgument<T> IsNullOrEmpty<T>(this IArgument<T> @argument)
            where T : IEnumerable
        {
            return @argument.AddValidationRule(NullOrEmptyEnumerableValidationRule<T>.Instance);
        }

        public static IValidatableArgument<T> IsNotNullOrEmpty<T>(this IArgument<T> @argument)
            where T : IEnumerable
        {
            return @argument.AddValidationRule(NotNullOrEmptyEnumerableValidationRule<T>.Instance);
        }
    }
}