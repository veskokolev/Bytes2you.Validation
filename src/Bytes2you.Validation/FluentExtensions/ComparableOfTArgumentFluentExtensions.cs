using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationRules;

namespace Bytes2you.Validation
{
    public static class ComparableOfTArgumentFluentExtensions
    {
        public static IValidatableArgument<T> IsLessThan<T>(this IArgument<T> @argument, T bound)
            where T : IComparable<T>
        {
            return @argument.AddValidationRule(new LessThanValidationRule<T>(bound));
        }

        public static IValidatableArgument<T> IsGreaterThan<T>(this IArgument<T> @argument, T bound)
            where T : IComparable<T>
        {
            return @argument.AddValidationRule(new GreaterThanValidationRule<T>(bound));
        }

        public static IValidatableArgument<T> IsLessThanOrEqual<T>(this IArgument<T> @argument, T bound)
            where T : IComparable<T>
        {
            return @argument.AddValidationRule(new LessThanOrEqualValidationRule<T>(bound));
        }

        public static IValidatableArgument<T> IsGreaterThanOrEqual<T>(this IArgument<T> @argument, T bound)
            where T : IComparable<T>
        {
            return @argument.AddValidationRule(new GreaterThanOrEqualValidationRule<T>(bound));
        }
    }
}