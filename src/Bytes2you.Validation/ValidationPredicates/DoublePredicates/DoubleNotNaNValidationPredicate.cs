using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.DoublePredicates
{
    internal class DoubleNotNaNValidationPredicate : SingletonValidationPredicate<DoubleNotNaNValidationPredicate, double>
    {
        private DoubleNotNaNValidationPredicate()
        {
        }

        protected override bool IsMatch(double value)
        {
            return !double.IsNaN(value);
        }

        protected override string GetMatchMessage(double value)
        {
            return string.Format(ValidationPredicateMessages.NotNaNMessage, value);
        }

        protected override string GetUnmatchMessage(double value)
        {
            return ValidationPredicateMessages.NaNMessage;
        }
    }
}