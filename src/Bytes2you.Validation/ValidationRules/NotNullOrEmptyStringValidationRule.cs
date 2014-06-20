using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal class NotNullOrEmptyStringValidationRule : SingletonValidationRule<NotNullOrEmptyStringValidationRule, string>
    {
        private NotNullOrEmptyStringValidationRule()
        {
        }

        protected override string GetValidMessage(string value)
        {
            return ValidationRuleMessages.NotNullOrEmptyStringMessage;
        }

        protected override string GetInvalidMessage(string value)
        {
            return ValidationRuleMessages.NullOrEmptyStringMessage;
        }

        protected override bool IsValid(string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}