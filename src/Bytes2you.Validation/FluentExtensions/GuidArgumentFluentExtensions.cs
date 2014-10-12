using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationRules;

namespace Bytes2you.Validation
{
    public static class GuidArgumentFluentExtensions
    {
        public static IValidatableArgument<Guid> IsEmptyGuid(this IArgument<Guid> @argument)
        {
            return @argument.AddValidationRule(EmptyGuidValidationRule.Instance);
        }

        public static IValidatableArgument<Guid> IsNotEmptyGuid(this IArgument<Guid> @argument)
        {
            return @argument.AddValidationRule(NotEmptyGuidValidationRule.Instance);
        }
    }
}