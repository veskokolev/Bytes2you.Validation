using System;
using System.Linq;
using Bytes2you.Validation.Extensions;

namespace Bytes2you.Validation
{
    public static class ValidatableArgumentFluentExtension
    {
        public static void Throw<T>(this IValidatableArgument<T> @validatableArgument)
        {
            if (@validatableArgument == null)
            {
                throw new ArgumentNullException("@validatableArgument");
            }

            string invalidArgumentMessage;
            if (validatableArgument.TryGetInvalidArgumentMessage(out invalidArgumentMessage))
            {
                throw new ArgumentException(invalidArgumentMessage, validatableArgument.Name);
            }
        }
    }
}