using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.DoublePredicates
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
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotInfinityMessage, value);
        }
    }
}