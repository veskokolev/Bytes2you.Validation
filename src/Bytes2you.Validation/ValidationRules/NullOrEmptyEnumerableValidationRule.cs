using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationRules
{
    internal class NullOrEmptyEnumerableValidationRule<T> : SingletonValidationRule<NullOrEmptyEnumerableValidationRule<T>, T>
        where T : IEnumerable
    {
        private NullOrEmptyEnumerableValidationRule()
        {
        }

        protected override string GetValidMessage(T value)
        {
            return ValidationRuleMessages.NullOrEmptyEnumerableMessage;
        }

        protected override string GetInvalidMessage(T value)
        {
            return ValidationRuleMessages.NotNullOrEmptyEnumerableMessage;
        }

        protected override bool IsValid(T value)
        {
            return EnumerableHelper.IsNullOrEmpty(value);
        }
    }
}