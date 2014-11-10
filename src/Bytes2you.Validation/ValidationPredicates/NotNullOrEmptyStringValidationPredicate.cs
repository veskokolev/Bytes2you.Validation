using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class NotNullOrEmptyStringValidationPredicate : SingletonValidationPredicate<NotNullOrEmptyStringValidationPredicate, string>
    {
        private NotNullOrEmptyStringValidationPredicate()
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