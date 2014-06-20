using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal class EmptyGuidValidationRule : SingletonValidationRule<EmptyGuidValidationRule, Guid>
    {
        private EmptyGuidValidationRule()
        {
        }

        protected override bool IsValid(Guid value)
        {
            return value == Guid.Empty;
        }

        protected override string GetValidMessage(Guid value)
        {
            return ValidationRuleMessages.EmptyGuidMessage;
        }

        protected override string GetInvalidMessage(Guid value)
        {
            return string.Format(ValidationRuleMessages.NotEmptyGuidMessage, value);
        }
    }
}