using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal class NotNullValidationRule<T> : SingletonValidationRule<NotNullValidationRule<T>, T>
        where T : class
    {
        private NotNullValidationRule()
        {
        }

        protected override string GetValidMessage(T value)
        {
            return ValidationRuleMessages.NotNullMessage;
        }

        protected override string GetInvalidMessage(T value)
        {
            return ValidationRuleMessages.NullMessage;
        }

        protected override bool IsValid(T value)
        {
            return value != null;
        }
    }
}