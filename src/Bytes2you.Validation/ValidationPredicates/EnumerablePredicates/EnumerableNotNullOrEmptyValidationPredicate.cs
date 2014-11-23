using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.EnumerablePredicates
{
    internal class EnumerableNotNullOrEmptyValidationPredicate<T> : SingletonValidationPredicate<EnumerableNotNullOrEmptyValidationPredicate<T>, T>
        where T : IEnumerable
    {
        private EnumerableNotNullOrEmptyValidationPredicate()
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