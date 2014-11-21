using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates;

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
    }
}