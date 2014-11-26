using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.EnumerablePredicates
{
    internal class EnumerableNullOrEmptyValidationPredicate<T> : ValidationPredicate<T>
        where T : IEnumerable
    {
        private static readonly PortableLazy<EnumerableNullOrEmptyValidationPredicate<T>> lazyInstance;

        static EnumerableNullOrEmptyValidationPredicate()
        {
            lazyInstance = new PortableLazy<EnumerableNullOrEmptyValidationPredicate<T>>(() => new EnumerableNullOrEmptyValidationPredicate<T>());
        }

        private EnumerableNullOrEmptyValidationPredicate()
        {
        }

        public static EnumerableNullOrEmptyValidationPredicate<T> Instance
        {
            get
            {
                return lazyInstance.Value;
            }
        }

        protected override string GetMatchMessage(T value)
        {
            return ValidationPredicateMessages.NullOrEmptyEnumerableMessage;
        }

        protected override string GetUnmatchMessage(T value)
        {
            return ValidationPredicateMessages.NotNullOrEmptyEnumerableMessage;
        }

        protected override bool IsMatch(T value)
        {
            return EnumerableHelper.IsNullOrEmpty(value);
        }
    }
}