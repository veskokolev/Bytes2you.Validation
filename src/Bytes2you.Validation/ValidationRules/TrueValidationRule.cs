using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal class TrueValidationRule : SingletonValidationRule<TrueValidationRule, bool>
    {
        private TrueValidationRule()
        {
        }

        protected override string GetValidMessage(bool value)
        {
            return ValidationRuleMessages.TrueMessage;
        }

        protected override string GetInvalidMessage(bool value)
        {
            return ValidationRuleMessages.FalseMessage;
        }

        protected override bool IsValid(bool value)
        {
            return value;
        }
    }
}