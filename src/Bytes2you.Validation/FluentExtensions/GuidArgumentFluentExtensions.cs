using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates.GuidPredicates;

namespace Bytes2you.Validation
{
    public static class GuidArgumentFluentExtensions
    {
        public static IValidatableArgument<Guid> IsEmptyGuid(this IArgument<Guid> @argument)
        {
            return @argument.AddValidationPredicate(GuidEmptyValidationPredicate.Instance);
        }

        public static IValidatableArgument<Guid> IsNotEmptyGuid(this IArgument<Guid> @argument)
        {
            return @argument.AddValidationPredicate(GuidNotEmptyValidationPredicate.Instance);
        }
    }
}