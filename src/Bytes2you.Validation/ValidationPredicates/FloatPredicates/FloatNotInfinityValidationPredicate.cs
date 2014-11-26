using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.FloatPredicates
{
    internal class FloatNotInfinityValidationPredicate : ValidationPredicate<float>
    {
        private static readonly PortableLazy<FloatNotInfinityValidationPredicate> lazyInstance;

        static FloatNotInfinityValidationPredicate()
        {
            lazyInstance = new PortableLazy<FloatNotInfinityValidationPredicate>(() => new FloatNotInfinityValidationPredicate());
        }

        private FloatNotInfinityValidationPredicate()
        {
        }

        public static FloatNotInfinityValidationPredicate Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        protected override bool IsMatch(float value)
        {
            return !float.IsInfinity(value);
        }

        protected override string GetMatchMessage(float value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotInfinityMessage, value);
        }

        protected override string GetUnmatchMessage(float value)
        {
            return ValidationPredicateMessages.InfinityMessage;
        }
    }
}