using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringNullOrEmptyValidationPredicate : SingletonValidationPredicate<StringNullOrEmptyValidationPredicate, string>
    {
        private StringNullOrEmptyValidationPredicate()
        {
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