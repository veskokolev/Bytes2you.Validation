using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.FloatPredicates
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
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNaNMessage, value);
        }
    }
}