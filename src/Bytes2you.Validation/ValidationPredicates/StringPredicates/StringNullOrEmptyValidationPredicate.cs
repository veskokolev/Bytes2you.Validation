using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringNullOrEmptyValidationPredicate : ValidationPredicate<string>
    {
        private static readonly PortableLazy<StringNullOrEmptyValidationPredicate> lazyInstance;

        static StringNullOrEmptyValidationPredicate()
        {
            lazyInstance = new PortableLazy<StringNullOrEmptyValidationPredicate>(() => new StringNullOrEmptyValidationPredicate());
        }

        private StringNullOrEmptyValidationPredicate()
        {
        }

        public static StringNullOrEmptyValidationPredicate Instance
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
            return ValidationPredicateMessages.NullOrEmptyStringMessage;
        }

        protected override string GetUnmatchMessage(string value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullOrEmptyStringMessage, value);
        }

        protected override bool IsMatch(string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}