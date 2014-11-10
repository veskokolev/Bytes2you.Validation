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

        public static ValidatableArgument<T> AddValidationPredicate<T>(this IArgument<T> @argument, IValidationPredicate<T> validationPredicate)
        {
            if (@argument == null)
            {
                throw new ArgumentNullException("@argument");
            }

            if (validationPredicate == null)
            {
                throw new ArgumentNullException("validationPredicate");
            }

            ValidatableArgument<T> validatableArgument = @argument.ToValidatableArgument();
            validatableArgument.AddValidationPredicate(validationPredicate);

            return validatableArgument;
        }
    }
}