using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
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
            return string.Format(ValidationPredicateMessages.NotPositiveInfinityMessage, value);
        }
    }
}