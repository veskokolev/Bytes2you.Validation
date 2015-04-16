using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringNullOrWhiteSpaceValidationPredicate : ValidationPredicate<string>
    {
        private static readonly PortableLazy<StringNullOrWhiteSpaceValidationPredicate> lazyInstance;

        static StringNullOrWhiteSpaceValidationPredicate()
        {
            lazyInstance = new PortableLazy<StringNullOrWhiteSpaceValidationPredicate>(() => new StringNullOrWhiteSpaceValidationPredicate());
        }

        private StringNullOrWhiteSpaceValidationPredicate()
        {
        }

        public static StringNullOrWhiteSpaceValidationPredicate Instance
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
            return ValidationPredicateMessages.NullOrWhiteSpaceStringMessage;
        }

        protected override string GetUnmatchMessage(string value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullOrWhiteSpaceStringMessage, value);
        }

        protected override bool IsMatch(string value)
        {
            return StringHelper.IsNullOrWhiteSpace(value);
        }
    }
}