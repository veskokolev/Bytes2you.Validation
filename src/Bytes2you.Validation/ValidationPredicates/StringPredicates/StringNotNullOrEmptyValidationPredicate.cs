using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringNotNullOrEmptyValidationPredicate : ValidationPredicate<string>
    {
        private static readonly PortableLazy<StringNotNullOrEmptyValidationPredicate> lazyInstance;

        static StringNotNullOrEmptyValidationPredicate()
        {
            lazyInstance = new PortableLazy<StringNotNullOrEmptyValidationPredicate>(() => new StringNotNullOrEmptyValidationPredicate());
        }

        private StringNotNullOrEmptyValidationPredicate()
        {
        }

        public static StringNotNullOrEmptyValidationPredicate Instance
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

        protected override string GetMatchMessage(string value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullOrEmptyStringMessage, value);
        }

        protected override string GetUnmatchMessage(string value)
        {
            return ValidationPredicateMessages.NullOrEmptyStringMessage;
        }

        protected override bool IsMatch(string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}