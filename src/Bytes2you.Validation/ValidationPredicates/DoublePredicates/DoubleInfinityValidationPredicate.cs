using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.DoublePredicates
{
    internal class DoubleInfinityValidationPredicate : ValidationPredicate<double>
    {
        private static readonly PortableLazy<DoubleInfinityValidationPredicate> lazyInstance;

        static DoubleInfinityValidationPredicate()
        {
            lazyInstance = new PortableLazy<DoubleInfinityValidationPredicate>(() => new DoubleInfinityValidationPredicate());
        }

        private DoubleInfinityValidationPredicate()
        {
        }

        public static DoubleInfinityValidationPredicate Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        protected override bool IsMatch(double value)
        {
            return double.IsInfinity(value);
        }

        protected override string GetMatchMessage(double value)
        {
            return ValidationPredicateMessages.InfinityMessage;
        }

        protected override string GetUnmatchMessage(double value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotInfinityMessage, value);
        }
    }
}