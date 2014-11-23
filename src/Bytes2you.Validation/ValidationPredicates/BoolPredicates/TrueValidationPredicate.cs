using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.BoolPredicates
{
    internal class TrueValidationPredicate : SingletonValidationPredicate<TrueValidationPredicate, bool>
    {
        private TrueValidationPredicate()
        {
        }

        protected override string GetMatchMessage(bool value)
        {
            return ValidationPredicateMessages.TrueMessage;
        }

        protected override string GetUnmatchMessage(bool value)
        {
            return ValidationPredicateMessages.FalseMessage;
        }

        protected override bool IsMatch(bool value)
        {
            return value;
        }
    }
}