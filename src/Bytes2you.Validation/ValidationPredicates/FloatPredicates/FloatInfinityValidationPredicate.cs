using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.FloatPredicates
{
    internal class FloatInfinityValidationPredicate : ValidationPredicate<float>
    {
        private static readonly PortableLazy<FloatInfinityValidationPredicate> lazyInstance;

        static FloatInfinityValidationPredicate()
        {
            lazyInstance = new PortableLazy<FloatInfinityValidationPredicate>(() => new FloatInfinityValidationPredicate());
        }

        private FloatInfinityValidationPredicate()
        {
        }

        public static FloatInfinityValidationPredicate Instance
        {
            get
            {
                return lazyInstance.Value;
            }
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
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotInfinityMessage, value);
        }
    }
}