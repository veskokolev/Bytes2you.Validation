using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringNotNullOrWhiteSpaceValidationPredicate : ValidationPredicate<string>
    {
        private static readonly PortableLazy<StringNotNullOrWhiteSpaceValidationPredicate> lazyInstance;

        static StringNotNullOrWhiteSpaceValidationPredicate()
        {
            lazyInstance = new PortableLazy<StringNotNullOrWhiteSpaceValidationPredicate>(() => new StringNotNullOrWhiteSpaceValidationPredicate());
        }

        private StringNotNullOrWhiteSpaceValidationPredicate()
        {
        }

        public static StringNotNullOrWhiteSpaceValidationPredicate Instance
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
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullOrWhiteSpaceStringMessage, value);
        }

        protected override string GetUnmatchMessage(string value)
        {
            return ValidationPredicateMessages.NullOrWhiteSpaceStringMessage;
        }

        protected override bool IsMatch(string value)
        {
            return !StringHelper.IsNullOrWhiteSpace(value);
        }
    }
}