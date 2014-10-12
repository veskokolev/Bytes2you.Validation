using System;
using System.Linq;

namespace Bytes2you.Validation.Extensions
{
    internal static class ArgumentExtensions
    {
        public static ValidatableArgument<T> ToValidatableArgument<T>(this IArgument<T> @argument)
        {
            if (@argument == null)
            {
                throw new ArgumentNullException("@argument");
            }

            ValidatableArgument<T> validatableArgument = @argument as ValidatableArgument<T>;
            if (validatableArgument == null)
            {
                validatableArgument = new ValidatableArgument<T>(@argument);
            }

            return validatableArgument;
        }

        public static ValidatableArgument<T> AddValidationRule<T>(this IArgument<T> @argument, IValidationRule<T> validationRule)
        {
            if (@argument == null)
            {
                throw new ArgumentNullException("@argument");
            }

            if (validationRule == null)
            {
                throw new ArgumentNullException("validationRule");
            }

            ValidatableArgument<T> validatableArgument = @argument.ToValidatableArgument();
            validatableArgument.AddValidationRule(validationRule);

            return validatableArgument;
        }
    }
}