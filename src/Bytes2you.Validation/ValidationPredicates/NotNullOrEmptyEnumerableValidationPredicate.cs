using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class NotNullOrEmptyEnumerableValidationPredicate<T> : SingletonValidationPredicate<NotNullOrEmptyEnumerableValidationPredicate<T>, T>
        where T : IEnumerable
    {
        private NotNullOrEmptyEnumerableValidationPredicate()
        {
        }

        protected override string GetMatchMessage(T value)
        {
            return ValidationPredicateMessages.NotNullOrEmptyEnumerableMessage;
        }

        protected override string GetUnmatchMessage(T value)
        {
            return ValidationPredicateMessages.NullOrEmptyEnumerableMessage;
        }

        protected override bool IsMatch(T value)
        {
            return !EnumerableHelper.IsNullOrEmpty(value);
        }
    }
}