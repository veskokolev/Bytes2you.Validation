using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates;

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

        public static IValidatableArgument<byte> IsLessThan(this IArgument<byte> @argument, byte bound)
        {
            return @argument.AddValidationPredicate(new LessThanValidationPredicate<byte>(bound));
        }

        public static IValidatableArgument<byte> IsGreaterThan(this IArgument<byte> @argument, byte bound)
        {
            return @argument.AddValidationPredicate(new GreaterThanValidationPredicate<byte>(bound));
        }

        public static IValidatableArgument<byte> IsLessThanOrEqual(this IArgument<byte> @argument, byte bound)
        {
            return @argument.AddValidationPredicate(new LessThanOrEqualValidationPredicate<byte>(bound));
        }

        public static IValidatableArgument<byte> IsGreaterThanOrEqual(this IArgument<byte> @argument, byte bound)
        {
            return @argument.AddValidationPredicate(new GreaterThanOrEqualValidationPredicate<byte>(bound));
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