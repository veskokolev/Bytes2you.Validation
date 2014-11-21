using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class FloatNotNaNValidationPredicate : SingletonValidationPredicate<FloatNotNaNValidationPredicate, float>
    {
        private FloatNotNaNValidationPredicate()
        {
        }

        protected override bool IsMatch(float value)
        {
            return !float.IsNaN(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return string.Format(ValidationPredicateMessages.NotNaNMessage, value);
        }

        protected override string GetUnmatchMessage(float value)
        {
            return ValidationPredicateMessages.NaNMessage;
        }
    }
}