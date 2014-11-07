using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bytes2you.Validation.Extensions
{
    public static class ValidatableArgumentExtensions
    {
        public static bool TryGetInvalidArgumentMessage<T>(this IValidatableArgument<T> @validatableArgument, out string invalidArgumentMessage)
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

                invalidArgumentMessage = messageBuilder.ToString();
            }
            else
            {
                invalidArgumentMessage = string.Empty;
            }

            return !string.IsNullOrEmpty(invalidArgumentMessage);
        }
    }
}