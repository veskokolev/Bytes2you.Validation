using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.StringPredicates
{
    internal class StringNotNullOrEmptyValidationPredicate : SingletonValidationPredicate<StringNotNullOrEmptyValidationPredicate, string>
    {
        private StringNotNullOrEmptyValidationPredicate()
        {
        }

        protected override string GetMatchMessage(string value)
        {
            return ValidationPredicateMessages.NotNullOrEmptyStringMessage;
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