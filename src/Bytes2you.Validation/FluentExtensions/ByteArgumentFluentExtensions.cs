using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates;

namespace Bytes2you.Validation
{
    public static class ByteArgumentFluentExtensions
    {
        public static IValidatableArgument<byte> IsEqual(this IArgument<byte> @argument, byte value)
        {
            return @argument.AddValidationPredicate(new EqualValidationPredicate<byte>(value));
        }

        public static IValidatableArgument<byte> IsNotEqual(this IArgument<byte> @argument, byte value)
        {
            return @argument.AddValidationPredicate(new NotEqualValidationPredicate<byte>(value));
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
    }
}