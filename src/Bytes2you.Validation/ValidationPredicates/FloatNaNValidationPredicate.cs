using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class FloatNaNValidationPredicate : SingletonValidationPredicate<FloatNaNValidationPredicate, float>
    {
        private FloatNaNValidationPredicate()
        {
        }

        protected override bool IsMatch(float value)
        {
            return float.IsNaN(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return ValidationPredicateMessages.NaNMessage;
        }

        protected override string GetUnmatchMessage(float value)
        {
            return string.Format(ValidationPredicateMessages.NotNaNMessage, value);
        }
    }
}