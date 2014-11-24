using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.DoublePredicates
{
    internal class DoubleNaNValidationPredicate : SingletonValidationPredicate<DoubleNaNValidationPredicate, double>
    {
        private DoubleNaNValidationPredicate()
        {
        }

        protected override bool IsMatch(double value)
        {
            return double.IsNaN(value);
        }

        protected override string GetMatchMessage(double value)
        {
            return ValidationPredicateMessages.NaNMessage;
        }

        protected override string GetUnmatchMessage(double value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNaNMessage, value);
        }
    }
}