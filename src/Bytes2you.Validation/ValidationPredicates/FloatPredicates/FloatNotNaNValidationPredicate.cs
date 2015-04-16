using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.FloatPredicates
{
    internal class FloatNotNaNValidationPredicate : ValidationPredicate<float>
    {
        private static readonly PortableLazy<FloatNotNaNValidationPredicate> lazyInstance;

        static FloatNotNaNValidationPredicate()
        {
            lazyInstance = new PortableLazy<FloatNotNaNValidationPredicate>(() => new FloatNotNaNValidationPredicate());
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

        public override ValidationType ValidationType
        {
            get
            {
                return ValidationType.Default;
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