using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.FloatPredicates
{
    internal class FloatNotPositiveInfinityValidationPredicate : SingletonValidationPredicate<FloatNotPositiveInfinityValidationPredicate, float>
    {
        private FloatNotPositiveInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(float value)
        {
            return !float.IsPositiveInfinity(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return string.Format(ValidationPredicateMessages.NotPositiveInfinityMessage, value);
        }

        protected override string GetUnmatchMessage(float value)
        {
            return ValidationPredicateMessages.PositiveInfinityMessage;
        }
    }
}