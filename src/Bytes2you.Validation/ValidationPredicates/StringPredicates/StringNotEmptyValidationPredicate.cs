using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringNotEmptyValidationPredicate : ValidationPredicate<string>
    {
        private static readonly PortableLazy<StringNotEmptyValidationPredicate> lazyInstance;

        static StringNotEmptyValidationPredicate()
        {
            lazyInstance = new PortableLazy<StringNotEmptyValidationPredicate>(() => new StringNotEmptyValidationPredicate());
        }

        private StringNotEmptyValidationPredicate()
        {
        }

        public static StringNotEmptyValidationPredicate Instance
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
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotEmptyStringMessage, value);
        }

        protected override string GetUnmatchMessage(string value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.EmptyStringMessage, value);
        }

        protected override bool IsMatch(string value)
        {
            return !StringHelper.IsEmpty(value);
        }
    }
}