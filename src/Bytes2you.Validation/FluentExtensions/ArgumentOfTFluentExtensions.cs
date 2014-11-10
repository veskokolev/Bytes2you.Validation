using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates;

namespace Bytes2you.Validation
{
    public static class ArgumentOfTFluentExtensions
    {
        public static IValidatableArgument<T> IsEqual<T>(this IArgument<T> @argument, T value)
        {
            return @argument.AddValidationPredicate(new EqualValidationPredicate<T>(value));
        }

        public static IValidatableArgument<T> IsNotEqual<T>(this IArgument<T> @argument, T value)
        {
            return @argument.AddValidationPredicate(new NotEqualValidationPredicate<T>(value));
        }

        public static IValidatableArgument<T> IsNull<T>(this IArgument<T> @argument)
            where T : class
        {
            return @argument.AddValidationPredicate(NullValidationPredicate<T>.Instance);
        }

        public static IValidatableArgument<T> IsNotNull<T>(this IArgument<T> @argument)
            where T : class
        {
            return @argument.AddValidationPredicate(NotNullValidationPredicate<T>.Instance);
        }
    }
}