using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.BoolPredicates
{
    internal class TrueValidationPredicate : ValidationPredicate<bool>
    {
        private static readonly PortableLazy<TrueValidationPredicate> lazyInstance;

        static TrueValidationPredicate()
        {
            lazyInstance = new PortableLazy<TrueValidationPredicate>(() => new TrueValidationPredicate());
        }

        private TrueValidationPredicate()
        {
        }

        public static TrueValidationPredicate Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        protected override string GetMatchMessage(bool value)
        {
            return ValidationPredicateMessages.TrueMessage;
        }

        protected override string GetUnmatchMessage(bool value)
        {
            return ValidationPredicateMessages.FalseMessage;
        }

        protected override bool IsMatch(bool value)
        {
            return value;
        }
    }
}