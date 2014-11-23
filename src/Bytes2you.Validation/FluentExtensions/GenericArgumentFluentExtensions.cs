using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.GenericPredicates;

namespace Bytes2you.Validation
{
    public static class GenericArgumentFluentExtensions
    {
        public static IValidatableArgument<T> IsEqual<T>(this IArgument<T> @argument, T value)
        {
            return @argument.AddValidationPredicate(new EqualValidationPredicate<T>(value));
        }

        public static IValidatableArgument<T> IsNotEqual<T>(this IArgument<T> @argument, T value)
        {
            return @argument.AddValidationPredicate(new NotEqualValidationPredicate<T>(value));
        }
    }
}