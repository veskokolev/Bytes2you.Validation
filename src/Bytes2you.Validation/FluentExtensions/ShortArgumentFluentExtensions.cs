using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;

namespace Bytes2you.Validation
{
    public static class ShortArgumentFluentExtensions
    {
        public static IValidatableArgument<short> IsEqual(this IArgument<short> @argument, short value)
        {
            return @argument.AddValidationPredicate(new EqualValidationPredicate<short>(value));
        }

        public static IValidatableArgument<short> IsNotEqual(this IArgument<short> @argument, short value)
        {
            return @argument.AddValidationPredicate(new NotEqualValidationPredicate<short>(value));
        }

        public static IValidatableArgument<short> IsLessThan(this IArgument<short> @argument, short bound)
        {
            return @argument.AddValidationPredicate(new LessThanValidationPredicate<short>(bound));
        }

        public static IValidatableArgument<short> IsGreaterThan(this IArgument<short> @argument, short bound)
        {
            return @argument.AddValidationPredicate(new GreaterThanValidationPredicate<short>(bound));
        }

        public static IValidatableArgument<short> IsLessThanOrEqual(this IArgument<short> @argument, short bound)
        {
            return @argument.AddValidationPredicate(new LessThanOrEqualValidationPredicate<short>(bound));
        }

        public static IValidatableArgument<short> IsGreaterThanOrEqual(this IArgument<short> @argument, short bound)
        {
            return @argument.AddValidationPredicate(new GreaterThanOrEqualValidationPredicate<short>(bound));
        }
    }
}