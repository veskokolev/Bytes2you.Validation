using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationPredicates.EnumerablePredicates
{
    internal class EnumerableNotNullOrEmptyValidationPredicate<T> : ValidationPredicate<T>
        where T : IEnumerable
    {
        private static readonly PortableLazy<EnumerableNotNullOrEmptyValidationPredicate<T>> lazyInstance;

        static EnumerableNotNullOrEmptyValidationPredicate()
        {
            lazyInstance = new PortableLazy<EnumerableNotNullOrEmptyValidationPredicate<T>>(() => new EnumerableNotNullOrEmptyValidationPredicate<T>());
        }

        private EnumerableNotNullOrEmptyValidationPredicate()
        {
        }

        public static EnumerableNotNullOrEmptyValidationPredicate<T> Instance
        {
            get
            {
                return lazyInstance.Value;
            }
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