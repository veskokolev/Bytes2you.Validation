using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class DoubleNotPositiveInfinityValidationPredicate : SingletonValidationPredicate<DoubleNotPositiveInfinityValidationPredicate, double>
    {
        private DoubleNotPositiveInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(double value)
        {
            return !double.IsPositiveInfinity(value);
        }

        protected override string GetMatchMessage(double value)
        {
            return string.Format(ValidationPredicateMessages.NotPositiveInfinityMessage, value);
        }

        protected override string GetUnmatchMessage(double value)
        {
            return ValidationPredicateMessages.PositiveInfinityMessage;
        }
    }
}