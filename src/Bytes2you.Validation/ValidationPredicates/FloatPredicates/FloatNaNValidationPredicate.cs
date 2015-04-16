using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.FloatPredicates
{
    internal class FloatNaNValidationPredicate : ValidationPredicate<float>
    {
        private static readonly PortableLazy<FloatNaNValidationPredicate> lazyInstance;

        static FloatNaNValidationPredicate()
        {
            lazyInstance = new PortableLazy<FloatNaNValidationPredicate>(() => new FloatNaNValidationPredicate());
        }

        private FloatNaNValidationPredicate()
        {
        }

        public static FloatNaNValidationPredicate Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        public override ValidationType ValidationType
        {
            get
            {
                return ValidationType.Default;
            }
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