using System;
using System.Linq;
using Bytes2you.Validation.Extensions;
using Bytes2you.Validation.ValidationRules;

namespace Bytes2you.Validation
{
    public static class BoolArgumentFluentExtensions
    {
        public static IValidatableArgument<bool> IsTrue(this IArgument<bool> @argument)
        {
            return @argument.AddValidationRule(TrueValidationRule.Instance);
        }

        public static IValidatableArgument<bool> IsFalse(this IArgument<bool> @argument)
        {
            return @argument.AddValidationRule(FalseValidationRule.Instance);
        }
    }
}