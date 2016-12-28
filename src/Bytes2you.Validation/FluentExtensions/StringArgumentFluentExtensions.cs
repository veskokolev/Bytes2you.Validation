using System;
using System.Linq;
using System.Text.RegularExpressions;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.StringPredicates;

namespace Bytes2you.Validation
{
    public static class StringArgumentFluentExtensions
    {
        public static IValidatableArgument<string> IsEmpty(this IArgument<string> @argument)
        {
            return @argument.AddValidationPredicate(StringEmptyValidationPredicate.Instance);
        }

        public static IValidatableArgument<string> IsNotEmpty(this IArgument<string> @argument)
        {
            return @argument.AddValidationPredicate(StringNotEmptyValidationPredicate.Instance);
        }

        public static IValidatableArgument<string> IsNullOrEmpty(this IArgument<string> @argument)
        {
            return @argument.AddValidationPredicate(StringNullOrEmptyValidationPredicate.Instance);
        }

        public static IValidatableArgument<string> IsNotNullOrEmpty(this IArgument<string> @argument)
        {
            return @argument.AddValidationPredicate(StringNotNullOrEmptyValidationPredicate.Instance);
        }

        public static IValidatableArgument<string> IsNullOrWhiteSpace(this IArgument<string> @argument)
        {
            return @argument.AddValidationPredicate(StringNullOrWhiteSpaceValidationPredicate.Instance);
        }

        public static IValidatableArgument<string> IsNotNullOrWhiteSpace(this IArgument<string> @argument)
        {
            return @argument.AddValidationPredicate(StringNotNullOrWhiteSpaceValidationPredicate.Instance);
        }

        public static IValidatableArgument<string> IsEqual(this IArgument<string> @argument, string value, StringComparison comparisonType)
        {
            return @argument.AddValidationPredicate(new StringEqualValidationPredicate(value, comparisonType));
        }

        public static IValidatableArgument<string> IsNotEqual(this IArgument<string> @argument, string value, StringComparison comparisonType)
        {
            return @argument.AddValidationPredicate(new StringNotEqualValidationPredicate(value, comparisonType));
        }

        public static IValidatableArgument<string> IsRegexMatch(this IArgument<string> @argument, string pattern)
        {
            return @argument.AddValidationPredicate(new StringRegexMatchValidationPredicate(pattern));
        }

        public static IValidatableArgument<string> IsNotRegexMatch(this IArgument<string> @argument, string pattern)
        {
            return @argument.AddValidationPredicate(new StringNotRegexMatchValidationPredicate(pattern));
        }
    }
}