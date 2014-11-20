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
        
        public static IValidatableArgument<byte> IsEqual(this IArgument<byte> @argument, byte value)
        {
            return @argument.AddValidationPredicate(new EqualValidationPredicate<byte>(value));
        }

        public static IValidatableArgument<byte> IsNotEqual(this IArgument<byte> @argument, byte value)
        {
            return @argument.AddValidationPredicate(new NotEqualValidationPredicate<byte>(value));
        }

        public static IValidatableArgument<short> IsEqual(this IArgument<short> @argument, short value)
        {
            return @argument.AddValidationPredicate(new EqualValidationPredicate<short>(value));
        }

        public static IValidatableArgument<short> IsNotEqual(this IArgument<short> @argument, short value)
        {
            return @argument.AddValidationPredicate(new NotEqualValidationPredicate<short>(value));
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