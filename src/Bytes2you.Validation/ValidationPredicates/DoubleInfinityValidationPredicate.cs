using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class DoubleInfinityValidationPredicate : SingletonValidationPredicate<DoubleInfinityValidationPredicate, double>
    {
        private DoubleInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(double value)
        {
            return double.IsInfinity(value);
        }

        protected override string GetMatchMessage(double value)
        {
            return ValidationPredicateMessages.InfinityMessage;
        }

        protected override string GetUnmatchMessage(double value)
        {
            return string.Format(ValidationPredicateMessages.NotInfinityMessage, value);
        }
    }
}