using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationRules
{
    internal class NotEmptyGuidValidationRule : SingletonValidationRule<NotEmptyGuidValidationRule, Guid>
    {
        private NotEmptyGuidValidationRule()
        {
        }

        protected override string GetValidMessage(Guid value)
        {
            return string.Format(ValidationRuleMessages.NotEmptyGuidMessage, value);
        }

        protected override string GetInvalidMessage(Guid value)
        {
            return ValidationRuleMessages.EmptyGuidMessage;
        }

        protected override bool IsValid(Guid value)
        {
            return value != Guid.Empty;
        }
    }
}