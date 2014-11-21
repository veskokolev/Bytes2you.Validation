using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class FloatInfinityValidationPredicate : SingletonValidationPredicate<FloatInfinityValidationPredicate, float>
    {
        private FloatInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(float value)
        {
            return float.IsInfinity(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return ValidationPredicateMessages.InfinityMessage;
        }

        protected override string GetUnmatchMessage(float value)
        {
            return string.Format(ValidationPredicateMessages.NotInfinityMessage, value);
        }
    }
}