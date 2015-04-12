using System;
using System.Linq;

namespace Bytes2you.Validation.Extensions
{
    public static class ArgumentExtensions
    {
        internal static IValidatableArgument<T> ToValidatableArgument<T>(this IArgument<T> @argument)
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

        public static IValidatableArgument<T> AddValidationPredicate<T>(this IArgument<T> @argument, IValidationPredicate<T> validationPredicate)
        {
            if (@argument == null)
            {
                throw new ArgumentNullException("@argument");
            }

            if (validationPredicate == null)
            {
                throw new ArgumentNullException("validationPredicate");
            }

            IValidatableArgument<T> validatableArgument = @argument.ToValidatableArgument();
            validatableArgument.AddValidationPredicate(validationPredicate);

            return validatableArgument;
        }
    }
}