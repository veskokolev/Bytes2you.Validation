using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates;

namespace Bytes2you.Validation
{
    public static class NullableArgumentFluentExtensions
    {
        public static IValidatableArgument<Nullable<T>> IsNull<T>(this IArgument<Nullable<T>> @argument)
            where T : struct
        {
            return @argument.AddValidationPredicate(NullNullableValidationPredicate<T>.Instance);
        }

        public static IValidatableArgument<Nullable<T>> IsNotNull<T>(this IArgument<Nullable<T>> @argument)
            where T : struct
        {
            return @argument.AddValidationPredicate(NotNullNullableValidationPredicate<T>.Instance);
        }
    }
}