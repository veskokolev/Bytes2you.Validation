using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class NotNullValidationPredicate<T> : SingletonValidationPredicate<NotNullValidationPredicate<T>, T>
        where T : class
    {
        private NotNullValidationPredicate()
        {
        }

        protected override string GetMatchMessage(T value)
        {
            return ValidationPredicateMessages.NotNullMessage;
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