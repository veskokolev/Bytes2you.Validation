using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.DoublePredicates
{
    internal class DoublePositiveInfinityValidationPredicate : SingletonValidationPredicate<DoublePositiveInfinityValidationPredicate, double>
    {
        private DoublePositiveInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(double value)
        {
            return double.IsPositiveInfinity(value);
        }

        protected override string GetMatchMessage(double value)
        {
            return ValidationPredicateMessages.PositiveInfinityMessage;
        }

        protected override string GetUnmatchMessage(double value)
        {
            return string.Format(ValidationPredicateMessages.NotPositiveInfinityMessage, value);
        }
    }
}