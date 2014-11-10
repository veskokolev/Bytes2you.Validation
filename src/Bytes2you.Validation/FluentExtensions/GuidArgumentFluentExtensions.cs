using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationPredicates;

namespace Bytes2you.Validation
{
    public static class GuidArgumentFluentExtensions
    {
        public static IValidatableArgument<Guid> IsEmptyGuid(this IArgument<Guid> @argument)
        {
            return @argument.AddValidationPredicate(EmptyGuidValidationPredicate.Instance);
        }

        public static IValidatableArgument<Guid> IsNotEmptyGuid(this IArgument<Guid> @argument)
        {
            return @argument.AddValidationPredicate(NotEmptyGuidValidationPredicate.Instance);
        }
    }
}