using System;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.ClassPredicates
{
    internal class NullValidationPredicate<T> : SingletonValidationPredicate<NullValidationPredicate<T>, T>
        where T : class
    {
        private NullValidationPredicate()
        {
        }

        protected override string GetMatchMessage(T value)
        {
            return ValidationPredicateMessages.NullMessage;
        }

        protected override string GetUnmatchMessage(T value)
        {
            return MessageFormatHelper.Format(ValidationPredicateMessages.NotNullMessage, value);
        }

        protected override bool IsMatch(T value)
        {
            return value == null;
        }
    }
}