using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.FloatPredicates
{
    internal class FloatNotNaNValidationPredicate : ValidationPredicate<float>
    {
        private static readonly Lazy<FloatNotNaNValidationPredicate> lazyInstance;

        static FloatNotNaNValidationPredicate()
        {
            lazyInstance = new Lazy<FloatNotNaNValidationPredicate>(() => new FloatNotNaNValidationPredicate());
        }

        private FloatNotNaNValidationPredicate()
        {
        }

        public static FloatNotNaNValidationPredicate Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        protected override bool IsMatch(float value)
        {
            return !float.IsNaN(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNaNMessage, value);
        }

        protected override string GetUnmatchMessage(float value)
        {
            return ValidationPredicateMessages.NaNMessage;
        }
    }
}