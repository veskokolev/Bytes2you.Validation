using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class FloatNotNegativeInfinityValidationPredicate : SingletonValidationPredicate<FloatNotNegativeInfinityValidationPredicate, float>
    {
        private FloatNotNegativeInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(float value)
        {
            return !double.IsNegativeInfinity(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return string.Format(ValidationPredicateMessages.NotNegativeInfinityMessage, value);
        }

        protected override string GetUnmatchMessage(float value)
        {
            return ValidationPredicateMessages.NegativeInfinityMessage;
        }
    }
}