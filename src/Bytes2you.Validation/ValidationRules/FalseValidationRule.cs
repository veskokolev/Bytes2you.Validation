using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal class FalseValidationRule : SingletonValidationRule<FalseValidationRule, bool>
    {
        private FalseValidationRule()
        {
        }

        protected override string GetValidMessage(bool value)
        {
            return ValidationRuleMessages.FalseMessage;
        }

        protected override string GetInvalidMessage(bool value)
        {
            return ValidationRuleMessages.TrueMessage;
        }

        protected override bool IsValid(bool value)
        {
            return !value;
        }
    }
}