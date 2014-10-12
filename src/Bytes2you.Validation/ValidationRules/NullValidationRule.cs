using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal class NullValidationRule<T> : SingletonValidationRule<NullValidationRule<T>, T>
        where T : class
    {
        private NullValidationRule()
        {
        }

        protected override string GetValidMessage(T value)
        {
            return ValidationRuleMessages.NullMessage;
        }

        protected override string GetInvalidMessage(T value)
        {
            return ValidationRuleMessages.NotNullMessage;
        }

        protected override bool IsValid(T value)
        {
            return value == null;
        }
    }
}