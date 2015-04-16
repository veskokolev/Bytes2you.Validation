using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringEmptyValidationPredicate : ValidationPredicate<string>
    {
        private static readonly PortableLazy<StringEmptyValidationPredicate> lazyInstance;

        static StringEmptyValidationPredicate()
        {
            lazyInstance = new PortableLazy<StringEmptyValidationPredicate>(() => new StringEmptyValidationPredicate());
        }

        private StringEmptyValidationPredicate()
        {
        }

        public static StringEmptyValidationPredicate Instance
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
            return ValidationPredicateMessages.EmptyStringMessage;
        }

        protected override string GetUnmatchMessage(string value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotEmptyStringMessage, value);
        }

        protected override bool IsMatch(string value)
        {
            return StringHelper.IsEmpty(value);
        }
    }
}