using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.BoolPredicates
{
    internal class TrueValidationPredicate : ValidationPredicate<bool>
    {
        private static readonly Lazy<TrueValidationPredicate> lazyInstance;

        static TrueValidationPredicate()
        {
            lazyInstance = new Lazy<TrueValidationPredicate>(() => new TrueValidationPredicate());
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