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

            IEnumerable<IValidationPredicateResult> matchingValidationPredicateResults = 
                validatableArgument.MatchValidationPredicates().Where(vp => vp.IsMatch);

            if (matchingValidationPredicateResults.Any())
            {
                StringBuilder messageBuilder = new StringBuilder("Invalid argument:\n");

                foreach (IValidationPredicateResult validationPredicateResult in matchingValidationPredicateResults)
                {
                    messageBuilder.AppendLine(string.Format(" - {0}", validationPredicateResult.Message));
                }

                throw new ArgumentException(messageBuilder.ToString(), validatableArgument.Name);
            }
        }
    }
}