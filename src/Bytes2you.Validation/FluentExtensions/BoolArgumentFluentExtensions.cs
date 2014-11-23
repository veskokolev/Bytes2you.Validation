using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.BoolPredicates;

namespace Bytes2you.Validation
{
    public static class BoolArgumentFluentExtensions
    {
        public static IValidatableArgument<bool> IsTrue(this IArgument<bool> @argument)
        {
            return @argument.AddValidationPredicate(TrueValidationPredicate.Instance);
        }

        public static IValidatableArgument<bool> IsFalse(this IArgument<bool> @argument)
        {
            return @argument.AddValidationPredicate(FalseValidationPredicate.Instance);
        }
    }
}