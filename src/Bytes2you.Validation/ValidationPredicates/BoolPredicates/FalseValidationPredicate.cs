using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.BoolPredicates
{
    internal class FalseValidationPredicate : SingletonValidationPredicate<FalseValidationPredicate, bool>
    {
        private FalseValidationPredicate()
        {
        }

        protected override string GetMatchMessage(bool value)
        {
            return ValidationPredicateMessages.FalseMessage;
        }

        protected override string GetUnmatchMessage(bool value)
        {
            return ValidationPredicateMessages.TrueMessage;
        }

        protected override bool IsMatch(bool value)
        {
            return !value;
        }
    }
}