using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.DoublePredicates
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
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotInfinityMessage, value);
        }

        protected override string GetUnmatchMessage(double value)
        {
            return ValidationPredicateMessages.InfinityMessage;
        }
    }
}