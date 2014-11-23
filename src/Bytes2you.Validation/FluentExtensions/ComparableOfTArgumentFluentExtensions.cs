using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.ComparablePredicates;

namespace Bytes2you.Validation
{
    public static class ComparableOfTArgumentFluentExtensions
    {
        public static IValidatableArgument<T> IsLessThan<T>(this IArgument<T> @argument, T bound)
            where T : IComparable<T>
        {
            return @argument.AddValidationPredicate(new LessThanValidationPredicate<T>(bound));
        }

        public static IValidatableArgument<T> IsGreaterThan<T>(this IArgument<T> @argument, T bound)
            where T : IComparable<T>
        {
            return @argument.AddValidationPredicate(new GreaterThanValidationPredicate<T>(bound));
        }

        public static IValidatableArgument<T> IsLessThanOrEqual<T>(this IArgument<T> @argument, T bound)
            where T : IComparable<T>
        {
            return @argument.AddValidationPredicate(new LessThanOrEqualValidationPredicate<T>(bound));
        }

        public static IValidatableArgument<T> IsGreaterThanOrEqual<T>(this IArgument<T> @argument, T bound)
            where T : IComparable<T>
        {
            return @argument.AddValidationPredicate(new GreaterThanOrEqualValidationPredicate<T>(bound));
        }
    }
}