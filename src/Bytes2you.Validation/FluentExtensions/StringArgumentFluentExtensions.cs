using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationRules;

namespace Bytes2you.Validation
{
    public static class StringArgumentFluentExtensions
    {
        public static IValidatableArgument<string> IsNullOrEmpty(this IArgument<string> @argument)
        {
            return @argument.AddValidationRule(NullOrEmptyStringValidationRule.Instance);
        }

        public static IValidatableArgument<string> IsNotNullOrEmpty(this IArgument<string> @argument)
        {
            return @argument.AddValidationRule(NotNullOrEmptyStringValidationRule.Instance);
        }
    }
}