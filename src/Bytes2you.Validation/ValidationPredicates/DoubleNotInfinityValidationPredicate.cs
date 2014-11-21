using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class DoubleNotInfinityValidationPredicate : SingletonValidationPredicate<DoubleNotInfinityValidationPredicate, double>
    {
        private DoubleNotInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(double value)
        {
            return !double.IsInfinity(value);
        }

        protected override string GetMatchMessage(double value)
        {
            return string.Format(ValidationPredicateMessages.NotInfinityMessage, value);
        }

        protected override string GetUnmatchMessage(double value)
        {
            return ValidationPredicateMessages.InfinityMessage;
        }
    }
}