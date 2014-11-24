using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.ClassPredicates
{
    internal class NotNullValidationPredicate<T> : SingletonValidationPredicate<NotNullValidationPredicate<T>, T>
        where T : class
    {
        private NotNullValidationPredicate()
        {
        }

        protected override string GetMatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullMessage, value);
        }

        protected override string GetUnmatchMessage(T value)
        {
            return ValidationPredicateMessages.NullMessage;
        }

        protected override bool IsMatch(T value)
        {
            return value != null;
        }
    }
}