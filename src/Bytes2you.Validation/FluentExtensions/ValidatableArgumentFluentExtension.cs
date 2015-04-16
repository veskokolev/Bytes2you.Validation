using System;
using System.Linq;

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

            IValidationPredicateResult firstPredicateMatch =
                validatableArgument.MatchValidationPredicates().Where(vp => vp.IsMatch).FirstOrDefault();

            if (firstPredicateMatch == null)
            {
                argumentException = null;
                return false;
            }

            if (firstPredicateMatch.ValidationType == ValidationType.Range)
            {
                argumentException = new ArgumentOutOfRangeException(@validatableArgument.Name, firstPredicateMatch.Message);
            }
            else
            {
                if (validatableArgument.Value == null)
                {
                    argumentException = new ArgumentNullException(@validatableArgument.Name, firstPredicateMatch.Message);
                }
                else
                {
                    argumentException = new ArgumentException(firstPredicateMatch.Message, @validatableArgument.Name);
                }
            }

            return true;
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