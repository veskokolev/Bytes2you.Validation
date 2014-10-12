using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

            List<IValidationResult> invalidValidationResults = new List<IValidationResult>();
            foreach (IValidationRule<T> validationRule in @validatableArgument.ValidationRules)
            {
                IValidationResult validationResult = validationRule.Validate(@validatableArgument.Value);
                if (validationResult.IsValid)
                {
                    invalidValidationResults.Add(validationResult);
                }
            }

            if (invalidValidationResults.Count > 0)
            {
                StringBuilder messageBuilder = new StringBuilder("Invalid argument:\n");
                
                foreach (IValidationResult validationResult in invalidValidationResults)
                {
                    messageBuilder.AppendLine(string.Format(" - {0}", validationResult.Message));
                }

                throw new ArgumentException(messageBuilder.ToString(), validatableArgument.Name);
            }
        }
    }
}