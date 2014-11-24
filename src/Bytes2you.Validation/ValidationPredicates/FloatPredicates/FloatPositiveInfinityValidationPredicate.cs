using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.FloatPredicates
{
    internal class FloatPositiveInfinityValidationPredicate : SingletonValidationPredicate<FloatPositiveInfinityValidationPredicate, float>
    {
        private FloatPositiveInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(float value)
        {
            return float.IsPositiveInfinity(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return ValidationPredicateMessages.PositiveInfinityMessage;
        }

        protected override string GetUnmatchMessage(float value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotPositiveInfinityMessage, value);
        }
    }
}