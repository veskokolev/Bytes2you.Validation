using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates;

namespace Bytes2you.Validation
{
    public static class StringArgumentFluentExtensions
    {
        public static IValidatableArgument<string> IsNullOrEmpty(this IArgument<string> @argument)
        {
            return @argument.AddValidationPredicate(NullOrEmptyStringValidationPredicate.Instance);
        }

        public static IValidatableArgument<string> IsNotNullOrEmpty(this IArgument<string> @argument)
        {
            return @argument.AddValidationPredicate(NotNullOrEmptyStringValidationPredicate.Instance);
        }
    }
}