using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.DoublePredicates
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
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotPositiveInfinityMessage, value);
        }

        protected override string GetUnmatchMessage(double value)
        {
            return ValidationPredicateMessages.PositiveInfinityMessage;
        }
    }
}