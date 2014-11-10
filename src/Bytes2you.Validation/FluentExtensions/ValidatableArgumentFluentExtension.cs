using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bytes2you.Validation
{
    public static class ValidatableArgumentFluentExtension
    {
        public static bool TryGetArgumentException<T>(this IValidatableArgument<T> @validatableArgument, out ArgumentException argumentException)
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

                argumentException = new ArgumentException(messageBuilder.ToString(), validatableArgument.Name);
            }
            else
            {
                argumentException = null;
            }

            return argumentException != null;
        }

        public static void Throw<T>(this IValidatableArgument<T> @validatableArgument)
        {
            if (@validatableArgument == null)
            {
                throw new ArgumentNullException("@validatableArgument");
            }

            ArgumentException argumentException = null;
            if (validatableArgument.TryGetArgumentException(out argumentException))
            {
                throw argumentException;
            }
        }
    }
}