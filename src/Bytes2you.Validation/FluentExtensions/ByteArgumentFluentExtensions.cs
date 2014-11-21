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
    }
}