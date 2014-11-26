using Bytes2you.Validation.Helpers;
using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.BoolPredicates
{
    internal class FalseValidationPredicate : ValidationPredicate<bool>
    {
        private static readonly Lazy<FalseValidationPredicate> lazyInstance;

        static FalseValidationPredicate()
        {
            lazyInstance = new Lazy<FalseValidationPredicate>(() => new FalseValidationPredicate());
        }

        private FalseValidationPredicate()
        {
        }

        public static FalseValidationPredicate Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        protected override string GetMatchMessage(bool value)
        {
            return ValidationPredicateMessages.FalseMessage;
        }

        protected override string GetUnmatchMessage(bool value)
        {
            return ValidationPredicateMessages.TrueMessage;
        }

        protected override bool IsMatch(bool value)
        {
            return !value;
        }
    }
}