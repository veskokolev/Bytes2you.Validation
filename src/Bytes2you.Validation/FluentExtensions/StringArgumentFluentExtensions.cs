using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;

namespace Bytes2you.Validation
{
    public static class StringArgumentFluentExtensions
    {
        public static IValidatableArgument<string> IsNullOrEmpty(this IArgument<string> @argument)
        {
            return @argument.AddValidationPredicate(StringNullOrEmptyValidationPredicate.Instance);
        }

        public static IValidatableArgument<string> IsNotNullOrEmpty(this IArgument<string> @argument)
        {
            return @argument.AddValidationPredicate(StringNotNullOrEmptyValidationPredicate.Instance);
        }

        public static IValidatableArgument<string> IsEqual(this IArgument<string> @argument, string bound, StringComparison comparisonType)
        {
            return @argument.AddValidationPredicate(new StringEqualValidationPredicate(bound, comparisonType));
        }

        public static IValidatableArgument<string> IsNotEqual(this IArgument<string> @argument, string bound, StringComparison comparisonType)
        {
            return @argument.AddValidationPredicate(new StringNotEqualValidationPredicate(bound, comparisonType));
        }
    }
}