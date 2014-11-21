using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class FloatNegativeInfinityValidationPredicate : SingletonValidationPredicate<FloatNegativeInfinityValidationPredicate, float>
    {
        private FloatNegativeInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(float value)
        {
            return double.IsNegativeInfinity(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return ValidationPredicateMessages.NegativeInfinityMessage;
        }

        protected override string GetUnmatchMessage(float value)
        {
            return string.Format(ValidationPredicateMessages.NotNegativeInfinityMessage, value);
        }
    }
}