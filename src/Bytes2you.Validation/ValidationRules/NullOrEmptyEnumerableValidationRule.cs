using System;
using System.Collections;
using System.Linq;
using Bytes2you.Validation.Helpers;

namespace Bytes2you.Validation.ValidationRules
{
    internal class NullOrEmptyEnumerableValidationRule : SingletonValidationRule<NullOrEmptyEnumerableValidationRule, IEnumerable>
    {
        private NullOrEmptyEnumerableValidationRule()
        {
        }

        protected override string GetValidMessage(IEnumerable value)
        {
            return ValidationRuleMessages.NullOrEmptyEnumerableMessage;
        }

        protected override string GetInvalidMessage(IEnumerable value)
        {
            return ValidationRuleMessages.NotNullOrEmptyEnumerableMessage;
        }

        protected override bool IsValid(IEnumerable value)
        {
            return EnumerableHelper.IsNullOrEmpty(value);
        }
    }
}