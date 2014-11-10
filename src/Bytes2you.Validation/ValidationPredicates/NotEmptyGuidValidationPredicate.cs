using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates
{
    internal class NotEmptyGuidValidationPredicate : SingletonValidationPredicate<NotEmptyGuidValidationPredicate, Guid>
    {
        private NotEmptyGuidValidationPredicate()
        {
        }

        protected override string GetMatchMessage(Guid value)
        {
            return string.Format(ValidationPredicateMessages.NotEmptyGuidMessage, value);
        }

        protected override string GetUnmatchMessage(Guid value)
        {
            return ValidationPredicateMessages.EmptyGuidMessage;
        }

        protected override bool IsMatch(Guid value)
        {
            return value != Guid.Empty;
        }
    }
}