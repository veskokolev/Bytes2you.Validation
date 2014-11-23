using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.FloatPredicates
{
    internal class FloatNotInfinityValidationPredicate : SingletonValidationPredicate<FloatNotInfinityValidationPredicate, float>
    {
        private FloatNotInfinityValidationPredicate()
        {
        }

        protected override bool IsMatch(float value)
        {
            return !float.IsInfinity(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return string.Format(ValidationPredicateMessages.NotInfinityMessage, value);
        }

        protected override string GetUnmatchMessage(float value)
        {
            return ValidationPredicateMessages.InfinityMessage;
        }
    }
}