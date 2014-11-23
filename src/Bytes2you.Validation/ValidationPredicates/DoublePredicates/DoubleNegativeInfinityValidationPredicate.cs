using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.DoublePredicates
{
    internal class DoubleNegativeInfinityValidationPredicate : SingletonValidationPredicate<DoubleNegativeInfinityValidationPredicate, double>
    {
        private DoubleNegativeInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(double value)
        {
            return double.IsNegativeInfinity(value);
        }

        protected override string GetMatchMessage(double value)
        {
            return ValidationPredicateMessages.NegativeInfinityMessage;
        }

        protected override string GetUnmatchMessage(double value)
        {
            return string.Format(ValidationPredicateMessages.NotNegativeInfinityMessage, value);
        }
    }
}