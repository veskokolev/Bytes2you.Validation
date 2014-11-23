using System;
using System.Linq;

namespace Bytes2you.Validation.ValidationPredicates.GuidPredicates
{
    internal class GuidEmptyValidationPredicate : SingletonValidationPredicate<GuidEmptyValidationPredicate, Guid>
    {
        private GuidEmptyValidationPredicate()
        {
        }

        protected override bool IsMatch(Guid value)
        {
            return value == Guid.Empty;
        }

        protected override string GetMatchMessage(Guid value)
        {
            return ValidationPredicateMessages.EmptyGuidMessage;
        }

        protected override string GetUnmatchMessage(Guid value)
        {
            return string.Format(ValidationPredicateMessages.NotEmptyGuidMessage, value);
        }
    }
}