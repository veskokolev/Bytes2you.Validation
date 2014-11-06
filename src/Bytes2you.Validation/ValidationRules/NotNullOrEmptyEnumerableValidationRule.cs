using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationRules
{
    internal class NotNullOrEmptyEnumerableValidationRule<T> : SingletonValidationRule<NotNullOrEmptyEnumerableValidationRule<T>, T>
        where T : IEnumerable
    {
        private NotNullOrEmptyEnumerableValidationRule()
        {
        }

        protected override string GetValidMessage(T value)
        {
            return ValidationRuleMessages.NotNullOrEmptyEnumerableMessage;
        }

        protected override string GetInvalidMessage(T value)
        {
            return ValidationRuleMessages.NullOrEmptyEnumerableMessage;
        }

        protected override bool IsValid(T value)
        {
            return !EnumerableHelper.IsNullOrEmpty(value);
        }
    }
}