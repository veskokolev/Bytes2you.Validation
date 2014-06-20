using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal class NullOrEmptyStringValidationRule : SingletonValidationRule<NullOrEmptyStringValidationRule, string>
    {
        private NullOrEmptyStringValidationRule()
        {
        }

        protected override string GetValidMessage(string value)
        {
            return ValidationRuleMessages.NullOrEmptyStringMessage;
        }

        protected override string GetInvalidMessage(string value)
        {
            return string.Format(ValidationRuleMessages.NotNullOrEmptyStringMessage, value);
        }

        protected override bool IsValid(string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}