using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationRules;

namespace Bytes2you.Validation
{
    public static class ArgumentOfTFluentExtensions
    {
        public static IValidatableArgument<T> IsEqual<T>(this IArgument<T> @argument, T value)
        {
            return @argument.AddValidationRule(new EqualValidationRule<T>(value));
        }

        public static IValidatableArgument<T> IsNotEqual<T>(this IArgument<T> @argument, T value)
        {
            return @argument.AddValidationRule(new NotEqualValidationRule<T>(value));
        }

        public static IValidatableArgument<T> IsNull<T>(this IArgument<T> @argument)
            where T : class
        {
            return @argument.AddValidationRule(NullValidationRule<T>.Instance);
        }

        public static IValidatableArgument<T> IsNotNull<T>(this IArgument<T> @argument)
            where T : class
        {
            return @argument.AddValidationRule(NotNullValidationRule<T>.Instance);
        }
    }
}